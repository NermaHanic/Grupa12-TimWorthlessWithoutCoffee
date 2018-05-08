using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DearWalletWeb
{
    public class Mjera
    {

        private int duzinaRuke;
        private int duzinaNoge;
        private int obimStruka;
        private int obimGrudi;
        private int sirinaRamena;
        //povezivanje
        private ICollection<OdjevniPredmet> odjevniPredmeti;

        public int DuzinaRuke { get => duzinaRuke; set => duzinaRuke = value; }
        public int DuzinaNoge { get => duzinaNoge; set => duzinaNoge = value; }
        public int ObimStruka { get => obimStruka; set => obimStruka = value; }
        public int ObimGrudi { get => obimGrudi; set => obimGrudi = value; }
        public int SirinaRamena { get => sirinaRamena; set => sirinaRamena = value; }
        public virtual ICollection<OdjevniPredmet> OdjevniPredmeti { get => odjevniPredmeti; set => odjevniPredmeti = value; }
    }
}