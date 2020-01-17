using AE.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailclient
{

    class Connections
    {
        public static readonly int PAGE_OFFSET = 30;
        private static readonly string GMAIL_IMAP_SERVER = "imap.gmail.com";
        private static readonly string MAIL_IMAP_SERVER = "imap.mail.ru";

        public static readonly string SEND_GMAIL_MAILBOX = "[Gmail]/Отправленные";
        public static readonly string SPAM_GMAIL_MAILBOX = "[Gmail]/Важное";
        public static readonly string ALL_GMAIL_MAILBOX = "[Gmail]/Вся почта";
        public static readonly string RECYCLEBIN_GMAIL_MAILBOX = "[Gmail]/Помеченые";
        public static readonly string INBOX_MAILBOX = "INBOX";

        public static readonly string SEND_MAIL_MAILBOX = "[Mail]/Отправленные";
        public static readonly string SPAM_MAIL_MAILBOX = "[Mail]/Важное";
        public static readonly string ALL_MAIL_MAILBOX = "[Mail]/Вся почта";
        public static readonly string RECYCLEBIN_MAIL_MAILBOX = "[Mail]/Помеченые";

        private static ImapClient mImapClient;
        public static int mCurrentPage = 1;
        public static MailMessage[] mMailMessages;

        public static bool openNewImapClient() {
            try
            {
                if(UserData.checkIsGmailEmail())
                    mImapClient = new ImapClient(GMAIL_IMAP_SERVER, UserData.getEmailAddres(),
                        UserData.getEmailPassword(), AE.Net.Mail.AuthMethods.Login, 993, true);
                else
                    mImapClient = new ImapClient(MAIL_IMAP_SERVER, UserData.getEmailAddres(),
                        UserData.getEmailPassword(), AE.Net.Mail.AuthMethods.Login, 993, true);
                mImapClient.SelectMailbox(INBOX_MAILBOX);
                AE.Net.Mail.Imap.Mailbox[] mailBoxes = mImapClient.ListMailboxes(string.Empty, "*");
                foreach (var mailBox in mailBoxes)
                {
                    var mailboxName = mailBox.Name;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public static void selectInbox(string pInbox) {
            mImapClient.SelectMailbox(pInbox);
            loadMessagesWithOffset();
        }

        public static void loadAllMessages() {
            mMailMessages = mImapClient.GetMessages(mImapClient.GetMessageCount(), 0);
        }

        public static void loadMessagesWithOffset(){
            mMailMessages = mImapClient.GetMessages(mImapClient.GetMessageCount() - (PAGE_OFFSET * (mCurrentPage-1)),
                mImapClient.GetMessageCount() - (PAGE_OFFSET*mCurrentPage));
        }

        public static void deleteMail(AE.Net.Mail.MailMessage m) {
            mImapClient.DeleteMessage(m);
        }

        public static MailMessage getMessageByIndex(int Index) {
            if (Index < 0)
                Index = 0;
            return mImapClient.GetMessages(mImapClient.GetMessageCount() - Index, mImapClient.GetMessageCount() - Index - 1, false).ToList()[0];
        }
        public static int getMassagesCount() {
            return mImapClient.GetMessageCount();
        }
    }
}
