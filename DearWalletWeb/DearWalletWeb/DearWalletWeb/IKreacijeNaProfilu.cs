﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletWeb
{
    public interface IKreacijeNaProfilu
    {
        void DodajKreaciju();
        void Obrisikreaciju(string sifraKreacije);
    }
}
