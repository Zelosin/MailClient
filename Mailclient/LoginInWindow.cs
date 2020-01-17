using AE.Net.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mailclient
{
    public partial class MainWindow : Form
    {
        protected BinaryWriter bw;
        protected BinaryReader br;
        public MainWindow()
        {
            InitializeComponent();
            EmailPasswordTxt.Text = "";
            try
            {
                br = new BinaryReader(new FileStream("data.bin", FileMode.Open));
            }
            catch (IOException e){            
                return;
            }
            try
            {
                EmailAddressTxt.Text = br.ReadString();
                EmailPasswordTxt.Text = br.ReadString();
            }
            catch (IOException e)
            {
                return;
            }
        }

        private void LoginInBtn_Click(object sender, EventArgs e)
        {
            UserData.getInstance(EmailAddressTxt.Text, EmailPasswordTxt.Text);
            if (Connections.openNewImapClient())
            {
                Connections.loadMessagesWithOffset();
                LoginedWindow logined = new LoginedWindow();

                if (RememberChk.Checked)
                {
                    bw = new BinaryWriter(new FileStream("data.bin", FileMode.Create));
                    bw.Write(EmailAddressTxt.Text);
                    bw.Write(EmailPasswordTxt.Text);
                    bw.Close();
                }

                this.Hide();
                logined.Show();
                logined.updateCurrentPageLb();
                logined.addMessageToList();
            }
            else
                ErrorLb.Visible = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(47,47,47);
            EmailAddressTxt.BackColor = Color.FromArgb(47, 47, 47);
            EmailPasswordTxt.BackColor = Color.FromArgb(47, 47, 47);
            LoginInBtn.BackColor = Color.FromArgb(30, 30, 30);
        }
    }
}
