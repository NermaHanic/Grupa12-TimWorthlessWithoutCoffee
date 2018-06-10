using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearWalletDressMeUp.Model
{
    public class Kreacija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string id;
        private byte[] boja;
        private byte[] dezen = null;
        private double trenutnaCijena;
        private string idOdjevnogPredmeta;
        private DefaultVelicine defVel;
        private Mjera mjera;

        public Kreacija(double trenutnaCijena, string sifraKreacije, byte[] boja, byte[] dezen, string idOdjevnogPredmeta)
        {
            this.trenutnaCijena = trenutnaCijena;
            this.IdOdjevnogPredmeta = idOdjevnogPredmeta;
            this.id = sifraKreacije;
            this.dezen = dezen;
            this.boja = boja;
        }

        public DefaultVelicine DefVel { get => defVel; set => defVel = value; }
        public Mjera Mjera { get => mjera; set => mjera = value; }
        public double TrenutnaCijena { get => trenutnaCijena; set => trenutnaCijena = value; }
        public string Id { get => id; set => id = value; }
        public byte[] Boja { get => boja; set => boja = value; }
        public byte[] Dezen { get => dezen; set => dezen = value; }
        public string IdOdjevnogPredmeta { get => idOdjevnogPredmeta; set => idOdjevnogPredmeta = value; }

        public double ObracunajCijenu() { return 0; }
    }
}
