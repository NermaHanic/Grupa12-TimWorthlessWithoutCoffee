using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Email
    {
        public Email(string preporuciPrijatelju, string passwordRecovery)
        {
            this.preporuciPrijatelju = preporuciPrijatelju;
            this.passwordRecovery = passwordRecovery;
        }

        public string preporuciPrijatelju { get; }
        public string passwordRecovery { get; }

    }
}