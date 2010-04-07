using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace ToolToSendEmails
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                if (!string.IsNullOrEmpty(this.txtFrom.Text))
                {
                    this.progressBar1.Minimum = 0;
                    this.progressBar1.Maximum = 2;
                    this.progressBar1.Value = 0;
                    int taskNumber = 0;

                    string from = this.txtFrom.Text;
                    string subject = this.txtSubject.Text;
                    string body = this.txtBody.BodyHtml;
                    string to = string.Empty;

                    MailMessage msg = new MailMessage();
                    msg.Subject = subject;
                    msg.Body = body;
                    msg.From = new MailAddress(from);
                    msg.IsBodyHtml = true;

                    SmtpClient client = new SmtpClient(Properties.Settings.Default.smtpServer);
                    client.UseDefaultCredentials = true;

                    this.labInfo.Text = "Loading customers email addresses...";
                    this.progressBar1.Value = taskNumber++;
                    smallmvc.customerDAO customerDAO = new ToolToSendEmails.smallmvc.customerDAO();
                    List<smallmvc.customerVO> listCustomers = customerDAO.GetAll();

                    this.labInfo.Text = "Sending emails...";
                    this.progressBar1.Value = taskNumber++;

                    System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex(@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$");

                    int maxAddress = Convert.ToInt32(txtMaxAddress.Value);
                    foreach (smallmvc.customerVO customer in listCustomers)
                    {
                        try
                        {
                            if (this.chkTest.Checked)
                                to = from;
                            else
                                to = customer.Email;
                            if ((regEx.IsMatch(from)) && (regEx.IsMatch(to)))
                            {
                                msg.Bcc.Add(new MailAddress(to));

                                if (msg.Bcc.Count >= maxAddress)
                                {
                                    client.Send(msg);
                                    msg.Bcc.Clear();
                                }
                            }
                            if (this.chkTest.Checked) 
                                break;
                        }
                        catch
                        {
                        }
                    }

                    this.progressBar1.Value = taskNumber++;
                    MessageBox.Show("Messages sent!");
                }
                else
                    MessageBox.Show("You must enter from address!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
           
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default.fromAddress = this.txtFrom.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtFrom.Text = Properties.Settings.Default.fromAddress;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
