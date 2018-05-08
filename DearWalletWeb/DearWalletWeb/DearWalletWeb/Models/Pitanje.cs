using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Pitanje
    {
        private string tekst;
        private Odgovor izabraniOdgovor;
        private Odgovor odg1;
        private Odgovor odg2;
        private Odgovor odg3;
        private Kviz kviz;

        
        public string Tekst { get => tekst; set => tekst = value; }
        public virtual Odgovor Odg1 { get => odg1; set => odg1 = value; }
        public virtual Odgovor Odg2 { get => odg2; set => odg2 = value; }
        public virtual Odgovor Odg3 { get => odg3; set => odg3 = value; }
        public Odgovor IzabraniOdgovor { get => izabraniOdgovor; set => izabraniOdgovor = value; }
        public virtual Kviz Kviz { get => kviz; set => kviz = value; }
    }
}