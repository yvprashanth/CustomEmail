namespace MailApp
{
    partial class frmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMail));
            this.btnSendReset = new System.Windows.Forms.TabControl();
            this.tabSending = new System.Windows.Forms.TabPage();
            this.ckbRandomTime = new System.Windows.Forms.CheckBox();
            this.ckbRandomFrom = new System.Windows.Forms.CheckBox();
            this.ckbRandomHeader = new System.Windows.Forms.CheckBox();
            this.ckbRandomBody = new System.Windows.Forms.CheckBox();
            this.ckbRandomSubject = new System.Windows.Forms.CheckBox();
            this.ckbHTML = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.ckbRandom = new System.Windows.Forms.CheckBox();
            this.lblReadReceipt = new System.Windows.Forms.Label();
            this.ckbReadReceipt = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpam = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmailCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ckbAuth = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAttachment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAHMessage3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAHType3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAHMessage2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAHType2 = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtAHMessage1 = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtAHType1 = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBCC = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtCombo = new System.Windows.Forms.ComboBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.tabReceiving = new System.Windows.Forms.TabPage();
            this.txtReceiveLog = new System.Windows.Forms.TextBox();
            this.btnReceiveDefaults = new System.Windows.Forms.Button();
            this.btnReceiveReset1 = new System.Windows.Forms.Button();
            this.btnSendReceive = new System.Windows.Forms.Button();
            this.cmbReceiveServer = new System.Windows.Forms.ComboBox();
            this.txtReceivePort = new System.Windows.Forms.TextBox();
            this.txtReceivePassword = new System.Windows.Forms.TextBox();
            this.txtReceiveUserName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stripMain = new System.Windows.Forms.StatusStrip();
            this.tsslWorking = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.btnSendReset.SuspendLayout();
            this.tabSending.SuspendLayout();
            this.tabReceiving.SuspendLayout();
            this.stripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendReset
            // 
            this.btnSendReset.Controls.Add(this.tabSending);
            this.btnSendReset.Controls.Add(this.tabReceiving);
            this.btnSendReset.Location = new System.Drawing.Point(0, 0);
            this.btnSendReset.Name = "btnSendReset";
            this.btnSendReset.SelectedIndex = 0;
            this.btnSendReset.Size = new System.Drawing.Size(800, 618);
            this.btnSendReset.TabIndex = 0;
            // 
            // tabSending
            // 
            this.tabSending.Controls.Add(this.ckbRandomTime);
            this.tabSending.Controls.Add(this.ckbRandomFrom);
            this.tabSending.Controls.Add(this.ckbRandomHeader);
            this.tabSending.Controls.Add(this.ckbRandomBody);
            this.tabSending.Controls.Add(this.ckbRandomSubject);
            this.tabSending.Controls.Add(this.ckbHTML);
            this.tabSending.Controls.Add(this.label19);
            this.tabSending.Controls.Add(this.cmbPriority);
            this.tabSending.Controls.Add(this.ckbRandom);
            this.tabSending.Controls.Add(this.lblReadReceipt);
            this.tabSending.Controls.Add(this.ckbReadReceipt);
            this.tabSending.Controls.Add(this.label1);
            this.tabSending.Controls.Add(this.btnSpam);
            this.tabSending.Controls.Add(this.label16);
            this.tabSending.Controls.Add(this.btnData);
            this.tabSending.Controls.Add(this.label15);
            this.tabSending.Controls.Add(this.btnReset);
            this.tabSending.Controls.Add(this.label14);
            this.tabSending.Controls.Add(this.btnSend);
            this.tabSending.Controls.Add(this.label13);
            this.tabSending.Controls.Add(this.txtEmailCount);
            this.tabSending.Controls.Add(this.label12);
            this.tabSending.Controls.Add(this.txtPassword);
            this.tabSending.Controls.Add(this.label11);
            this.tabSending.Controls.Add(this.ckbAuth);
            this.tabSending.Controls.Add(this.label10);
            this.tabSending.Controls.Add(this.txtAttachment);
            this.tabSending.Controls.Add(this.label9);
            this.tabSending.Controls.Add(this.txtUsername);
            this.tabSending.Controls.Add(this.label8);
            this.tabSending.Controls.Add(this.txtBody);
            this.tabSending.Controls.Add(this.label7);
            this.tabSending.Controls.Add(this.txtAHMessage3);
            this.tabSending.Controls.Add(this.label6);
            this.tabSending.Controls.Add(this.txtAHType3);
            this.tabSending.Controls.Add(this.label5);
            this.tabSending.Controls.Add(this.txtAHMessage2);
            this.tabSending.Controls.Add(this.label4);
            this.tabSending.Controls.Add(this.txtAHType2);
            this.tabSending.Controls.Add(this.lblPort);
            this.tabSending.Controls.Add(this.txtAHMessage1);
            this.tabSending.Controls.Add(this.lblSelect);
            this.tabSending.Controls.Add(this.txtAHType1);
            this.tabSending.Controls.Add(this.lblServer);
            this.tabSending.Controls.Add(this.txtSubject);
            this.tabSending.Controls.Add(this.txtBCC);
            this.tabSending.Controls.Add(this.txtCC);
            this.tabSending.Controls.Add(this.txtTo);
            this.tabSending.Controls.Add(this.txtFrom);
            this.tabSending.Controls.Add(this.txtPort);
            this.tabSending.Controls.Add(this.txtCombo);
            this.tabSending.Controls.Add(this.txtServer);
            this.tabSending.Location = new System.Drawing.Point(4, 22);
            this.tabSending.Name = "tabSending";
            this.tabSending.Padding = new System.Windows.Forms.Padding(3);
            this.tabSending.Size = new System.Drawing.Size(792, 592);
            this.tabSending.TabIndex = 0;
            this.tabSending.Text = "Sending";
            this.tabSending.UseVisualStyleBackColor = true;
            // 
            // ckbRandomTime
            // 
            this.ckbRandomTime.AutoSize = true;
            this.ckbRandomTime.Location = new System.Drawing.Point(230, 534);
            this.ckbRandomTime.Name = "ckbRandomTime";
            this.ckbRandomTime.Size = new System.Drawing.Size(146, 17);
            this.ckbRandomTime.TabIndex = 78;
            this.ckbRandomTime.Text = "Random Wait (0-30 secs)";
            this.ckbRandomTime.UseVisualStyleBackColor = true;
            // 
            // ckbRandomFrom
            // 
            this.ckbRandomFrom.AutoSize = true;
            this.ckbRandomFrom.Location = new System.Drawing.Point(379, 92);
            this.ckbRandomFrom.Name = "ckbRandomFrom";
            this.ckbRandomFrom.Size = new System.Drawing.Size(66, 17);
            this.ckbRandomFrom.TabIndex = 77;
            this.ckbRandomFrom.Text = "Random";
            this.ckbRandomFrom.UseVisualStyleBackColor = true;
            this.ckbRandomFrom.CheckedChanged += new System.EventHandler(this.ckbRandomFrom_CheckedChanged);
            // 
            // ckbRandomHeader
            // 
            this.ckbRandomHeader.AutoSize = true;
            this.ckbRandomHeader.Location = new System.Drawing.Point(484, 272);
            this.ckbRandomHeader.Name = "ckbRandomHeader";
            this.ckbRandomHeader.Size = new System.Drawing.Size(66, 17);
            this.ckbRandomHeader.TabIndex = 76;
            this.ckbRandomHeader.Text = "Random";
            this.ckbRandomHeader.UseVisualStyleBackColor = true;
            this.ckbRandomHeader.CheckedChanged += new System.EventHandler(this.ckbRandomHeader_CheckedChanged);
            // 
            // ckbRandomBody
            // 
            this.ckbRandomBody.AutoSize = true;
            this.ckbRandomBody.Location = new System.Drawing.Point(695, 345);
            this.ckbRandomBody.Name = "ckbRandomBody";
            this.ckbRandomBody.Size = new System.Drawing.Size(66, 17);
            this.ckbRandomBody.TabIndex = 75;
            this.ckbRandomBody.Text = "Random";
            this.ckbRandomBody.UseVisualStyleBackColor = true;
            this.ckbRandomBody.CheckedChanged += new System.EventHandler(this.ckbRandomBody_CheckedChanged);
            // 
            // ckbRandomSubject
            // 
            this.ckbRandomSubject.AutoSize = true;
            this.ckbRandomSubject.Location = new System.Drawing.Point(378, 196);
            this.ckbRandomSubject.Name = "ckbRandomSubject";
            this.ckbRandomSubject.Size = new System.Drawing.Size(66, 17);
            this.ckbRandomSubject.TabIndex = 74;
            this.ckbRandomSubject.Text = "Random";
            this.ckbRandomSubject.UseVisualStyleBackColor = true;
            this.ckbRandomSubject.CheckedChanged += new System.EventHandler(this.ckbRandomSubject_CheckedChanged);
            // 
            // ckbHTML
            // 
            this.ckbHTML.AutoSize = true;
            this.ckbHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHTML.Location = new System.Drawing.Point(695, 368);
            this.ckbHTML.Name = "ckbHTML";
            this.ckbHTML.Size = new System.Drawing.Size(98, 17);
            this.ckbHTML.TabIndex = 70;
            this.ckbHTML.Text = "HTML Enabled";
            this.ckbHTML.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(92, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 69;
            this.label19.Text = "Priority:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(172, 219);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbPriority.TabIndex = 68;
            // 
            // ckbRandom
            // 
            this.ckbRandom.AutoSize = true;
            this.ckbRandom.Location = new System.Drawing.Point(300, 417);
            this.ckbRandom.Name = "ckbRandom";
            this.ckbRandom.Size = new System.Drawing.Size(66, 17);
            this.ckbRandom.TabIndex = 61;
            this.ckbRandom.Text = "Random";
            this.ckbRandom.UseVisualStyleBackColor = true;
            this.ckbRandom.CheckedChanged += new System.EventHandler(this.ckbRandom_CheckedChanged);
            // 
            // lblReadReceipt
            // 
            this.lblReadReceipt.AutoSize = true;
            this.lblReadReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadReceipt.Location = new System.Drawing.Point(46, 438);
            this.lblReadReceipt.Name = "lblReadReceipt";
            this.lblReadReceipt.Size = new System.Drawing.Size(108, 16);
            this.lblReadReceipt.TabIndex = 61;
            this.lblReadReceipt.Text = "Read Receipt:";
            this.lblReadReceipt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ckbReadReceipt
            // 
            this.ckbReadReceipt.AutoSize = true;
            this.ckbReadReceipt.Location = new System.Drawing.Point(174, 440);
            this.ckbReadReceipt.Name = "ckbReadReceipt";
            this.ckbReadReceipt.Size = new System.Drawing.Size(15, 14);
            this.ckbReadReceipt.TabIndex = 62;
            this.ckbReadReceipt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Number of Emails:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSpam
            // 
            this.btnSpam.Location = new System.Drawing.Point(605, 560);
            this.btnSpam.Name = "btnSpam";
            this.btnSpam.Size = new System.Drawing.Size(85, 23);
            this.btnSpam.TabIndex = 67;
            this.btnSpam.Text = "Email SPAM";
            this.btnSpam.UseVisualStyleBackColor = true;
            this.btnSpam.Click += new System.EventHandler(this.btnSpam_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(74, 510);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 56;
            this.label16.Text = "Password:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnData
            // 
            this.btnData.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnData.Location = new System.Drawing.Point(605, 531);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(85, 23);
            this.btnData.TabIndex = 66;
            this.btnData.Text = "Email Defaults";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(71, 484);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 55;
            this.label15.Text = "Username:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(360, 560);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 458);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 16);
            this.label14.TabIndex = 54;
            this.label14.Text = "Use authentication:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(279, 560);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 35;
            this.btnSend.Text = "&Send Email";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "Attachment size:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEmailCount
            // 
            this.txtEmailCount.Location = new System.Drawing.Point(174, 532);
            this.txtEmailCount.Name = "txtEmailCount";
            this.txtEmailCount.Size = new System.Drawing.Size(50, 20);
            this.txtEmailCount.TabIndex = 34;
            this.txtEmailCount.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(105, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Body:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 506);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 65;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(129, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "=>";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ckbAuth
            // 
            this.ckbAuth.AutoSize = true;
            this.ckbAuth.Location = new System.Drawing.Point(173, 460);
            this.ckbAuth.Name = "ckbAuth";
            this.ckbAuth.Size = new System.Drawing.Size(15, 14);
            this.ckbAuth.TabIndex = 63;
            this.ckbAuth.UseVisualStyleBackColor = true;
            this.ckbAuth.CheckedChanged += new System.EventHandler(this.ckbAuth_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(129, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "=>";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAttachment
            // 
            this.txtAttachment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAttachment.FormattingEnabled = true;
            this.txtAttachment.Items.AddRange(new object[] {
            "  1 MB",
            "  5 MB",
            "10 MB",
            "15 MB",
            "20 MB"});
            this.txtAttachment.Location = new System.Drawing.Point(173, 413);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(121, 21);
            this.txtAttachment.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Additional headers:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(173, 480);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Subject:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(172, 324);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(517, 83);
            this.txtBody.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "BCC:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAHMessage3
            // 
            this.txtAHMessage3.Location = new System.Drawing.Point(278, 298);
            this.txtAHMessage3.Name = "txtAHMessage3";
            this.txtAHMessage3.Size = new System.Drawing.Size(200, 20);
            this.txtAHMessage3.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "CC:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAHType3
            // 
            this.txtAHType3.Location = new System.Drawing.Point(173, 298);
            this.txtAHType3.Name = "txtAHType3";
            this.txtAHType3.Size = new System.Drawing.Size(100, 20);
            this.txtAHType3.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "To:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAHMessage2
            // 
            this.txtAHMessage2.Location = new System.Drawing.Point(278, 272);
            this.txtAHMessage2.Name = "txtAHMessage2";
            this.txtAHMessage2.Size = new System.Drawing.Size(200, 20);
            this.txtAHMessage2.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "From:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAHType2
            // 
            this.txtAHType2.Location = new System.Drawing.Point(172, 272);
            this.txtAHType2.Name = "txtAHType2";
            this.txtAHType2.Size = new System.Drawing.Size(100, 20);
            this.txtAHType2.TabIndex = 48;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(113, 63);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(40, 16);
            this.lblPort.TabIndex = 30;
            this.lblPort.Text = "Port:";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAHMessage1
            // 
            this.txtAHMessage1.Location = new System.Drawing.Point(278, 246);
            this.txtAHMessage1.Name = "txtAHMessage1";
            this.txtAHMessage1.Size = new System.Drawing.Size(200, 20);
            this.txtAHMessage1.TabIndex = 46;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(47, 36);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(106, 16);
            this.lblSelect.TabIndex = 27;
            this.lblSelect.Text = "Select Server:";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAHType1
            // 
            this.txtAHType1.Location = new System.Drawing.Point(172, 246);
            this.txtAHType1.Name = "txtAHType1";
            this.txtAHType1.Size = new System.Drawing.Size(100, 20);
            this.txtAHType1.TabIndex = 45;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(55, 8);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(98, 16);
            this.lblServer.TabIndex = 26;
            this.lblServer.Text = "Enter Server:";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(172, 193);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(200, 20);
            this.txtSubject.TabIndex = 32;
            // 
            // txtBCC
            // 
            this.txtBCC.Location = new System.Drawing.Point(172, 167);
            this.txtBCC.Name = "txtBCC";
            this.txtBCC.Size = new System.Drawing.Size(200, 20);
            this.txtBCC.TabIndex = 31;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(172, 141);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(200, 20);
            this.txtCC.TabIndex = 30;
            // 
            // txtTo
            // 
            this.txtTo.AutoCompleteCustomSource.AddRange(new string[] {
            "eusales@maevatravel.info",
            "inquire@maevatravel.info",
            "admin@maevatravel.net",
            "info@maevatravel.net",
            "info@maevatravel.us",
            "admin@maevatravel.us",
            "sales@maevatravel.us",
            "mcopple@godaddy.com"});
            this.txtTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTo.Location = new System.Drawing.Point(172, 115);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(200, 20);
            this.txtTo.TabIndex = 29;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(173, 89);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(200, 20);
            this.txtFrom.TabIndex = 28;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(173, 62);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 20);
            this.txtPort.TabIndex = 27;
            this.txtPort.Text = "25";
            // 
            // txtCombo
            // 
            this.txtCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCombo.DropDownWidth = 209;
            this.txtCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo.FormattingEnabled = true;
            this.txtCombo.Items.AddRange(new object[] {
            "p3plex1pre01.prod.phx3.secureserver.net",
            "p3plex1pre02.prod.phx3.secureserver.net",
            "p3plex1pre03.prod.phx3.secureserver.net",
            "p3plex1pre04.prod.phx3.secureserver.net",
            "relay-app.secureserver.net",
            "smtp.secureserver.net",
            "smtpout.secureserver.net"});
            this.txtCombo.Location = new System.Drawing.Point(173, 34);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(199, 21);
            this.txtCombo.TabIndex = 26;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(173, 7);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(200, 20);
            this.txtServer.TabIndex = 25;
            // 
            // tabReceiving
            // 
            this.tabReceiving.Controls.Add(this.txtReceiveLog);
            this.tabReceiving.Controls.Add(this.btnReceiveDefaults);
            this.tabReceiving.Controls.Add(this.btnReceiveReset1);
            this.tabReceiving.Controls.Add(this.btnSendReceive);
            this.tabReceiving.Controls.Add(this.cmbReceiveServer);
            this.tabReceiving.Controls.Add(this.txtReceivePort);
            this.tabReceiving.Controls.Add(this.txtReceivePassword);
            this.tabReceiving.Controls.Add(this.txtReceiveUserName);
            this.tabReceiving.Controls.Add(this.label18);
            this.tabReceiving.Controls.Add(this.label17);
            this.tabReceiving.Controls.Add(this.label3);
            this.tabReceiving.Controls.Add(this.label2);
            this.tabReceiving.Location = new System.Drawing.Point(4, 22);
            this.tabReceiving.Name = "tabReceiving";
            this.tabReceiving.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceiving.Size = new System.Drawing.Size(792, 592);
            this.tabReceiving.TabIndex = 1;
            this.tabReceiving.Text = "Receiving";
            this.tabReceiving.UseVisualStyleBackColor = true;
            // 
            // txtReceiveLog
            // 
            this.txtReceiveLog.Location = new System.Drawing.Point(73, 214);
            this.txtReceiveLog.Multiline = true;
            this.txtReceiveLog.Name = "txtReceiveLog";
            this.txtReceiveLog.Size = new System.Drawing.Size(562, 288);
            this.txtReceiveLog.TabIndex = 11;
            // 
            // btnReceiveDefaults
            // 
            this.btnReceiveDefaults.Location = new System.Drawing.Point(383, 150);
            this.btnReceiveDefaults.Name = "btnReceiveDefaults";
            this.btnReceiveDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnReceiveDefaults.TabIndex = 10;
            this.btnReceiveDefaults.Text = "&Defaults";
            this.btnReceiveDefaults.UseVisualStyleBackColor = true;
            this.btnReceiveDefaults.Click += new System.EventHandler(this.btnReceiveDefaults_Click);
            // 
            // btnReceiveReset1
            // 
            this.btnReceiveReset1.Location = new System.Drawing.Point(184, 151);
            this.btnReceiveReset1.Name = "btnReceiveReset1";
            this.btnReceiveReset1.Size = new System.Drawing.Size(75, 23);
            this.btnReceiveReset1.TabIndex = 0;
            this.btnReceiveReset1.Text = "&Reset";
            this.btnReceiveReset1.Click += new System.EventHandler(this.btnReceiveReset_Click);
            // 
            // btnSendReceive
            // 
            this.btnSendReceive.Enabled = false;
            this.btnSendReceive.Location = new System.Drawing.Point(73, 151);
            this.btnSendReceive.Name = "btnSendReceive";
            this.btnSendReceive.Size = new System.Drawing.Size(75, 23);
            this.btnSendReceive.TabIndex = 9;
            this.btnSendReceive.Text = "&Receive";
            this.btnSendReceive.UseVisualStyleBackColor = true;
            this.btnSendReceive.Click += new System.EventHandler(this.btnSendReceive_Click);
            // 
            // cmbReceiveServer
            // 
            this.cmbReceiveServer.FormattingEnabled = true;
            this.cmbReceiveServer.Items.AddRange(new object[] {
            "pop.gmail.com"});
            this.cmbReceiveServer.Location = new System.Drawing.Point(73, 73);
            this.cmbReceiveServer.Name = "cmbReceiveServer";
            this.cmbReceiveServer.Size = new System.Drawing.Size(186, 21);
            this.cmbReceiveServer.TabIndex = 8;
            // 
            // txtReceivePort
            // 
            this.txtReceivePort.Location = new System.Drawing.Point(73, 101);
            this.txtReceivePort.Name = "txtReceivePort";
            this.txtReceivePort.Size = new System.Drawing.Size(52, 20);
            this.txtReceivePort.TabIndex = 7;
            this.txtReceivePort.Text = "995";
            // 
            // txtReceivePassword
            // 
            this.txtReceivePassword.Location = new System.Drawing.Point(73, 46);
            this.txtReceivePassword.Name = "txtReceivePassword";
            this.txtReceivePassword.Size = new System.Drawing.Size(100, 20);
            this.txtReceivePassword.TabIndex = 5;
            this.txtReceivePassword.UseSystemPasswordChar = true;
            // 
            // txtReceiveUserName
            // 
            this.txtReceiveUserName.Location = new System.Drawing.Point(73, 19);
            this.txtReceiveUserName.Name = "txtReceiveUserName";
            this.txtReceiveUserName.Size = new System.Drawing.Size(100, 20);
            this.txtReceiveUserName.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Port:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name:";
            // 
            // stripMain
            // 
            this.stripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslWorking,
            this.tsslProgress});
            this.stripMain.Location = new System.Drawing.Point(0, 617);
            this.stripMain.Name = "stripMain";
            this.stripMain.Size = new System.Drawing.Size(799, 22);
            this.stripMain.TabIndex = 1;
            this.stripMain.Text = "statusStrip1";
            // 
            // tsslWorking
            // 
            this.tsslWorking.Name = "tsslWorking";
            this.tsslWorking.Size = new System.Drawing.Size(118, 17);
            this.tsslWorking.Text = "toolStripStatusLabel1";
            this.tsslWorking.Visible = false;
            // 
            // tsslProgress
            // 
            this.tsslProgress.Name = "tsslProgress";
            this.tsslProgress.Size = new System.Drawing.Size(100, 16);
            this.tsslProgress.Visible = false;
            // 
            // frmMail
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(799, 639);
            this.Controls.Add(this.stripMain);
            this.Controls.Add(this.btnSendReset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Application";
            this.btnSendReset.ResumeLayout(false);
            this.tabSending.ResumeLayout(false);
            this.tabSending.PerformLayout();
            this.tabReceiving.ResumeLayout(false);
            this.tabReceiving.PerformLayout();
            this.stripMain.ResumeLayout(false);
            this.stripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl btnSendReset;
        private System.Windows.Forms.TabPage tabSending;
        private System.Windows.Forms.Label lblReadReceipt;
        private System.Windows.Forms.CheckBox ckbReadReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmailCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckbAuth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtAttachment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAHMessage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAHType3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAHMessage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAHType2;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtAHMessage1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtAHType1;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBCC;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ComboBox txtCombo;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TabPage tabReceiving;
        private System.Windows.Forms.Button btnReceiveReset1;
        private System.Windows.Forms.Button btnSendReceive;
        private System.Windows.Forms.ComboBox cmbReceiveServer;
        private System.Windows.Forms.TextBox txtReceivePort;
        private System.Windows.Forms.TextBox txtReceivePassword;
        private System.Windows.Forms.TextBox txtReceiveUserName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbRandom;
        private System.Windows.Forms.Button btnReceiveDefaults;
        private System.Windows.Forms.TextBox txtReceiveLog;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.CheckBox ckbHTML;
        private System.Windows.Forms.CheckBox ckbRandomSubject;
        private System.Windows.Forms.CheckBox ckbRandomBody;
        private System.Windows.Forms.CheckBox ckbRandomHeader;
        private System.Windows.Forms.CheckBox ckbRandomFrom;
        private System.Windows.Forms.CheckBox ckbRandomTime;
        private System.Windows.Forms.StatusStrip stripMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslWorking;
        private System.Windows.Forms.ToolStripProgressBar tsslProgress;


    }
}

