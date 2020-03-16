using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using tools.helper;
using tools.objects;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
//using OpenQA.Selenium.PhantomJS;
using System.Threading;

namespace tools
{
    public partial class Form1 : Form
    {
        string targetMergeUrl = "";
        string targetMergeCompany = "";
        string targetMergeUsername = "";
        string targetMergePassword = "";

        string browserDriver = "";
        IWebDriver driver;

        string graboneFileName = "";//用于grabone合单
        string parcelportInitialFileName = "";//parcelport原始文件

        List<string> mergedOrdersList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            lblgrabonestatus.Text = "程序准备完成，请先选择文件。";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                graboneFileName = fileDialog.FileName;
                //MessageBox.Show("已选择文件:" + fileName, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblgrabonemergefilename.Text = graboneFileName;
                lblgrabonestatus.Text = "已选择要合并的文件，请点击执行按钮执行合单。";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblgrabonestatus.Text = "Start creating orders......";
            lblgrabonestatus.ForeColor = Color.Blue;

            //设定信息
            targetMergeUrl = txtOmisUrl.Text;
            targetMergeUsername = txtUsername.Text;
            targetMergePassword = txtPassword.Text;
            targetMergeCompany = txtCompany.Text;

            browserDriver = txtChromeDriver.Text;

            //准备selenium web driver
            driver = new ChromeDriver(browserDriver);

            try
            {
                //打开并登录omins
                driver.Url = targetMergeUrl;
                driver.Manage().Window.Maximize();
                //driver.Manage().Window.Minimize();

                IWebElement elmCompany = driver.FindElement(By.XPath("//*[@id='company_name']"));
                IWebElement elmUsername = driver.FindElement(By.XPath("//*[@id='username']"));
                IWebElement elmPassword = driver.FindElement(By.XPath("//*[@id='password']"));
                IWebElement elmLogin = driver.FindElement(By.XPath("//*[@id='loginButton']"));

                elmCompany.SendKeys(targetMergeCompany);
                elmUsername.SendKeys(targetMergeUsername);
                elmPassword.SendKeys(targetMergePassword);

                elmLogin.Click();
                //driver.Close();
                //打开新建单页面
                ClickAndWaitForPageToLoad("//*[@id='menuBar']/li[1]/a",5);

                int row = -1;
                //循环读csv文件
                using (var reader = new StreamReader(graboneFileName))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        ++row;
                        if (row == 0) continue;

                        IWebElement elmNewButton = driver.FindElement(By.XPath("//*[@id='recordCommands']/input[2]"));
                        elmNewButton.Click();
                        WaitForTheElementExistingInThePage("//*[@id='ds-contact_id']", 3);////*[@id="ds-contact_id"]

                        var values = line.Split(',');

                        #region operation
                        //customer
                        IWebElement elmNewUserName = driver.FindElement(By.XPath("//*[@id='ds-contact_id']"));
                        elmNewUserName.SendKeys("Grab one");
                        //ship to
                        IWebElement elmNewName = driver.FindElement(By.XPath("//*[@id='name']"));
                        elmNewName.SendKeys(values[9]);
                        IWebElement elmNewCompany = driver.FindElement(By.XPath("//*[@id='company']"));
                        elmNewCompany.SendKeys("GrabOne");
                        IWebElement elmNewAddress = driver.FindElement(By.XPath("//*[@id='address']"));
                        elmNewAddress.SendKeys(values[10]+","+ values[11] + "," + values[12]);
                        IWebElement elmNewCity = driver.FindElement(By.XPath("//*[@id='city']"));
                        elmNewCity.SendKeys(values[13]);
                        IWebElement elmNewPostcode = driver.FindElement(By.XPath("//*[@id='postcode']"));
                        elmNewPostcode.SendKeys(values[14]);
                        IWebElement elmNewCountry = driver.FindElement(By.XPath("//*[@id='country']"));
                        elmNewCountry.Clear();
                        elmNewCountry.SendKeys(values[15]);
                        IWebElement elmNewPhone = driver.FindElement(By.XPath("//*[@id='phone']"));
                        elmNewPhone.SendKeys(values[16]);
                        IWebElement elmNewEmail = driver.FindElement(By.XPath("//*[@id='email']"));
                        elmNewEmail.SendKeys("warehouse@systec.co.nz");
                        //Attributes
                        IWebElement elmNewOrderdate = driver.FindElement(By.XPath("//*[@id='orderdate']"));
                        elmNewOrderdate.SendKeys(values[4]);
                        IWebElement elmNewDuedate = driver.FindElement(By.XPath("//*[@id='duedate']"));
                        elmNewDuedate.SendKeys(DateTime.ParseExact(values[4], "dd/MM/yyyy H:mm", System.Globalization.CultureInfo.CurrentCulture).AddDays(14).ToString("dd/MM/yyyy"));
                        //customer PO#://*[@id="ponumber"]
                        IWebElement elmNewPO = driver.FindElement(By.XPath("//*[@id='ponumber']"));
                        elmNewPO.SendKeys(values[0]);
                        IWebElement elmNewNote = driver.FindElement(By.XPath("//*[@id='note']"));
                        elmNewNote.SendKeys("Grab one-" + values[0]);
                        //Status
                        IWebElement elmNewCurrentStatus = driver.FindElement(By.XPath("//*[@id='statusid']"));
                        new SelectElement(elmNewCurrentStatus).SelectByValue("13-processing");//ready
                        IWebElement elmNewPaidStatus = driver.FindElement(By.XPath("//*[@id='paid']"));
                        new SelectElement(elmNewPaidStatus).SelectByValue("1");//paid
                        IWebElement elmNewStatusDate = driver.FindElement(By.XPath("//*[@id='statusdate']"));
                        elmNewStatusDate.SendKeys(DateTime.Now.ToString("dd/MM/yyyy"));
                        //line items
                        IWebElement elmNewPartNumber = driver.FindElement(By.XPath("//*[@id='ds-partnumber']"));
                        elmNewPartNumber.SendKeys(values[8]);
                        //IWebElement elmNewUnitPrice = driver.FindElement(By.XPath("//*[@id='price']"));
                        //elmNewUnitPrice.SendKeys(values[]);
                        IWebElement elmNewQty = driver.FindElement(By.XPath("//*[@id='qty']"));
                        elmNewQty.Clear();
                        elmNewQty.SendKeys(values[1]);
                        //paymen'
                        IWebElement elmNewPaynote = driver.FindElement(By.XPath("//*[@id='payment_notes']"));
                        elmNewPaynote.SendKeys("");
                        IWebElement elmNewPayDate = driver.FindElement(By.XPath("//*[@id='payment_date']"));
                        elmNewPayDate.SendKeys("");
                        IWebElement elmNewPayMethod = driver.FindElement(By.XPath("//*[@id='payment_method']"));
                        new SelectElement(elmNewPayMethod).SelectByValue("-1016");//trademe-other
                        IWebElement elmNewAmount = driver.FindElement(By.XPath("//*[@id='payment_amount']"));
                        elmNewAmount.Clear();
                        elmNewAmount.SendKeys(Convert.ToDecimal(values[2]).ToString("C2"));
                        //instructions
                        IWebElement elmNewSpecialInstruction = driver.FindElement(By.XPath("//*[@id='specialinstructions']"));
                        elmNewSpecialInstruction.SendKeys("billing name: " + values[3]);
                        //button
                        IWebElement elmNewCancel = driver.FindElement(By.XPath("//*[@id='cancelButton2']"));
                        IWebElement elmNewSave = driver.FindElement(By.XPath("//*[@id='saveButton2']"));
                        elmNewCancel.Click();//todo

                        //get the generated orderid and add to the list
                        WaitForTheElementExistingInThePage("//*[@id='queryresults']",15);
                        
                        var elmOrderTable = driver.FindElement(By.XPath("//*[@id='queryresults']"));
                        var rows = elmOrderTable.FindElements(By.TagName("tr"));
                        foreach (var r in rows)
                        {
                            if (r.Text.Contains(values[0]))
                            {
                                mergedOrdersList.Add(r.FindElements(By.TagName("td"))[1].Text);
                            }
                        }
                    }

                    driver.Close();
                    #endregion
                }
                //todo:return result to the page
                mergedOrdersList.Add("36666");
                mergedOrdersList.Add("36667");
                mergedOrdersList.Add("36668");

                lstgrabonemergedorders.DataSource = mergedOrdersList;
                lstgrabonemergedorders.Refresh();
                lblgrabonestatus.Text = mergedOrdersList.Count + " orders merged into omins.";
                lblgrabonestatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                lblgrabonestatus.Text = "Error happaned.";
                lblgrabonestatus.ForeColor = Color.Red;
            }
        }

        public void ClickAndWaitForPageToLoad(string elementLocator, int timeout = 10)
        {
            try
            {
                //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                //var element = driver.FindElement(By.XPath(elementLocator));
                //element.Click();
                //wait.Until(ExpectedConditions.StalenessOf(element));
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
        public void WaitForTheElementExistingInThePage(string elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                //var element = driver.FindElement();
                wait.Until(ExpectedConditions.ElementExists(By.XPath(elementLocator)));
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("已选择文件:" + fileName, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parcelportInitialFileName = fileDialog.FileName;
                lblParcelPortFileName.Text = parcelportInitialFileName;
                lblParcelPortStatus.Text = "已选择原始文件，请生成信息整理临时文件。";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        //取omins文件记录进行地址校验，生成临时文件并打开，供人工确认
        //读写csv：linq to csv
        //操作，读写excel：NPOI
        private void btnAddrValidAndGenerateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                //读取CSV
                #region demo
                //string demoPath = @"E:\Study\gmart\New folder\trademe-csv_export (202002211034) - Copy - Copy - Copy.csv";
                //parcelportInitialFileName = demoPath;
                #endregion

                List<CSVForParcelportRow> CSVForParcelportRows = CSVHelper.Read<CSVForParcelportRow>(parcelportInitialFileName);
                List<WorkForParcelportRow> WorkForParcelportRows = new List<WorkForParcelportRow>();
                CSVForParcelportRows.ForEach((CSVForParcelportRow) =>
                {
                    WorkForParcelportRow newWorkForParcelportRow = new WorkForParcelportRow();
                    newWorkForParcelportRow.CSVForParcelportRow = CSVForParcelportRow;
                    WorkForParcelportRows.Add(newWorkForParcelportRow);
                });

                #region xlsm
                ////写入地址校验Excel并执行校验
                //string addressValidationExcelPath = "E:\\Study\\gmart\\AddyCleanseV6.xlsm";
                //XSSFWorkbook templateWorkbook;
                //using (FileStream fs = new FileStream(addressValidationExcelPath, FileMode.Open, FileAccess.ReadWrite))
                //{
                //    templateWorkbook = new XSSFWorkbook(fs);
                //    fs.Close();
                //}

                //XSSFSheet sheet = (XSSFSheet)templateWorkbook.GetSheet("Addresses");
                //sheet.GetRow(4).GetCell(0).SetCellValue("111");//TODO
                ////sheet.ForceFormulaRecalculation = true;

                //File.Delete(addressValidationExcelPath);

                //using (FileStream file = new FileStream(addressValidationExcelPath, FileMode.CreateNew, FileAccess.Write))
                //{
                //    templateWorkbook.Write(file);
                //    file.Close();
                //}
                #endregion

                //Address validation and getting parcel spec
                foreach (WorkForParcelportRow row in WorkForParcelportRows)
                {
                    ////To addy
                    //var addressValidated = AddressValidationHelper.GetCleansedAddress(
                    //    string.Format("{0} {1} {2} {3}", 
                    //    row.CSVForParcelportRow.Address.Replace('\n',' '), 
                    //    row.CSVForParcelportRow.City, 
                    //    row.CSVForParcelportRow.Country, 
                    //    row.CSVForParcelportRow.Postcode));

                    //To post man mock
                    var addressValidated = AddressValidationHelper.GetCleansedAddress(
                        string.Format("{0} {1} {2} {3}",
                        row.CSVForParcelportRow.Address.Replace('\n', ' '),
                        row.CSVForParcelportRow.City,
                        row.CSVForParcelportRow.Country,
                        row.CSVForParcelportRow.Postcode),
                        WorkForParcelportRows.IndexOf(row)+1
                        );
                    row.AddressValidated = addressValidated;
                    row.InitialFullAddress = string.Format("{0} {1} {2} {3}", row.CSVForParcelportRow.Address, row.CSVForParcelportRow.City, row.CSVForParcelportRow.Country, row.CSVForParcelportRow.Postcode);
                    Dictionary<string, int> parcelItemsInfo = Tools.GetParcelItemsAndQuantity(row.CSVForParcelportRow.Codeqty);

                    List<Parcel> parcelSpecs = new List<Parcel>();
                    foreach (KeyValuePair<string,int> item in parcelItemsInfo)
                    {
                        Parcel parcelSpec = ParcelSpecHelper.GetParcelSpec(item.Key);
                        for (int i = 0; i < item.Value; i++)
                        {
                            parcelSpecs.Add(parcelSpec);
                        }
                    }
                    row.Parcels = parcelSpecs.ToArray();
                }
                Console.Out.WriteLine(WorkForParcelportRows);

                //生成并写入临时文件(list->npoi->excel)
                string generatedTempExcelPath = $"E:\\Study\\gmart\\temp_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";
                var result = new ExcelHelper().Export(WorkForParcelportRows, generatedTempExcelPath,"temp");
                if (result)
                {
                    lblParcelPortStatus.Text = "临时文件已经生成，请确认校验的地址是否正确并选择要打印的之后，再打印。";

                    #region open excel
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    /////TODO:打开文件，等待人工确认->
                    //System.Diagnostics.Process p = new System.Diagnostics.Process();
                    //p.StartInfo.UseShellExecute = true;
                    //p.StartInfo.FileName = generatedTempExcelPath;
                    //p.Start();
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    #endregion

                    //TODO：弹出新Form，人工确认和选择后，打印。
                    AddressValidatedListForm avlf = new AddressValidatedListForm();
                    avlf.PassingArgs(WorkForParcelportRows);
                    avlf.Show();

                }
                else 
                {
                    //TODO
                    Console.WriteLine("Excel export failed.");
                    lblParcelPortStatus.Text = "临时文件生成失败，请联系相关人员查看。";
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                lblParcelPortStatus.Text = "临时文件生成失败，请联系相关人员查看。";
            }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //使用确认后的临时文件，循环shipping quota api calling并创建邮单

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //选择新创建的邮单，保存PDF在本地（之后可以选择自行打印）

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddressValidatedListForm avlf = new AddressValidatedListForm();
            avlf.Show();
        }

        private void btnRewirteTrackingInfo_Click(object sender, EventArgs e)
        {
            
            
        }

        /// <summary>
        /// for demo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemoGrabone_Click(object sender, EventArgs e)
        {
            IWebDriver driverOmins = new ChromeDriver(txtChromeDriver.Text);
            driverOmins.Url = "http://127.0.0.1:5500/omins.html";
            string ominsHandle = driverOmins.CurrentWindowHandle;
            IWebElement addbutton = driverOmins.FindElement(By.XPath("/html/body/div[1]/input[3]"));
            Thread.Sleep(3000);

            //准备selenium web driver
            IWebDriver drivergrabone = new ChromeDriver(txtChromeDriver.Text);
            drivergrabone.Url = "http://127.0.0.1:5500/grabone.html";
            string graboneHandle = drivergrabone.CurrentWindowHandle;
            Thread.Sleep(3000);
            driverOmins.SwitchTo().Window(ominsHandle);
            addbutton.Click();
            Thread.Sleep(3000);

            //准备selenium web driver
            IWebDriver driveronceit = new ChromeDriver(txtChromeDriver.Text);
            driveronceit.Url = "http://127.0.0.1:5500/onceit.html";
            string onceitHandle = driveronceit.CurrentWindowHandle;
            //IWebElement trackingnumber = driveronceit.FindElement(By.XPath("/html/body/div[3]/div/div[2]/table/tbody/tr/td[10]/input"));
            Thread.Sleep(3000);
            driverOmins.SwitchTo().Window(ominsHandle);
            addbutton.Click();

            //为demo调用实际逻辑
            btnAddrValidAndGenerateInfo.PerformClick();
        }
    }
}
