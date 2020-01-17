using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Mail;
namespace Mailclient
{
    public partial class NewMailForm : Form
    {
        public static string AttachmentPath, AttachmentContent;

        public NewMailForm()
        {
            InitializeComponent();
        }
        private void SendNewMailButton_Click(object sender, EventArgs e)
        {
            SendingMailResult.Text = "";
            NetConsoleApp.MailSMTPClient mailSMTPClient = new NetConsoleApp.MailSMTPClient();
            string message = "Отправить письмо?";
            string caption = "Подтверждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (NetConsoleApp.MailSMTPClient.SendNewMail(DisplayedName.Text,
                    NewMailAddress.Text,
                    NewMailSubject.Text,
                    NewMailText.Text))
                {
                    SendingMailResult.Text = "Письмо отправлено";
                }
                else
                {
                    SendingMailResult.Text = "Письмо не отправлено";
                }
            }

        }

        private void NewMailForm_Load(object sender, EventArgs e)
        {
            NewMailAddress.BackColor = Color.FromArgb(47, 47, 47);
            NewMailSubject.BackColor = Color.FromArgb(47, 47, 47);
            NewMailText.BackColor = Color.FromArgb(55, 55, 55);
            DisplayedName.BackColor = Color.FromArgb(47, 47, 47);
            SendNewMailButton.BackColor = Color.FromArgb(30, 30, 30);
            AddFile.BackColor = Color.FromArgb(30, 30, 30);
            panel1.BackColor = Color.FromArgb(47, 47, 47);
            this.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    AttachmentPath = openFileDialog.FileName;
                  
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        AttachmentContent = reader.ReadToEnd();
                    }
                }
            }
            FilePathLabel.Text = AttachmentPath;
        }
    }
}
namespace NetConsoleApp
{
    class MailSMTPClient
    {
        public static bool SendNewMail(string DisplayedName,
             string AddressTo,
             string Subject,
             string Body) {
            if (String.IsNullOrEmpty(DisplayedName) ||
                String.IsNullOrEmpty(AddressTo) ||
                String.IsNullOrEmpty(Subject) ||
                String.IsNullOrEmpty(Body)) {
                return false;
            }
            MailAddress from = new MailAddress(Mailclient.UserData.getEmailAddres(), DisplayedName);
            MailAddress to = new MailAddress(AddressTo);
            MailMessage m = new MailMessage(from, to);
            m.Subject = Subject;
            m.Body = Body;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(Mailclient.UserData.getEmailAddres(), Mailclient.UserData.getEmailPassword());
            smtp.EnableSsl = true;
            if(!String.IsNullOrEmpty(Mailclient.NewMailForm.AttachmentPath))
                m.Attachments.Add(new Attachment(Mailclient.NewMailForm.AttachmentPath));

            smtp.Send(m);
            return true;
        }
    }
}


