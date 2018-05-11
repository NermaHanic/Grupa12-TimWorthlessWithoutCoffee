using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public static class Email
    {
        private static string preporuciPrijatelju;
        private static string passwordRecovery;

        public static string PreporuciPrijatelju { get => preporuciPrijatelju; set => preporuciPrijatelju = value; }
        public static string PasswordRecovery { get => passwordRecovery; set => passwordRecovery = value; }
    }
}