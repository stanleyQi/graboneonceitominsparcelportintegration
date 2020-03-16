namespace tools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lstgrabonemergedorders = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblgrabonestatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblgrabonemergefilename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblonceitmergefilename = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOmisUrl = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChromeDriver = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRewirteTrackingInfo = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAddrValidAndGenerateInfo = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lblParcelPortStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtParcelPortPassword = new System.Windows.Forms.TextBox();
            this.txtParcelPortUsername = new System.Windows.Forms.TextBox();
            this.txtParcelPortUrl = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblParcelPortFileName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDemoGrabone = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "file(.csv)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "file name selected:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "执行合单";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstgrabonemergedorders
            // 
            this.lstgrabonemergedorders.FormattingEnabled = true;
            this.lstgrabonemergedorders.ItemHeight = 20;
            this.lstgrabonemergedorders.Location = new System.Drawing.Point(33, 199);
            this.lstgrabonemergedorders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstgrabonemergedorders.Name = "lstgrabonemergedorders";
            this.lstgrabonemergedorders.Size = new System.Drawing.Size(338, 264);
            this.lstgrabonemergedorders.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "file(.csv)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "file name selected:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 134);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 89);
            this.button4.TabIndex = 6;
            this.button4.Text = "执行合单(不要进行其他操作，直到等待完成)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(19, 232);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(273, 264);
            this.listBox2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblgrabonestatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblgrabonemergefilename);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lstgrabonemergedorders);
            this.panel1.Location = new System.Drawing.Point(611, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 641);
            this.panel1.TabIndex = 8;
            // 
            // lblgrabonestatus
            // 
            this.lblgrabonestatus.AutoSize = true;
            this.lblgrabonestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblgrabonestatus.Location = new System.Drawing.Point(73, 579);
            this.lblgrabonestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgrabonestatus.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblgrabonestatus.Name = "lblgrabonestatus";
            this.lblgrabonestatus.Size = new System.Drawing.Size(138, 29);
            this.lblgrabonestatus.TabIndex = 7;
            this.lblgrabonestatus.Text = "未选择文件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(207, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 94);
            this.label5.TabIndex = 6;
            this.label5.Text = "GrabOne\r\n->Omins";
            // 
            // lblgrabonemergefilename
            // 
            this.lblgrabonemergefilename.AutoSize = true;
            this.lblgrabonemergefilename.Location = new System.Drawing.Point(28, 105);
            this.lblgrabonemergefilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgrabonemergefilename.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblgrabonemergefilename.Name = "lblgrabonemergefilename";
            this.lblgrabonemergefilename.Size = new System.Drawing.Size(33, 20);
            this.lblgrabonemergefilename.TabIndex = 5;
            this.lblgrabonemergefilename.Text = "......";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 579);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "状态:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblonceitmergefilename);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(1020, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 641);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label6.Location = new System.Drawing.Point(190, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 94);
            this.label6.TabIndex = 6;
            this.label6.Text = "OnCeit\r\n->Omins";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblonceitmergefilename
            // 
            this.lblonceitmergefilename.AutoSize = true;
            this.lblonceitmergefilename.Location = new System.Drawing.Point(22, 102);
            this.lblonceitmergefilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblonceitmergefilename.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblonceitmergefilename.Name = "lblonceitmergefilename";
            this.lblonceitmergefilename.Size = new System.Drawing.Size(33, 20);
            this.lblonceitmergefilename.TabIndex = 9;
            this.lblonceitmergefilename.Text = "......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 602);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "status";
            // 
            // txtOmisUrl
            // 
            this.txtOmisUrl.Location = new System.Drawing.Point(230, 19);
            this.txtOmisUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOmisUrl.Name = "txtOmisUrl";
            this.txtOmisUrl.Size = new System.Drawing.Size(319, 26);
            this.txtOmisUrl.TabIndex = 10;
            this.txtOmisUrl.Text = "https://omins.snipesoft.net.nz/ominst/login.php";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(51, 71);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(136, 26);
            this.txtCompany.TabIndex = 11;
            this.txtCompany.Text = "XXX";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(222, 71);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(136, 26);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.Text = "XXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(4, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 47);
            this.label7.TabIndex = 13;
            this.label7.Text = "Omins信息";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(413, 71);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 26);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "XXX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(559, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------";
            // 
            // txtChromeDriver
            // 
            this.txtChromeDriver.Location = new System.Drawing.Point(18, 5);
            this.txtChromeDriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChromeDriver.Name = "txtChromeDriver";
            this.txtChromeDriver.Size = new System.Drawing.Size(571, 26);
            this.txtChromeDriver.TabIndex = 15;
            this.txtChromeDriver.Text = "E:\\Study\\gmart\\tools\\tools\\tools\\bin\\Debug";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.btnRewirteTrackingInfo);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.btnAddrValidAndGenerateInfo);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.lblParcelPortStatus);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtParcelPortPassword);
            this.panel3.Controls.Add(this.txtParcelPortUsername);
            this.panel3.Controls.Add(this.txtParcelPortUrl);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.lblParcelPortFileName);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(18, 251);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 609);
            this.panel3.TabIndex = 17;
            // 
            // btnRewirteTrackingInfo
            // 
            this.btnRewirteTrackingInfo.Location = new System.Drawing.Point(18, 468);
            this.btnRewirteTrackingInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRewirteTrackingInfo.Name = "btnRewirteTrackingInfo";
            this.btnRewirteTrackingInfo.Size = new System.Drawing.Size(251, 42);
            this.btnRewirteTrackingInfo.TabIndex = 19;
            this.btnRewirteTrackingInfo.Text = "Wirte back Tracking Number";
            this.btnRewirteTrackingInfo.UseVisualStyleBackColor = true;
            this.btnRewirteTrackingInfo.Click += new System.EventHandler(this.btnRewirteTrackingInfo_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(454, 271);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 42);
            this.button8.TabIndex = 18;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
            this.label13.Location = new System.Drawing.Point(202, 172);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.MaximumSize = new System.Drawing.Size(600, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "......";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 139);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(286, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "生成的用于parcelport的文件(需要确认):";
            this.label14.Click += new System.EventHandler(this.label14_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 405);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 26);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "E:\\Study\\gmart\\";
            // 
            // btnAddrValidAndGenerateInfo
            // 
            this.btnAddrValidAndGenerateInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddrValidAndGenerateInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddrValidAndGenerateInfo.Location = new System.Drawing.Point(16, 121);
            this.btnAddrValidAndGenerateInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddrValidAndGenerateInfo.Name = "btnAddrValidAndGenerateInfo";
            this.btnAddrValidAndGenerateInfo.Size = new System.Drawing.Size(180, 110);
            this.btnAddrValidAndGenerateInfo.TabIndex = 14;
            this.btnAddrValidAndGenerateInfo.Text = "Delivery Address Validation\r\n->item size getting\r\n->create consignment\r\n->printe " +
    "labels";
            this.btnAddrValidAndGenerateInfo.UseVisualStyleBackColor = false;
            this.btnAddrValidAndGenerateInfo.Click += new System.EventHandler(this.btnAddrValidAndGenerateInfo_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 396);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 45);
            this.button7.TabIndex = 13;
            this.button7.Text = "打印Lable(api)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblParcelPortStatus
            // 
            this.lblParcelPortStatus.AutoSize = true;
            this.lblParcelPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblParcelPortStatus.Location = new System.Drawing.Point(58, 474);
            this.lblParcelPortStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParcelPortStatus.Name = "lblParcelPortStatus";
            this.lblParcelPortStatus.Size = new System.Drawing.Size(138, 29);
            this.lblParcelPortStatus.TabIndex = 12;
            this.lblParcelPortStatus.Text = "未选择文件";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 481);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "状态:";
            // 
            // txtParcelPortPassword
            // 
            this.txtParcelPortPassword.Location = new System.Drawing.Point(345, 334);
            this.txtParcelPortPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParcelPortPassword.Name = "txtParcelPortPassword";
            this.txtParcelPortPassword.Size = new System.Drawing.Size(108, 26);
            this.txtParcelPortPassword.TabIndex = 10;
            this.txtParcelPortPassword.Text = "1234abcd";
            // 
            // txtParcelPortUsername
            // 
            this.txtParcelPortUsername.Location = new System.Drawing.Point(217, 334);
            this.txtParcelPortUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParcelPortUsername.Name = "txtParcelPortUsername";
            this.txtParcelPortUsername.Size = new System.Drawing.Size(119, 26);
            this.txtParcelPortUsername.TabIndex = 10;
            this.txtParcelPortUsername.Text = "ParcelportTest";
            // 
            // txtParcelPortUrl
            // 
            this.txtParcelPortUrl.Location = new System.Drawing.Point(217, 296);
            this.txtParcelPortUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParcelPortUrl.Name = "txtParcelPortUrl";
            this.txtParcelPortUrl.Size = new System.Drawing.Size(236, 26);
            this.txtParcelPortUrl.TabIndex = 9;
            this.txtParcelPortUrl.Text = "https://apitest.parcelport.co.nz/";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 296);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 41);
            this.button5.TabIndex = 8;
            this.button5.Text = "生成寄售(api)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblParcelPortFileName
            // 
            this.lblParcelPortFileName.AutoSize = true;
            this.lblParcelPortFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
            this.lblParcelPortFileName.Location = new System.Drawing.Point(202, 96);
            this.lblParcelPortFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParcelPortFileName.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblParcelPortFileName.Name = "lblParcelPortFileName";
            this.lblParcelPortFileName.Size = new System.Drawing.Size(25, 15);
            this.lblParcelPortFileName.TabIndex = 7;
            this.lblParcelPortFileName.Text = "......";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "预计生成寄售的文件:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 61);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 56);
            this.button6.TabIndex = 1;
            this.button6.Text = "select omins orders(.csv integrated)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label9.Location = new System.Drawing.Point(0, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(439, 47);
            this.label9.TabIndex = 0;
            this.label9.Text = "Parcel Port automation";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtOmisUrl);
            this.panel4.Controls.Add(this.txtCompany);
            this.panel4.Controls.Add(this.txtUsername);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Location = new System.Drawing.Point(18, 45);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 168);
            this.panel4.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(660, 699);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(363, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "在omins上选择预打印的order，并存储在如下位置：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 745);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(745, 26);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "E:\\Study\\gmart\\New folder\\trademe-csv_export (202002211034).csv";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnDemoGrabone
            // 
            this.btnDemoGrabone.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDemoGrabone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDemoGrabone.Location = new System.Drawing.Point(610, 788);
            this.btnDemoGrabone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDemoGrabone.Name = "btnDemoGrabone";
            this.btnDemoGrabone.Size = new System.Drawing.Size(781, 72);
            this.btnDemoGrabone.TabIndex = 8;
            this.btnDemoGrabone.Text = "Demo GrabOne/Onceit\r\n->Omins Order integeration";
            this.btnDemoGrabone.UseVisualStyleBackColor = false;
            this.btnDemoGrabone.Click += new System.EventHandler(this.btnDemoGrabone_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(12, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(592, 208);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label16);
            this.panel6.Location = new System.Drawing.Point(13, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(371, 511);
            this.panel6.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label17);
            this.panel7.Location = new System.Drawing.Point(19, 111);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(330, 511);
            this.panel7.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label19);
            this.panel8.Location = new System.Drawing.Point(610, 670);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(780, 101);
            this.panel8.TabIndex = 24;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label18);
            this.panel9.Location = new System.Drawing.Point(12, 249);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(548, 332);
            this.panel9.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label15.Location = new System.Drawing.Point(141, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(289, 32);
            this.label15.TabIndex = 0;
            this.label15.Text = "Do not show for demo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label16.Location = new System.Drawing.Point(34, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(289, 32);
            this.label16.TabIndex = 1;
            this.label16.Text = "Do not show for demo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label17.Location = new System.Drawing.Point(21, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(289, 32);
            this.label17.TabIndex = 2;
            this.label17.Text = "Do not show for demo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label18.Location = new System.Drawing.Point(127, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(289, 32);
            this.label18.TabIndex = 3;
            this.label18.Text = "Do not show for demo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label19.Location = new System.Drawing.Point(245, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(289, 32);
            this.label19.TabIndex = 4;
            this.label19.Text = "Do not show for demo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 879);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnDemoGrabone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtChromeDriver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstgrabonemergedorders;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblgrabonemergefilename;
        private System.Windows.Forms.Label lblonceitmergefilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblgrabonestatus;
        private System.Windows.Forms.TextBox txtOmisUrl;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChromeDriver;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtParcelPortPassword;
        private System.Windows.Forms.TextBox txtParcelPortUsername;
        private System.Windows.Forms.TextBox txtParcelPortUrl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblParcelPortFileName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblParcelPortStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAddrValidAndGenerateInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnRewirteTrackingInfo;
        private System.Windows.Forms.Button btnDemoGrabone;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
    }
}

