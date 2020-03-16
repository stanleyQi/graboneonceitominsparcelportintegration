using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using PdfiumViewer;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using tools.objects.parcelport;

namespace tools.helper
{
    public class TrackingNumberHelp
    {
        public static Dictionary<string,string> WriteBackTracking(SecurityInfoForApi userInfoForApi,List<ConsignmentRep> consignmentReps)
        {
            Dictionary<string, string> writeBackTracking = new Dictionary<string, string>();

            #region 读取PDF文本
            ////取得tracking number
            //Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            //doc.LoadFromFile(pdfPath);

            //StringBuilder buffer = new StringBuilder();
            //foreach (PdfPageBase page in doc.Pages)
            //{
            //    string content = page.ExtractText();
            //    File.WriteAllText(string.Format(@"C:\ParcelPortPrinterTemp\ParcelPortPrinterTemp{0}.txt", doc.Pages.IndexOf(page) + 1), content);
            //    writeBackTracking.Add(
            //            content.Substring(content.LastIndexOf("id#") + 3, 5), //e.g. sdfjid#25435#
            //            content.Substring(content.LastIndexOf("8541"), 24)
            //        );
            //}
            //doc.Close();
            //buffer = null;
            #endregion

            foreach (ConsignmentRep consignmentRep in consignmentReps)
            {
                using (HttpClient trackingNumberClient = new HttpClient())
                {
                    trackingNumberClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", userInfoForApi.access_token);

                    string trackingNumberUrl = string.Format("https://apitest.parcelport.co.nz/api/1.0/consignment?client_id={0}&consignmentRefs={1}", userInfoForApi.client_id, consignmentRep.consignmentRef[0]);
                    HttpResponseMessage result = trackingNumberClient.GetAsync(trackingNumberUrl).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        List<TrackingNumberRep> trackingNumberReps = new JavaScriptSerializer().Deserialize<List<TrackingNumberRep>>(result.Content.ReadAsStringAsync().Result);
                        writeBackTracking.Add(consignmentRep.id, trackingNumberReps[0].traking_ref);
                    }
                    else
                    {
                        string returnValue = result.Content.ReadAsStringAsync().Result;
                        throw new Exception($"Failed to POST data: ({result.StatusCode}): {returnValue}");
                    }
                }
            }


            ///////////////////////////////////////////TODO反写omins trackingnumber/////////////////////////////////////////
            //string chromeDriver = @"E:\Study\gmart\tools\tools\tools\bin\Debug";
            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("headless");

            //try
            //{
            //    using (var headless = new ChromeDriver(chromeOptions))
            //    //using (var headless = new ChromeDriver(chromeDriver))
            //    {
            //        headless.Url = "https://omins.snipesoft.net.nz/ominst/login.php";
            //        //Thread.Sleep(3000);
            //        var companyname = headless.FindElement(By.XPath("//*[@id='company_name']"));
            //        var username = headless.FindElement(By.XPath("//*[@id='username']"));
            //        var password = headless.FindElement(By.XPath("//*[@id='password']"));
            //        var loginButton = headless.FindElement(By.XPath("//*[@id='loginButton']"));
            //        companyname.SendKeys("wuyi");
            //        username.SendKeys("dean");
            //        password.SendKeys("dean");
            //        loginButton.Click();

            //        var invoiceLink = headless.FindElement(By.XPath("/html/body/div[1]/ul/li[5]/a"));
            //        invoiceLink.Click();


            //        ////*[@id="menuBar"]/li[5]/ul/li[1]/a
            //        var searchLink = headless.FindElement(By.XPath("/html/body/div[1]/ul/li[5]/ul/li[1]/a"));
            //        searchLink.Click();

            //        var statusLink = headless.FindElement(By.XPath("/html/body/div[2]/form/div[1]/div/div[1]/table/tbody/tr[2]/td/p[9]/div/div"));
            //        statusLink.Click();
            //        var readyCheck = headless.FindElement(By.XPath("/html/body/div[9]/div[1]/div[2]/label[7]/input"));
            //        readyCheck.Click();

            //        var searchButton = headless.FindElement(By.XPath("/html/body/div[2]/form/div[1]/div/div[1]/table/tbody/tr[1]/td[4]/p/input[1]"));
            //        searchButton.Click();

            //        var maxDisplay = headless.FindElement(By.XPath("/html/body/div[2]/form/div[6]/select[1]/option[4]"));
            //        maxDisplay.Click();

            //        //按照id选择订单->填写tracking number
            //        //var id = headless.FindElement(By.XPath("/html/body/div[2]/form/table/tbody/tr[2]/td[2]/a"));
            //        //id.Click();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            return writeBackTracking;
        }

        //public static Dictionary<string, string> GetInfoFromPdf(string pdfPath)
        //{
        //    Dictionary<string, string> infoFromPdf = new Dictionary<string, string>();



        //    return infoFromPdf;
        //}
    }
}
