using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailclient
{
    class UserData
    {
        private static string EmailAddres;
        private static string EmailPassword;
        private static UserData instance;
        private static bool isGmailEmail = true;
        private UserData(string pEmailAddres, string pEmailPassword)
        {
            EmailAddres = pEmailAddres;
            EmailPassword = pEmailPassword;
            if (EmailAddres.Contains("gmail"))
                isGmailEmail = true;
            else
                isGmailEmail = false;
        }
        public static bool checkIsGmailEmail() {
            return isGmailEmail;
        }
        public static UserData getInstance(string pEmailAddres = "null", string pEmailPassword = "null")
        {
            if (instance == null)
                instance = new UserData(pEmailAddres, pEmailPassword);
            return instance;
        }
        public static string getEmailAddres() {
            return EmailAddres;   
        }
        public static string getEmailPassword()
        {
            return EmailPassword;
        }
    }
}
