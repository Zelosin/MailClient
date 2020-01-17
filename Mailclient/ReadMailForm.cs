using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mailclient
{
    public partial class ReadMailForm : Form
    {
        AE.Net.Mail.MailMessage mCurrentMail;
        public void DisplayMail(int IndexInArray) {
            mCurrentMail = Connections.getMessageByIndex(IndexInArray);
            AddressLabel.Text = mCurrentMail.Sender +"(" + mCurrentMail.From + ")\n" +mCurrentMail.Subject;
            MailBody.Text = mCurrentMail.Body;
            WebBrowser.DocumentText = mCurrentMail.Body;
        }

        public ReadMailForm()
        {
            InitializeComponent();
        }

        private void DisplayTextBtn_Click(object sender, EventArgs e){
            MailBody.Visible = true;
            WebBrowser.Visible = false;
        }

        private void DisplayHTMLBtn_Click(object sender, EventArgs e){
            MailBody.Visible = false;
            WebBrowser.Visible = true;
        }

        private void DeleteMailBtn_Click(object sender, EventArgs e){
            NetConsoleApp.MailSMTPClient mailSMTPClient = new NetConsoleApp.MailSMTPClient();
            string message = "Удалить письмо?";
            string caption = "Подтверждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;    

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Connections.deleteMail(mCurrentMail);
                this.Close();
            }
        }
        private void ReadMailForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(47, 47, 47);
            this.BackColor = Color.FromArgb(47, 47, 47);
            DisplayHTMLBtn.BackColor = Color.FromArgb(30, 30, 30);
            DisplayTextBtn.BackColor = Color.FromArgb(30, 30, 30);
            DeleteMailBtn.BackColor = Color.FromArgb(30, 30, 30);
            MailBody.BackColor = Color.FromArgb(55, 55, 55);
            WebBrowser.BackColor = Color.FromArgb(47, 47, 47);
        }
    }
}
