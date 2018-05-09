using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Mjera
    {
        private int obimStruka;
        private int obimGrudi;
        private int sirinaRamena;
        private int duzinaRuke;
        private int duzinaNoge;

        public Mjera(int obimStruka, int obimGrudi, int sirinaRamena, int duzinaRuke, int duzinaNoge)
        {
            this.obimStruka = obimStruka;
            this.obimGrudi = obimGrudi;
            this.sirinaRamena = sirinaRamena;
            this.duzinaRuke = duzinaRuke;
            this.duzinaNoge = duzinaNoge;
        }

        public int ObimStruka { get => obimStruka; set => obimStruka = value; }
        public int ObimGrudi { get => obimGrudi; set => obimGrudi = value; }
        public int SirinaRamena { get => sirinaRamena; set => sirinaRamena = value; }
        public int DuzinaRuke { get => duzinaRuke; set => duzinaRuke = value; }
        public int DuzinaNoge { get => duzinaNoge; set => duzinaNoge = value; }

    }
}
