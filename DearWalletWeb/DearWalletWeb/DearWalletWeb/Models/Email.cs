using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Email
    {
        private string preporukaPrijatelju;
        private string passwordRecovery;

        public string PreporukaPrijatelju { get => preporukaPrijatelju; set => preporukaPrijatelju = value; }
        public string PasswordRecovery { get => passwordRecovery; set => passwordRecovery = value; }
    }
}