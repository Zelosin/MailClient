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
    public partial class LoginedWindow : Form
    {
        public LoginedWindow()
        {
            InitializeComponent();
        }

        private int mSliderWidth = 175;
        private bool isHidenSlider = true;
        public void addMessageToList() {
            MessagesListView.Items.Clear();
            foreach (var mess in Connections.mMailMessages) {
                ListViewItem item = new ListViewItem(mess.Date.ToString());
                if (mess.From != null)
                    item.SubItems.Add(mess.From.ToString());
                else
                    item.SubItems.Add("");
                if (mess.From != null)
                    item.SubItems.Add(mess.Subject.ToString());
                else
                    item.SubItems.Add("");
                /*item.SubItems.Add(mess.Body.ToString());*/
                MessagesListView.Items.Insert(0, item);
            }       
        }
        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if (isHidenSlider)
            {
                SlideMenu.Width += 25;
                if (SlideMenu.Width >= mSliderWidth)
                {
                    SlideTimer.Stop();
                    isHidenSlider = false;
                    this.Refresh();
                }
            }
            else {
                SlideMenu.Width -= 25;
                if (SlideMenu.Width <= 0)
                {
                    SlideTimer.Stop();
                    isHidenSlider = true;
                    this.Refresh();
                }
            }
        }
        private void NewMailButton_Click(object sender, EventArgs e)
        {
            NewMailForm MailForm = new NewMailForm();
            MailForm.Show();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            SlideTimer.Start();
        }
        private void MessagesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (MessagesListView.SelectedItems.Count > 0)
            {
                ReadMailForm readMailForm = new ReadMailForm();
                readMailForm.DisplayMail(MessagesListView.Items.IndexOf(MessagesListView.SelectedItems[0])+
                    (Connections.PAGE_OFFSET*(Connections.mCurrentPage-1)));
                readMailForm.TopMost = true;
                readMailForm.Show();
                MessagesListView.SelectedItems.Clear();
            }
        }
        public void updateCurrentPageLb() {
            CurrentPageLb.Text = "" + ((Connections.mCurrentPage - 1) * (Connections.PAGE_OFFSET)+1) + "-" +
                            ((Connections.mCurrentPage * Connections.PAGE_OFFSET)+1) + " из " + Connections.getMassagesCount();
        }
        private void NextPageBtn_Click(object sender, EventArgs e){
            if (Connections.mCurrentPage != (int)Connections.getMassagesCount() / Connections.PAGE_OFFSET){
                Connections.mCurrentPage++;
                RefreshBtn_Click(null, null);
            }
            else
                return;
        }
        private void PrevPageBtn_Click(object sender, EventArgs e){
            if (Connections.mCurrentPage != 1){
                Connections.mCurrentPage--;
                
                RefreshBtn_Click(null, null);
            }
            else
                return;
        }

        private void RefreshBtn_Click(object sender, EventArgs e){
            updateCurrentPageLb();
            Connections.loadMessagesWithOffset();
            addMessageToList();
        }

        private void ToBeginBtn_Click(object sender, EventArgs e){
                Connections.mCurrentPage = 1;
            RefreshBtn_Click(null, null);
        }

        private void ToEndBtn_Click(object sender, EventArgs e){
            Connections.mCurrentPage = (int) Connections.getMassagesCount() / Connections.PAGE_OFFSET;
            RefreshBtn_Click(null, null);
        }

        private void LoginedWindow_FormClosing(object sender, FormClosingEventArgs e){
            Application.Exit();
        }

        private void MessagesListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = MessagesListView.Columns[e.ColumnIndex].Width;
        }

        private void InboxBtn_Click(object sender, EventArgs e)
        {
            Connections.selectInbox(Connections.INBOX_MAILBOX);
            RefreshBtn_Click(null, null);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            Connections.selectInbox(Connections.SEND_GMAIL_MAILBOX);
            RefreshBtn_Click(null, null);
        }

        private void SpamBtn_Click(object sender, EventArgs e)
        {
            Connections.selectInbox(Connections.SPAM_GMAIL_MAILBOX);
            RefreshBtn_Click(null, null);
        }

        private void RecyclebinBtn_Click(object sender, EventArgs e)
        {
            Connections.selectInbox(Connections.RECYCLEBIN_GMAIL_MAILBOX);
            RefreshBtn_Click(null, null);
        }

        private void LoginedWindow_Load(object sender, EventArgs e)
        {
            SlideMenu.BackColor = Color.FromArgb(47, 47, 47);
            TopPnl.BackColor = Color.FromArgb(47, 47, 47);
            MessagesListView.BackColor = Color.FromArgb(55, 55, 55);

            InboxBtn.BackColor = Color.FromArgb(30, 30, 30);
            SendBtn.BackColor = Color.FromArgb(30, 30, 30);
            SpamBtn.BackColor = Color.FromArgb(30, 30, 30);
            NewMailButton.BackColor = Color.FromArgb(30, 30, 30);
            RefreshBtn.BackColor = Color.FromArgb(30, 30, 30);
            PrevPageBtn.BackColor = Color.FromArgb(30, 30, 30);
            NextPageBtn.BackColor = Color.FromArgb(30, 30, 30);
            ToEndBtn.BackColor = Color.FromArgb(30, 30, 30);
            ToBeginBtn.BackColor = Color.FromArgb(30, 30, 30);

            
        }
    }
}
