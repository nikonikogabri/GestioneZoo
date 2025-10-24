using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamettaZoo
{
    class Leone : Animale
    {
        public float LunghezzaCriniera { get; set; }

        private double _temperaturaCorporeaC;
        private int _ultimaPredazione;

        private double CalcolaGiorniDallUltimaPredazione()
        {

            double giorni = (DateTime.Now.DayOfYear - _ultimaPredazione);
            return giorni;
        }

        private double VerificaTemperaturaAnomala()
        {

            double temperaturaMedia = 38.5;
            return _temperaturaCorporeaC - temperaturaMedia;
        }

        public override void CalcolaCostoGestioneMensile()
        {
            base.CalcolaCostoGestioneMensile();

        }

        public override void EmettiVerso()
        {
            base.EmettiVerso();
            Console.WriteLine("Il leone ruggisce!");
        }

        public int OreDiSonnoAlGiorno()
        {

            return 18;
        }

        public int RegistraPredazione()
        {

            _ultimaPredazione = DateTime.Now.DayOfYear;
            return _ultimaPredazione;
        }
    }

}
