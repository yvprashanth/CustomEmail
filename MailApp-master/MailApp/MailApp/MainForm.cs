using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;
using System.Numerics;

namespace MailApp
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
            txtServer.Select();
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            try
            {
                if (IsValidData())
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    int numemails = Convert.ToInt32(txtEmailCount.Text);

                    // Set up the Status Bar Elements
                    tsslProgress.Minimum = 0;
                    tsslProgress.Maximum = numemails;
                    tsslProgress.Step = 1;
                    tsslWorking.Text = String.Format("Sending {0} email(s)...", numemails);
                    tsslProgress.Visible = tsslWorking.Visible = true;

                    // Progress into the loop
                    for (int i = 0; i < numemails; i++)
                    {
                        string UniqueString = UniqueStringShort.GenerateShortID();
                        int UniqueString1 = UniqueStringShort1.GenerateShortID();
                        string UniqueRandomString = UniqueStringShort.GenerateRandomString();
                        string UniqueRandomSubject = UniqueStringShort.GenerateRandomSubject();
                        //int numwords = Convert.ToInt32(txtRandomWords.Text);
                        string RandomWords = UniqueStringShort.GenerateRandomWord();
                        string RandomHeader = UniqueStringShort.GenerateRandomHeader();
                        string RandomHeader1 = UniqueStringShort.GenerateRandomHeaderMessage();
                        string RandomFrom = UniqueStringShort.GenerateRandomFromAddress();
                        string RandomTTL = UniqueStringShort.GenerateRandomTTL();
                        string RandomFromAddress = RandomFrom + "@" + UniqueString + RandomTTL;
                        int RandomTimeDelay = Convert.ToInt16(UniqueStringShort.GenerateRandomTimeDelay());
                        //string RandomTimeDelay = UniqueStringShort.GenerateRandomTimeDelay();
                        string cc = txtCC.Text;
                        string bcc = txtBCC.Text;
                        string FromAddress = null;

                        #region From Address
                        if (ckbRandomFrom.Checked == true)
                        {
                            FromAddress = RandomFromAddress;
                        }
                        else
                        {
                            FromAddress = txtFrom.Text;
                        }
                        #endregion From Address

                        //MailMessage msg = new MailMessage(txtFrom.Text, txtTo.Text);
                        MailMessage msg = new MailMessage(FromAddress, txtTo.Text);

                        #region Message Subject, Body, HTML, & Message Priority
                        if (txtEmailCount.Text != "1" && ckbRandomSubject.Checked == true && ckbRandomBody.Checked == true)
                        {
                            msg.Subject = UniqueRandomSubject + " - " + UniqueRandomString;
                            msg.Body = RandomWords + " - " + UniqueString;
                            #region HTML
                            if (ckbHTML.Checked == true)
                            {
                                msg.IsBodyHtml = true;
                            }
                            else
                            {
                                //msg.IsBodyHtml = false;
                            }
                            #endregion HTML
                            #region Message Priority
                            if (cmbPriority.Text == "High")
                            {
                                msg.Priority = MailPriority.High;
                            }
                            else if (cmbPriority.Text == "Low")
                            {
                                msg.Priority = MailPriority.Low;
                            }
                            else
                            {
                                msg.Priority = MailPriority.Normal;
                            }
                            #endregion Message Priority
                        }
                        else if (txtEmailCount.Text != "1" && ckbRandomSubject.Checked == true && ckbRandomBody.Checked == false)
                        {
                            msg.Subject = UniqueRandomSubject + " - " + UniqueRandomString;
                            msg.Body = txtBody.Text + " - " + UniqueString;
                            #region HTML
                            if (ckbHTML.Checked == true)
                            {
                                msg.IsBodyHtml = true;
                            }
                            else
                            {
                                //msg.IsBodyHtml = false;
                            }
                            #endregion HTML
                            #region Message Priority
                            if (cmbPriority.Text == "High")
                            {
                                msg.Priority = MailPriority.High;
                            }
                            else if (cmbPriority.Text == "Low")
                            {
                                msg.Priority = MailPriority.Low;
                            }
                            else
                            {
                                msg.Priority = MailPriority.Normal;
                            }
                            #endregion Message Priority
                        }
                        else if (txtEmailCount.Text != "1" && ckbRandomBody.Checked == true)
                        {
                            msg.Subject = txtSubject.Text;
                            msg.Body = RandomWords + " - " + UniqueString;
                            #region HTML
                            if (ckbHTML.Checked == true)
                            {
                                msg.IsBodyHtml = true;
                            }
                            else
                            {
                                //msg.IsBodyHtml = false;
                            }
                            #endregion HTML
                            #region Message Priority
                            if (cmbPriority.Text == "High")
                            {
                                msg.Priority = MailPriority.High;
                            }
                            else if (cmbPriority.Text == "Low")
                            {
                                msg.Priority = MailPriority.Low;
                            }
                            else
                            {
                                msg.Priority = MailPriority.Normal;
                            }
                            #endregion Message Priority
                        }
                        else if (txtEmailCount.Text != "1")
                        {
                            msg.Subject = txtSubject.Text;
                            msg.Body = txtBody.Text + " - " + UniqueString;
                            #region HTML
                            if (ckbHTML.Checked == true)
                            {
                                msg.IsBodyHtml = true;
                            }
                            else
                            {
                                //msg.IsBodyHtml = false;
                            }
                            #endregion HTML
                            #region Message Priority
                            if (cmbPriority.Text == "High")
                            {
                                msg.Priority = MailPriority.High;
                            }
                            else if (cmbPriority.Text == "Low")
                            {
                                msg.Priority = MailPriority.Low;
                            }
                            else
                            {
                                msg.Priority = MailPriority.Normal;
                            }
                            #endregion Message Priority
                        }
                        else if (ckbRandomSubject.Checked == true && ckbRandomBody.Checked == false)
                        {
                            msg.Subject = UniqueRandomSubject + " - " + UniqueRandomString;
                            msg.Body = txtBody.Text;
                            #region HTML
                            if (ckbHTML.Checked == true)
                            {
                                msg.IsBodyHtml = true;
                            }
                            else
                            {
                                //msg.IsBodyHtml = false;
                            }
                            #endregion HTML
                            #region Message Priority
                            if (cmbPriority.Text == "High")
                            {
                                msg.Priority = MailPriority.High;
                            }
                            else if (cmbPriority.Text == "Low")
                            {
                                msg.Priority = MailPriority.Low;
                            }
                            else
                            {
                                msg.Priority = MailPriority.Normal;
                            }
                            #endregion Message Priority
                        }
                        else if (ckbRandomSubject.Checked == true && ckbRandomBody.Checked == true)
                        {
                            msg.Subject = UniqueRandomSubject + " - " + UniqueRandomString;
                            msg.Body = RandomWords + " - " + UniqueString;
                            #region HTML
                            if (ckbHTML.Checked == true)
                            {
                                msg.IsBodyHtml = true;
                            }
                            else
                            {
                                //msg.IsBodyHtml = false;
                            }
                            #endregion HTML
                            #region Message Priority
                            if (cmbPriority.Text == "High")
                            {
                                msg.Priority = MailPriority.High;
                            }
                            else if (cmbPriority.Text == "Low")
                            {
                                msg.Priority = MailPriority.Low;
                            }
                            else
                            {
                                msg.Priority = MailPriority.Normal;
                            }
                            #endregion Message Priority
                        }
                        else if (ckbRandomBody.Checked == true)
                        {
                            msg.Subject = txtSubject.Text;
                            msg.Body = RandomWords + " - " + UniqueString;
                            #region HTML
                            if (ckbHTML.Checked == true)
                            {
                                msg.IsBodyHtml = true;
                            }
                            else
                            {
                                //msg.IsBodyHtml = false;
                            }
                            #endregion HTML
                            #region Message Priority
                            if (cmbPriority.Text == "High")
                            {
                                msg.Priority = MailPriority.High;
                            }
                            else if (cmbPriority.Text == "Low")
                            {
                                msg.Priority = MailPriority.Low;
                            }
                            else
                            {
                                msg.Priority = MailPriority.Normal;
                            }
                            #endregion Message Priority
                        }
                        else
                        {
                            msg.Subject = txtSubject.Text;
                            msg.Body = txtBody.Text;
                            #region HTML
                            if (ckbHTML.Checked == true)
                            {
                                msg.IsBodyHtml = true;
                            }
                            else
                            {
                                //msg.IsBodyHtml = false;
                            }
                            #endregion HTML
                            #region Message Priority
                            if (cmbPriority.Text == "High")
                            {
                                msg.Priority = MailPriority.High;
                            }
                            else if (cmbPriority.Text == "Low")
                            {
                                msg.Priority = MailPriority.Low;
                            }
                            else
                            {
                                msg.Priority = MailPriority.Normal;
                            }
                            #endregion Message Priority
                        }
                        #endregion Message Subject, Body, HTML, & Message Priority

                        #region CC & BCC
                        //Add conditional CC & BCC
                        if (txtCC.Text != String.Empty)
                        {
                            msg.CC.Add(cc);
                        }
                        else if (txtBCC.Text != String.Empty)
                        {
                            msg.Bcc.Add(bcc);
                        }
                        #endregion CC & BCC

                        #region Additional Headers
                        //Add conditional Header Records
                        if (ckbRandomHeader.Checked == true)
                        {
                            msg.Headers.Add(RandomHeader, RandomHeader1);
                        }
                        if (txtAHType1.Text != String.Empty)
                        {
                            msg.Headers.Add(txtAHType1.Text, txtAHMessage1.Text);
                        }

                        if (txtAHType2.Text != String.Empty)
                        {
                            msg.Headers.Add(txtAHType2.Text, txtAHMessage1.Text);
                        }

                        if (txtAHType3.Text != String.Empty)
                        {
                            msg.Headers.Add(txtAHType3.Text, txtAHMessage1.Text);
                        }
                        if (ckbReadReceipt.Checked == true)
                        {
                            string ReadAddress = String.Format("<" + txtFrom.Text + ">");
                            msg.Headers.Add("Disposition-Notification-To", ReadAddress);
                        }
                        #endregion Additional Headers

                        #region Attachments
                        //Attachments
                        if (txtAttachment.Text != String.Empty) //uses the attachment text field
                        {
                            if (txtAttachment.Text == "  1 MB")
                            {
                                byte[] data = new byte[1048576];
                                MemoryStream stream = new MemoryStream(data);
                                Attachment attach = new Attachment(stream, "Attachment");
                                msg.Attachments.Add(attach);
                            }
                            else if (txtAttachment.Text == "  5 MB")
                            {
                                byte[] data = new byte[5242880];
                                MemoryStream stream = new MemoryStream(data);
                                Attachment attach = new Attachment(stream, "Attachment");
                                msg.Attachments.Add(attach);
                            }
                            else if (txtAttachment.Text == "10 MB")
                            {
                                byte[] data = new byte[10485760];
                                MemoryStream stream = new MemoryStream(data);
                                Attachment attach = new Attachment(stream, "Attachment");
                                msg.Attachments.Add(attach);
                            }
                            else if (txtAttachment.Text == "15 MB")
                            {
                                byte[] data = new byte[15728640];
                                MemoryStream stream = new MemoryStream(data);
                                Attachment attach = new Attachment(stream, "Attachment");
                                msg.Attachments.Add(attach);
                            }
                            else if (txtAttachment.Text == "20 MB")
                            {
                                byte[] data = new byte[20971520];
                                MemoryStream stream = new MemoryStream(data);
                                Attachment attach = new Attachment(stream, "Attachment");
                                msg.Attachments.Add(attach);
                            }
                        }

                        //if random check box is selected it picks a size less than 1 MB
                        if (ckbRandom.Checked == true && txtAttachment.Text == String.Empty)
                        {
                            byte[] data = new byte[UniqueString1];
                            MemoryStream stream = new MemoryStream(data);
                            Attachment attach = new Attachment(stream, "Attachment");
                            msg.Attachments.Add(attach);
                        }
                        #endregion Attachments

                        #region Server to send to
                        // Determines what to use for the server - Text field or Combo box
                        if (txtServer.Text != String.Empty && ckbAuth.Checked == true) //use the authentication & the server text field
                        {
                            SmtpClient client = new SmtpClient(txtServer.Text);
                            client.EnableSsl = false;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                            int port = 0;
                            bool result = Int32.TryParse(txtPort.Text, out port);
                            client.Port = (port);
                            client.Send(msg);
                        }
                        else if (txtCombo.Text != String.Empty && ckbAuth.Checked == true) //use the authentication & the server text field
                        {
                            SmtpClient client = new SmtpClient(txtCombo.Text);
                            client.EnableSsl = false;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                            int port = 0;
                            bool result = Int32.TryParse(txtPort.Text, out port);
                            client.Port = (port);
                            client.Send(msg);
                        }
                        else if (txtServer.Text != String.Empty) //uses the server text field
                        {
                            SmtpClient client = new SmtpClient(txtServer.Text);
                            client.EnableSsl = false;
                            int port = 0;
                            bool result = Int32.TryParse(txtPort.Text, out port);
                            client.Port = (port);
                            client.Send(msg);
                        }
                        else //uses the server combo box
                        {
                            SmtpClient client = new SmtpClient(txtCombo.Text);
                            client.EnableSsl = false;
                            int port = 0;
                            bool result = Int32.TryParse(txtPort.Text, out port);
                            client.Port = (port);
                            client.Send(msg);
                        }

                        if (ckbRandomTime.Checked == true)
                        {
                            Thread.Sleep(RandomTimeDelay);
                        }
                        #endregion Server to send to

                        // Advance the status progress
                        tsslProgress.PerformStep();

                        // Remember to process events to keep the application responsive
                        Application.DoEvents();

                    }
                    stopwatch.Stop();
                    MessageBox.Show(String.Format("Your message has been sent. Time elapsed: {0}s", stopwatch.Elapsed));
                    btnSend.Enabled = true;
                    txtServer.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace,
                    "Mail Exception Occured");
                btnSend.Enabled = true;
            }
            finally
            {
                tsslProgress.Visible = tsslWorking.Visible = false;
            }
        }

        #region Send Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtServer.Clear();
            txtCombo.Items.Clear();
            txtCombo.Items.Add("p3plex1pre01.prod.phx3.secureserver.net");
            txtCombo.Items.Add("p3plex1pre02.prod.phx3.secureserver.net");
            txtCombo.Items.Add("p3plex1pre03.prod.phx3.secureserver.net");
            txtCombo.Items.Add("p3plex1pre04.prod.phx3.secureserver.net");
            txtCombo.Items.Add("relay-app.secureserver.net");
            txtCombo.Items.Add("smtp.secureserver.net");
            txtCombo.Items.Add("smtpout.secureserver.net");
            txtPort.Text = "25";
            txtFrom.Clear();
            txtTo.Clear();
            txtCC.Clear();
            txtBCC.Clear();
            txtSubject.Clear();
            txtAHType1.Clear();
            txtAHType2.Clear();
            txtAHType3.Clear();
            txtAHMessage1.Clear();
            txtAHMessage2.Clear();
            txtAHMessage3.Clear();
            txtBody.Clear();
            ckbAuth.Checked = false;
            ckbReadReceipt.Checked = false;
            ckbRandom.Checked = false;
            ckbHTML.Checked = false;
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmailCount.Text = "1";
            txtAttachment.Items.Clear();
            txtAttachment.Items.Add("  1 MB");
            txtAttachment.Items.Add("  5 MB");
            txtAttachment.Items.Add("10 MB");
            txtAttachment.Items.Add("15 MB");
            txtAttachment.Items.Add("20 MB");
            cmbPriority.Items.Clear();
            cmbPriority.Items.Add("High");
            cmbPriority.Items.Add("Normal");
            cmbPriority.Items.Add("Low");
            txtServer.Focus();
            ckbRandomFrom.Checked = false;
            ckbRandomSubject.Checked = false;
            ckbRandomHeader.Checked = false;
            ckbRandomBody.Checked = false;
            ckbRandomTime.Checked = false;

        }
        #endregion Send Reset

        #region Authentication
        private void ckbAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAuth.Checked == true)
            {
                txtUsername.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
            }
        }
        #endregion Authentication

        #region Button Defaults
        private void btnData_Click(object sender, EventArgs e)
        {
            //txtServer.Text = "p3plex1pre01.prod.phx3.secureserver.net";
            txtCombo.Text = "relay-app.secureserver.net";
            ckbRandomFrom.Checked = true;
            ckbRandomSubject.Checked = true;
            ckbRandomBody.Checked = true;
            ckbRandomTime.Checked = true;
            //txtFrom.Text = "matt@magnusprinting.com";
            //txtTo.Text = "matt@123-ocb.net";
            //txtSubject.Text = "Best email tool ever";
            //txtBody.Text = "This is the message in the email body.";
            //txtBody.Focus();
            txtTo.Focus();
        }
        #endregion Button Defaults

        #region Button SPAM
        private void btnSpam_Click(object sender, EventArgs e)
        {
            txtServer.Text = "p3plex1pre01.prod.phx3.secureserver.net";
            txtFrom.Text = "matt@hungryyoungninja.com";
            txtTo.Text = "matt@123-ocb.net";
            txtSubject.Text = "Viagra - viagra - please catch this email";
            txtBody.Text = "This is the message in the email body.";
            txtBody.Focus();
        }
        #endregion Button SPAM

        #region Receive
        private void btnSendReceive_Click(object sender, EventArgs e)
        {
            //Console.SetOut(new TextBoxWriter(txtReceiveLog));
            //Console.WriteLine("Now redirecting output to the text box");
            string Server = txtServer.Text;
            string UserName = txtReceiveUserName.Text;
            string Password = txtPassword.Text;
            string Port1 = txtReceivePort.Text;
            int Port = Convert.ToInt32(Port1);
            //int Port = txtPort.Text;

            try
            {
                //prepare pop client
                //Pop3.Pop3MailClient DemoClient = new Pop3.Pop3MailClient("pop.gmail.com", 995, true, "Username@gmail.com", "password");
                #region SSL
                if (txtReceivePort.Text == "995")
                {
                    Pop3.Pop3MailClient DemoClient = new Pop3.Pop3MailClient(Server, Port, true, UserName, Password);
                    DemoClient.IsAutoReconnect = true;

                    //remove the following line if no tracing is needed
                    DemoClient.Trace += new Pop3.TraceHandler(Console.WriteLine);
                    DemoClient.ReadTimeout = 60000; //give pop server 60 seconds to answer

                    //establish connection
                    DemoClient.Connect();

                    //get mailbox statistics
                    int NumberOfMails, MailboxSize;
                    DemoClient.GetMailboxStats(out NumberOfMails, out MailboxSize);

                    //get a list of mails
                    List<int> EmailIds;
                    DemoClient.GetEmailIdList(out EmailIds);

                    //get a list of unique mail ids
                    List<Pop3.EmailUid> EmailUids;
                    DemoClient.GetUniqueEmailIdList(out EmailUids);

                    //get email size
                    DemoClient.GetEmailSize(1);

                    //get email
                    string Email;
                    DemoClient.GetRawEmail(1, out Email);

                    //delete email
                    DemoClient.DeleteEmail(1);

                    //get a list of mails
                    List<int> EmailIds2;
                    DemoClient.GetEmailIdList(out EmailIds2);

                    //undelete all emails
                    DemoClient.UndeleteAllEmails();

                    //ping server
                    DemoClient.NOOP();

                    //test some error conditions
                    DemoClient.GetRawEmail(1000000, out Email);
                    DemoClient.DeleteEmail(1000000);


                    //close connection
                    DemoClient.Disconnect();
                }
                #endregion SSL

                #region Non SSL
                else
                {
                    Pop3.Pop3MailClient DemoClient = new Pop3.Pop3MailClient(Server, Port, false, UserName, Password);
                    DemoClient.IsAutoReconnect = true;

                    //remove the following line if no tracing is needed
                    DemoClient.Trace += new Pop3.TraceHandler(Console.WriteLine);
                    DemoClient.ReadTimeout = 60000; //give pop server 60 seconds to answer

                    //establish connection
                    DemoClient.Connect();

                    //get mailbox statistics
                    int NumberOfMails, MailboxSize;
                    DemoClient.GetMailboxStats(out NumberOfMails, out MailboxSize);

                    //get a list of mails
                    List<int> EmailIds;
                    DemoClient.GetEmailIdList(out EmailIds);

                    //get a list of unique mail ids
                    List<Pop3.EmailUid> EmailUids;
                    DemoClient.GetUniqueEmailIdList(out EmailUids);

                    //get email size
                    DemoClient.GetEmailSize(1);

                    //get email
                    string Email;
                    DemoClient.GetRawEmail(1, out Email);

                    //delete email
                    DemoClient.DeleteEmail(1);

                    //get a list of mails
                    List<int> EmailIds2;
                    DemoClient.GetEmailIdList(out EmailIds2);

                    //undelete all emails
                    DemoClient.UndeleteAllEmails();

                    //ping server
                    DemoClient.NOOP();

                    //test some error conditions
                    DemoClient.GetRawEmail(1000000, out Email);
                    DemoClient.DeleteEmail(1000000);


                    //close connection
                    DemoClient.Disconnect();
                }
                #endregion Non SSL
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(
                        ex.Message + "\n\n" +
                        ex.GetType().ToString() + "\n" +
                        ex.StackTrace,
                        "Mail Exception Occured");
                    btnSend.Enabled = true;
                }
            }
        }

        private void btnReceiveReset_Click(object sender, EventArgs e)
        {
            txtReceiveUserName.Text = "";
            txtReceivePassword.Text = "";
            cmbReceiveServer.Text = "";
            txtReceiveLog.Text = "";
            txtReceiveUserName.Focus();
        }

        private void btnReceiveDefaults_Click(object sender, EventArgs e)
        {
            txtReceiveUserName.Text = "matt@magnusprinting.com";
            txtReceivePassword.Text = "Godaddy1";
            cmbReceiveServer.Text = "pop.secureserver.net";
            txtReceivePort.Text = "995";
            btnSendReceive.Focus();
        }
        #endregion Receive

        #region TextBox Writer
        public class TextBoxWriter : TextWriter
        {
            TextBox _output = null;

            public TextBoxWriter(TextBox output)
            {
                _output = output;
            }

            public override void Write(char value)
            {
                base.Write(value);
                _output.AppendText(value.ToString());
            }

            public override Encoding Encoding
            {
                get { return System.Text.Encoding.UTF8; }
            }
        }
        #endregion TextBox Writer

        #region Checkbox Random Subject
        private void ckbRandomSubject_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRandomSubject.Checked == true)
            {
                txtSubject.Text = "";
                txtSubject.ReadOnly = true;
            }
            else
            {
                txtSubject.ReadOnly = false;
            }
        }
        #endregion Checkbox Random Subject

        #region Checkbox Random Attachment
        private void ckbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRandom.Checked == true)
            {
                txtAttachment.Enabled = false;
            }

            else
            {
                txtAttachment.Enabled = true;
            }
        }
        #endregion Checkbox Random Attachment

        #region Checkbox Random Body
        private void ckbRandomBody_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRandomBody.Checked == true)
            {
                txtBody.Text = "";
                txtBody.Enabled = false;
            }

            else
            {
                txtBody.Enabled = true;
            }
        }
        #endregion Checkbox Random Body

        #region Random Header
        private void ckbRandomHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRandomHeader.Checked == true)
            {
                txtAHType1.Text = "";
                txtAHType2.Text = "";
                txtAHType3.Text = "";
                txtAHMessage1.Text = "";
                txtAHMessage2.Text = "";
                txtAHMessage3.Text = "";
                txtAHType1.Enabled = false;
                txtAHType2.Enabled = false;
                txtAHType3.Enabled = false;
                txtAHMessage1.Enabled = false;
                txtAHMessage2.Enabled = false;
                txtAHMessage3.Enabled = false;
            }

            else
            {
                txtAHType1.Enabled = true;
                txtAHType2.Enabled = true;
                txtAHType3.Enabled = true;
                txtAHMessage1.Enabled = true;
                txtAHMessage2.Enabled = true;
                txtAHMessage3.Enabled = true;
            }
        }
        #endregion Random Header

        #region Checkbox Random From
        private void ckbRandomFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRandomFrom.Checked == true)
            {
                txtFrom.Text = "";
                txtFrom.Enabled = false;
            }

            else
            {
                txtFrom.Enabled = true;
            }
        }
        #endregion Checkbox Random From

        #region Error Checking
        public bool IsValidData()
        {
            decimal numberofemails = 0m;
            decimal emailport = 0m;

            if (txtCombo.Text == String.Empty && txtServer.Text == String.Empty)
            {
                MessageBox.Show("Please select a server", "Mail Error");
                btnSend.Enabled = true;
                txtCombo.Focus();
                return false;
            }

            else if (txtFrom.Text == String.Empty && ckbRandomFrom.Checked == false)
            {
                MessageBox.Show("Please enter the From Address", "Mail Error");
                btnSend.Enabled = true;
                txtFrom.Focus();
                return false;
            }

            else if (txtTo.Text == String.Empty)
            {
                MessageBox.Show("Please enter the To Address", "Mail Error");
                btnSend.Enabled = true;
                txtTo.Focus();
                return false;
            }

            else if (!(Decimal.TryParse(txtEmailCount.Text, out numberofemails)))
            {
                MessageBox.Show("Please enter a number", "Mail Error");
                btnSend.Enabled = true;
                txtEmailCount.Focus();
                return false;
            }

            else if (!(Decimal.TryParse(txtPort.Text, out emailport)))
            {
                MessageBox.Show("Please enter a valid port", "Mail Error");
                btnSend.Enabled = true;
                txtPort.Focus();
                return false;
            }
            return true;
        }
        #endregion Error Checking
    }

    #region Unique String
    //Unique string creater for Org Names, email address's, email forwards, distribution lists, and domains
    public class UniqueString
    {
        static Random rnd = new Random();
        public static string GenerateId()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        public static long GenerateIdNum()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(buffer, 0);
        }

        public static string RandomStr()
        {
            string rStr = Path.GetRandomFileName();
            rStr = rStr.Replace(".", ""); // For Removing the .
            return rStr;
        }

        #region Random Words and Strings
        public static string RandomWords()
        {
            //string RandomNewNew = String.Empty;
            string[] MaleNames =    {"Jared", "Matt", "Rick", "Richard", "Samuel", "Henry", "George", "John", "James", "Phil", "Farhan", "Jay", "Jarrod", "Vinod", "Alek", "Jason", "Scott", "Cary", "Jeremiah"
                                    };

            string[] MaleText = {   "is my best friend. He is very kind!", 
                                    "has been doing crossfit for 1.5 years. Every since then he has been in OK shape.",
                                    "is the best soccer player I know. He can still kick the ball very, very, very far!", 
                                    "is a great manager! He is usually involved in all of the major projects.", 
                                    "wasn't able to come and help move last night. He was busy serving. We missed him, but understand where he was.", 
                                    "was a great man who lived a long time ago. He was very diligent in everything he did.", 
                                    "is someone I don't know very much about. His Dad sure is a good guy though.", 
                                    "was the first person I learned about in History class. He was very instrumental in helping our country.", 
                                    "is a great runner! He recently completed another marathon. I'd be lucky to be able to run a mile.", 
                                    "is a great brother. He is always taking care of his older brother Porter. I don't think anyone serves as much as him." 
                                };
            string[] FemaleNames =  {"Maggie", "Penny", "Sara", "Princess", "Abby", "Laila", "Sadie", "Olivia", "Star", "Talli", "Rachelle", "Rachel", "Susan", "Anna", "Heather", "Amy", "Heidi"
                                    };
            string[] FemaleText = { "is the friendliest person I know. She continues to reach out to anyone when ever there is a need.", 
                                    "is the most frugle person I know. She always saves here money. When she does go shoping she only buys items on sale.", 
                                    "is the funniest girl I know. She has a really great sense of humor.", 
                                    "is one cute girl. She looks like she could be a moviestar!", 
                                    "is a silly little girl. Once she grows up I'd be curious to see if she takes after her Mom.", 
                                    "is very unique. I guess you could tell that from her name though...", 
                                    "is the same age as my daughter. She is pretty lucky. She has a pool. She gets to go swimming a lot.", 
                                    "just graduated from High School. I can't believe she is old enough to do go there.", 
                                    "is getting ready to move. She has lived in the same town for many years. I will be interesting to see how she likes her new place.", 
                                    "is one sweet girl. I wasn't sure at first. I've known her since she was born." };
            string[] FruitNames =  {"Apple", "Peach", "Plum", "Fig", "Cantelope", "Honeydew", "Watermelon", "Banana", "Tomato"
                                   };
            string[] FruitText = {  "'s are the most common fruit people eat. In fact more people eat an apple a day than any other fruit combined", 
                                    "and icecream are a great combination!", 
                                    "s are a very delicious fruit. They are not as common as some of the others, but mighty good", 
                                    "tree. My Grandma had a one. It was a lot of fun to be able to go and eat one of them! I think I ate a dozen or two at one time. How many people can say that?", 
                                    "is juicy sweet. Nothing compares! That is once you scoop the seeds out", 
                                    "and Cantelope have often been debated on which is better. Most people prefer the orange melon though. I can't believe some people put salt on it though. Yuck!", 
                                    "is a wonderful treat in the summer. Nothing is better than after working all day and then taking a break to eat some", 
                                    "'s are my favorite fruit. I can eat one everyday. They are also a good source of vitamins as well.", 
                                    "are a fruit. Yes that is right. Most people don't know that. I know I use to not." };
            string[] RandomWords = {"I am so kind!", 
                                    "How is your day going?", 
                                    "Is that your truck?", 
                                    "I want to take a seat. I'm tired!", 
                                    "Did you see who hit that ball?", 
                                    "Who ate the candy from the cookie jar?", 
                                    "Whom say ye that I am?", 
                                    "Did they really win? That is awesome!", 
                                    "They will never get away with it" };
            string[] Animals = {    "Who's afraid of a big bad bear? A big bad bear?", 
                                    "Dogs are a man's best friend! In fact I take mine on a walk quite often.", 
                                    "I'm surprised to still hear about how so many peopel love cats. They are not my favorite animal.", 
                                    "Tiger's are one fast animal. I wouldn't want to meet one in the jungle!", 
                                    "Lion's are the king of jungle. No one dares to mess with them.", 
                                    "Caterpillar's are one strange creature. Now butterlies on the other hand are beautiful!", 
                                    "Have you tried goat milk before? Me either and I never want to!", 
                                    "I have tried to milk a cow though. The milk is a great source of protein!", 
                                    "Bugs are one annoying creature. I have never met a good bug. Okay a good bug that was alive." };
            string[] Cards = {      "♣ King", "♣ Queen", "♣ Jack", " ♣", "♣ 7", "♣ 8", "♣ 9", "♣ 10",
                                    "♦ King", "♦ Queen", "♦ Jack", " ♦", "♦ 7", "♦ 8", "♦ 9", "♦ 10",
                                    "♥ King", "♥ Queen", "♥ Jack", " ♥", "♥ 7", "♥ 8", "♥ 9", "♥ 10",
                                    "♠ King", "♠ Queen", "♠ Jack", " ♠", "♠ 7", "♠ 8", "♠ 9", "♠ 10" };
            string[] Quotes = {     "From the short time my son has worked with Coach Cassidy the level of commitment and passion needed to play well in soccer has already trickled down from the coach to player", 
                                    "Coach Cassidy has a genuine love for soccer. He has helped my son grow as soccer player with new skills and in confidence on the field.", 
                                    "Coach Cassidy has high expectations and it is very rewarding to see this plant itself amongst the team.", 
                                    "Not only does Coach Cassidy have a wealth of knowledge about soccer - everything from the game's history, current trends, to tactics - he has an ability to pinpoint areas for development for his teams as well as the individual player, understanding how to create drills and teach children with saintly patience that translates into successful teamwork and results on the field.", 
                                    "My son plays on a different rec team and has a lot fun with his friends. However, there is something to be said when you are on a team where you do not know anybody but you come away having stepped up a level in game play and desire to win as a team.", 
                                    "Without a doubt, Cassidy is my son's favorite coach.", 
                                    "My son is working hard with Coach Cassidy because there is shared passion for the game and a sense of respect between coach/player." };
            int m1Index = rnd.Next(MaleNames.Length);
            int mIndex = rnd.Next(MaleText.Length);
            int f1Index = rnd.Next(FemaleNames.Length);
            int fIndex = rnd.Next(FemaleText.Length);
            int o1Index = rnd.Next(FruitNames.Length);
            int oIndex = rnd.Next(FruitText.Length);
            int aIndex = rnd.Next(Animals.Length);
            int rIndex = rnd.Next(RandomWords.Length);
            int r1Index = rnd.Next(RandomWords.Length);
            int cIndex = rnd.Next(Cards.Length);
            int qIndex = rnd.Next(Quotes.Length);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int numemails = Convert.ToInt32("1");
            for (int i = 0; i < numemails; i++)
            {
                string Both = Quotes[qIndex] + " " + RandomWords[rIndex] + " " + MaleNames[m1Index] + " " + MaleText[mIndex] + " " + FemaleNames[f1Index] + " " + FemaleText[fIndex] + Cards[cIndex] + ". " + RandomWords[r1Index] + " " + FruitNames[o1Index] + " " + FruitText[oIndex] + " " + Animals[aIndex] + ". ";
                sb.Append(Both);
            }
            return sb.ToString();
        }
        #endregion Random Words and Strings

        #region Random Subject
        public static string RandomSubject()
        {
            string[] Subject = { "Upcoming Soccer Schedule", 
                                "Skills and drills competition", 
                                "Rewarding to see this plant itself amongst the team", 
                                "The game's history, current trends, to tactics", 
                                "Stepped up a level in game play and desire to win as a team", 
                                "Without a doubt, Cassidy is my son's favorite coach.", 
                                "Shared passion for the game and a sense of respect between coach/player",
                                "Customer Cancel Survey Results", 
                                "SDET Automation Questions", 
                                "Thank you for Attending our Offsite Event", 
                                "Project Thumper - What can you do to help?", 
                                "Webservice Address", 
                                "Your activity for the week", 
                                "All changes are due today",
                                "If you would like an opportunity please let me know", 
                                "Hey how's it going?", 
                                "Please respond if you would like your vote heard", 
                                "Have you seen the good news?", 
                                "Uh oh! That was not suppose to happen", 
                                "Did you hear what Apple released today?", 
                                "Have you used Windows 8 yet?",
                                "Can you believe how early he was pulled from the game?", 
                                "Are you enjoying the playoffs as much as me?", 
                                "Can you please send me the latest contact address", 
                                "This is the most exciting email you will read today", 
                                "Coach K is the best!", 
                                "Final soccer game will be this Saturday", 
                                "If only you were the oldest member",
                                "The world's most affordable places to retire",
                                "Special Offers From Soccer Friends",
                                "3D printing: Don't believe the hype",
                                "Important information - Field Changes",
                                "Have you mastered the art of listening?",
                                "You're Invited to Join The Soccer Club. Enter Code NEWGEAR at Checkout to Take 20% Off Your First Purchase of $50 or more!",
                                "Be the face of Soccer Style",
                                "Stocks gyrate as U.S. economy nears crucial test",
                                "Get Your Testing Team to the Next Level",
                                "Five Questions You Must Ask Your Team",
                                "Code your own summer project",
                                "The best way to handle customers who don't pay",
                                "Are you building websites using jQuery yet?",
                                "Justin invited you to Thrive Leadership Day",
                                "5 ways companies beat the tax man",
                                "Summer Fridays: 9 pros and cons",
                                "Weird ways to make work wonderful",
                                "The Perfect Gift",
                                "Money lessons every graduate should know",
                                "Wealthiest Americans get most tax gravy",
                                "How to lead like Phil Jackson",
                                "Webinar Series - July Events",
                                "Get a head start",
                                "Save on the new training 100% Online",
                                "Brochure Now Available for Download",
                                "The open door policy",
                                "Early bird pricing. Hurry ends soon",
                                "Weekly deal alerts!",
                                "It's camp season! Save up to 25% on these savings",
                                "Hotlist for August",
                                "Desert Garden Nursery",
                                "Chill out with our new smoothies",
                                "NASCAR Racing Experience"
                               };
            string[] Subject1 = {"JIT",
                                 "Unreal",
                                 "Unbelievable",
                                 "Awesome",
                                 "Incredible",
                                 "Opportunity",
                                 "Chance",
                                 "Occasion",
                                 "Opening",
                                 "Break",
                                 "Prospect",
                                 "Accidental",
                                 "Limited",
                                 "Exciting",
                                 "Super",
                                 "WOW",
                                 "Please",
                                 "Hurry",
                                 "Once",
                                 "Program",
                                 "Details",
                                 "Activity",
                                 "Thank You",
                                 "Thanks",
                                 "Project",
                                 "Feedback"
                                };
            string[] Subject2 = {"!",
                                 ".",
                                 ",",
                                 ";",
                                 ":",
                                 "#",
                                 "$",
                                 "%",
                                 "*",
                                 ":"
                                };
            int sIndex = rnd.Next(Subject.Length);
            int s1Index = rnd.Next(Subject1.Length);
            int s2Index = rnd.Next(Subject2.Length);
            string Both = Subject1[s1Index] + Subject2[s2Index] + " " + Subject[sIndex];
            return Both;
        }
        #endregion Random Subject

        #region Random Header AHType1
        public static string RandomHeader()
        {
            string[] Headers = {
                                "X-Mailer", 
                                "X-MimeOLE", 
                                "Message-ID", 
                                "x-mid", 
                                "x-job", 
                                "x-rpcampaign", 
                                "x-orgId",
                                "X-CSA-Complaints", 
                                "List-Unsubscribe", 
                                "X-MatchID", 
                                "X-JobId", 
                                "X-UserId", 
                                "X-Mailer", 
                                "X-Campaign",
                                "X-Mailer", 
                                "X-campaignid", 
                                "X-Report-Abuse", 
                                "x-accounttype", 
                                "X-pid", 
                                "X-eid", 
                                "X-AcxSID",
                                "X-score", 
                                "X-Ls-Send-Id", 
                                "X-Mailer", 
                                "X-RM-EmailName", 
                                "X-RM-UserHash", 
                                "X-MSFBL", 
                                "X-RPCampaign",
                                "X-RPTags",
                                "X-Recruiting",
                                "X-AntiAbuse",
                                "X-AntiAbuse",
                                "X-AntiAbuse",
                                "X-Facebook-Camp", 
                                "X-Facebook-Notify", 
                                "X-Auto-Response-Suppress"
                                //"X-Mailer: Microsoft Office Outlook, Build 12.0.4210", 
                                //"X-MimeOLE: Produced By Microsoft MimeOLE V6.00.2800.1165", 
                                //"Message-ID: <063f4a6f-50c5-4f13-9441-5851d38cbba3@xtnrtta4134.xt.local>", 
                                //"x-mid: 41354663", 
                                //"x-job: 41354663", 
                                //"x-rpcampaign: sp41354663", 
                                //"x-orgId: 49708",
                                //"X-CSA-Complaints: whitelist-complaints@eco.de", 
                                //"List-Unsubscribe: <mailto:v-hello_lnmkdfile_lgpgkla_lgpgkla_a@bounce.test.mkt5144.com?subject=Unsubscribe>", 
                                //"X-MatchID:TWDC16541882", 
                                //"X-JobId:15425882", 
                                //"X-UserId:129E07D1-4444-854D-A2A0-F26D8547E88D2", 
                                //"X-Mailer: Breakthru Email Marketing", 
                                //"X-Campaign: mailchimp705788080f1ef1c606ff7a5f0.45b485cfd4",
                                //"X-Mailer: MailChimp Mailer - **CID45b380cfd4c6edd2c38f**", 
                                //"X-campaignid: mailchimp705788080f1ef1c606rg7a5f0.45b380cfd4", 
                                //"X-Report-Abuse: Please report abuse for this campaign here: http://www.mailchimp.com/abuse/abuse.phtml?u=705788080f1ef1c606ff7a5f0&id=45b380cfd4&e=c6add2c38f", 
                                //"x-accounttype: pd", 
                                //"X-pid: 81796", 
                                //"X-eid: 2.5.3Nc.2tI.11Jv_o.DMNvnI..N..J_4.CTXXJRS0", 
                                //"X-AcxSID: 13798.81596",
                                //"X-score: 10", 
                                //"X-Ls-Send-Id: g_4S4JTPELT2BIH0EE8T5DR1VUA7PJSN12CFQI81HCVLGDDAUJELUG====", 
                                //"X-Mailer: Syringe 1.0.0", 
                                //"X-RM-EmailName: daily-email_phoenix_rm", 
                                //"X-RM-UserHash: ed44e929af91619cc39feef5c4082c0f308f80d58r3b55a29954b650c21cd3e0", 
                                //"X-MSFBL: Z3JvdXBvbkBtYXR0Y29wcGxlLmNvbUBybUBybUBkYWlseS3fbWFpbF9waG9lbml4X3JtQDNmMDEyYzc4LWRhNjktNGsdfOS04MGE1LTIyMDI1YzRiOGExM0AdsfIzNjQ0OUBVUw==", 
                                //"X-RPCampaign: Groupondailyemaillosrm20130619",
                                //"X-RPTags: daily-email_phoenix_rm",
                                //"X-Recruiting: Interested in headers? Join us: www.groupon.com/techjobs/",
                                //"X-AntiAbuse: This header was added to track abuse, please include it with any abuse report",
                                //"X-AntiAbuse: Primary Hostname - server1.populardrops.com",
                                //"X-AntiAbuse: Originator/Caller UID/GID - [35783 32587] / [17 92]",
                                //"X-Facebook-Camp: engage_digest_email", 
                                //"X-Facebook-Notify: engage_digest_email; mailid=82ae45bG540f3855G0Gd4", 
                                //"X-Auto-Response-Suppress: All" 
                               };
            int hIndex = rnd.Next(Headers.Length);
            string Both = Headers[hIndex];
            return Both;
        }
        #endregion Random Header AHType1

        #region Random Header AHMessage1
        public static string RandomHeaderMessage()
        {
            string[] HeadersMessage = { "Microsoft Office Outlook, Build 12.0.4210", 
                                "Produced By Microsoft MimeOLE V6.00.2800.1165", 
                                "<063f4a6f-50c5-4f13-9441-5851d38cbba3@xtnrtta4134.xt.local>", 
                                "41354663", 
                                "41354663", 
                                "sp41354663", 
                                "49708",
                                "whitelist-complaints@eco.de", 
                                "<mailto:v-hello_lnmkdfile_lgpgkla_lgpgkla_a@bounce.test.mkt5144.com?subject=Unsubscribe>", 
                                "TWDC16541882", 
                                "15425882", 
                                "129E07D1-4444-854D-A2A0-F26D8547E88D2", 
                                "Breakthru Email Marketing", 
                                "mailchimp705788080f1ef1c606ff7a5f0.45b485cfd4",
                                "MailChimp Mailer - **CID45b380cfd4c6edd2c38f**", 
                                "mailchimp705788080f1ef1c606rg7a5f0.45b380cfd4", 
                                "Please report abuse for this campaign here: http://www.mailchimp.com/abuse/abuse.phtml?u=705788080f1ef1c606ff7a5f0&id=45b380cfd4&e=c6add2c38f", 
                                "pd", 
                                "81796", 
                                "2.5.3Nc.2tI.11Jv_o.DMNvnI..N..J_4.CTXXJRS0", 
                                "13798.81596",
                                "10", 
                                "g_4S4JTPELT2BIH0EE8T5DR1VUA7PJSN12CFQI81HCVLGDDAUJELUG====", 
                                "Syringe 1.0.0", 
                                "daily-email_phoenix_rm", 
                                "ed44e929af91619cc39feef5c4082c0f308f80d58r3b55a29954b650c21cd3e0", 
                                "Z3JvdXBvbkBtYXR0Y29wcGxlLmNvbUBybUBybUBkYWlseS3fbWFpbF9waG9lbml4X3JtQDNmMDEyYzc4LWRhNjktNGsdfOS04MGE1LTIyMDI1YzRiOGExM0AdsfIzNjQ0OUBVUw==", 
                                "Groupondailyemaillosrm20130619",
                                "daily-email_phoenix_rm",
                                "Interested in headers? Join us: www.groupon.com/techjobs/",
                                "This header was added to track abuse, please include it with any abuse report",
                                "Primary Hostname - server1.populardrops.com",
                                "Originator/Caller UID/GID - [35783 32587] / [17 92]",
                                "engage_digest_email", 
                                "engage_digest_email; mailid=82ae45bG540f3855G0Gd4", 
                                "All" };
            int mIndex = rnd.Next(HeadersMessage.Length);
            string Both = HeadersMessage[mIndex];
            return Both;
        }
        #endregion Random Header AHMessage1

        #region Random From Address
        public static string RandomFromAddress()
        {
            string[] FirstAddress = {    "Jackson", 
                                        "Susan", 
                                        "Fred", 
                                        "Billy", 
                                        "Todd", 
                                        "Hero", 
                                        "Bill",
                                        "Abe", 
                                        "Kristy", 
                                        "Chrissy", 
                                        "Salli",  
                                        "DietDr", 
                                        "Parkman", 
                                        "Sitey", 
                                        "Norm", 
                                        "China", 
                                        "Interweb",
                                        "Matt", 
                                        "Todd", 
                                        "Sara", 
                                        "Kristen", 
                                        "North", 
                                        "Charity", 
                                        "Gretchen",
                                        "Jarrad",
                                        "Jared",
                                        "Maryanne",
                                        "Mary",
                                        "Suzie",
                                        "SueAnn", 
                                        "Cindy", 
                                        "Bobby",
                                        "Jacob",
                                        "Mason",
                                        "Ethan",
                                        "Noah",
                                        "William",
                                        "Liam",
                                        "Jayden",
                                        "Michael",
                                        "Alexander",
                                        "Aiden",
                                        "Sophia",
                                        "Emma",
                                        "Isabella",
                                        "Olivia",
                                        "Ava",
                                        "Emily",
                                        "Abigail",
                                        "Mia",
                                        "Madison",
                                        "Elizabeth",
                                        "Martin",
                                        "Bryson",
                                        "Marco",
                                        "Colby",
                                        "Donovan",
                                        "Sergio",
                                        "Leonardo",
                                        "Elias",
                                        "Abraham",
                                        "Gregory",
                                        "Raymond",
                                        "Jalen",
                                        "Malachi",
                                        "Hector",
                                        "Trenton",
                                        "Erick",
                                        "Devon",
                                        "Johnathan",
                                        "Edwin",
                                        "Erik",
                                        "Mario",
                                        "Edgar",
                                        "Jasmin",
                                        "Ellie",
                                        "Karina",
                                        "Delaney",
                                        "Adrianna",
                                        "Jazmin",
                                        "Abby",
                                        "Veronica",
                                        "Lilly",
                                        "Makenzie",
                                        "Camila",
                                        "Brittany",
                                        "Liliana",
                                        "Alana",
                                        "Chelsea",
                                        "Hope",
                                        "Angelica",
                                        "Kiara",
                                        "Erica",
                                        "Crystal",
                                        "Bianca",
                                        "Lucy",
                                        "Alondra",
                                        "Serenity",
                                        "Giselle",
                                        "Caitlyn",
                                        "Reagan",
                                        "Juliana",
                                        "Cassandra",
                                        "Tiffany",
                                        "Jayla",
                                        "Cassidy",
                                        "Kylee",
                                        "Kendall",
                                        "Eva",
                                        "Kelly"
                                      };
            string[] LastAddress = {    "Washington", 
                                        "Lincoln", 
                                        "Mariner", 
                                        "Smith", 
                                        "Johnson", 
                                        "Hitchcock", 
                                        "Earb",
                                        "Eager", 
                                        "May", 
                                        "Hernandez", 
                                        "Jimmens",  
                                        "Alexander", 
                                        "Walmer", 
                                        "Saar", 
                                        "Mosi", 
                                        "Nicolas", 
                                        "Cotter",
                                        "Peterson", 
                                        "Koppel", 
                                        "Pospis", 
                                        "Monson", 
                                        "West", 
                                        "Jacobs", 
                                        "Taylor",
                                        "Bush",
                                        "Walker",
                                        "Barns",
                                        "Brown",
                                        "Miterski",
                                        "Steed", 
                                        "Murach", 
                                        "Stevens",
                                        "Stevenson",
                                        "Hayes",
                                        "Diaz",
                                        "Griffin",
                                        "Russell",
                                        "Bryant",
                                        "Gonzales",
                                        "Foster",
                                        "Simmons",
                                        "Butler",
                                        "Ross",
                                        "Barnes",
                                        "Wood",
                                        "Price",
                                        "Brooks",
                                        "Watson",
                                        "James",
                                        "Murphy",
                                        "Bailey",
                                        "Bell",
                                        "Murphy",
                                        "Perez",
                                        "Turner",
                                        "Baker",
                                        "Morris",
                                        "Stewart",
                                        "Sanchez",
                                        "Rivera",
                                        "Richardson",
                                        "Cox"
                                      };
            int fIndex = rnd.Next(FirstAddress.Length);
            int lIndex = rnd.Next(LastAddress.Length);
            string Both = FirstAddress[fIndex] + LastAddress[lIndex];
            return Both;
        }
        #endregion Random From Address

        #region Random TTL
        public static string RandomTTL()
        {
            string[] TTL = {    ".net", 
                                ".com", 
                                ".org", 
                                ".info"
                           };
            int tIndex = rnd.Next(TTL.Length);
            string Both = TTL[tIndex] + " ";
            return Both;
        }
        #endregion Random TTL

        #region Random Delay send
        public static string RandomTimeDelay()
        {
            string[] TimeDelay = {  "0", 
                                    "1", 
                                    "2",
                                    "3",
                                    "4",
                                    "5",
                                    "6",
                                    "7",
                                    "8",
                                    "9",
                                    "10",
                                    "11",
                                    "12",
                                    "13",
                                    "14",
                                    "15",
                                    "16",
                                    "17",
                                    "18",
                                    "19",
                                    "20",
                                    "21",
                                    "22",
                                    "23",
                                    "24",
                                    "25",
                                    "26",
                                    "27",
                                    "28",
                                    "29",
                                    "30"
                                  };
            int tIndex = rnd.Next(TimeDelay.Length);
            string Both = TimeDelay[tIndex] + "000";
            return Both;
        }
        #endregion Random Random Delay send

    }
    #endregion

    #region Return Strings
    //Shorten the Unique String
    public class UniqueStringShort
    {
        public static string GenerateShortID()
        {
            string UniqueShortID = UniqueString.GenerateId();
            return UniqueShortID.Substring(0, Math.Min(UniqueShortID.Length, 7));
        }

        public static string GenerateRandomString()
        {
            string UniqueRandomString = UniqueString.RandomStr();
            return UniqueRandomString;
        }

        public static string GenerateRandomWord()
        {
            string UniqueRandomWord = UniqueString.RandomWords();
            return UniqueRandomWord;
        }

        public static string GenerateRandomSubject()
        {
            string UniqueRandomSubject = UniqueString.RandomSubject();
            return UniqueRandomSubject;
        }

        public static string GenerateRandomHeader()
        {
            string UniqueRandomHeader = UniqueString.RandomHeader();
            return UniqueRandomHeader;
        }

        public static string GenerateRandomHeaderMessage()
        {
            string UniqueRandomHeaderMessage = UniqueString.RandomHeaderMessage();
            return UniqueRandomHeaderMessage;
        }

        public static string GenerateRandomFromAddress()
        {
            string GenerateRandomFromAddress = UniqueString.RandomFromAddress();
            return GenerateRandomFromAddress;
        }

        public static string GenerateRandomTTL()
        {
            string GenerateRandomTTL = UniqueString.RandomTTL();
            return GenerateRandomTTL;
        }

        public static string GenerateRandomTimeDelay()
        {
            string RandomTimeDelay = UniqueString.RandomTimeDelay();
            return RandomTimeDelay;
        }

        //public static string GenerateRandomWord()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    string UniqueRandomWord = UniqueString.RandomWords();
        //    int numemails = Convert.ToInt32("10");
        //    for (int i = 0; i < numemails; i++)
        //    {
        //        sb.Append(UniqueRandomWord);
        //    }
        //    return sb.ToString();
        //}
    }

    //Shorten the Unique String
    public class UniqueStringShort1
    {
        public static int GenerateShortID()
        {
            string uniqueDS = Convert.ToString(UniqueString.GenerateIdNum());
            string New = uniqueDS.Substring(0, Math.Min(uniqueDS.Length, 6));
            int NewID = Convert.ToInt32(New);
            return NewID;
        }
    }
    #endregion
}
