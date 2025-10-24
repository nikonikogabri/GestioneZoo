using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamettaZoo
{
    class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Eta { get; set; }
        public double Peso { get; set; }
        public string StatoSalute { get; set; }
        public int DataArrivo { get; set; }
        public int DataAttuale { get; set; }
        public int AnniAlloZoo { get; set; }

        private double _pesoIniziale;
        private int _controlliVeterinari;
        private double _variazionePeso;
        private int _statoSaluteAt;

        public virtual void CalcolaCiboDiarioKg()
        {
        }

        public virtual void CalcolaCostoGestioneMensile()
        {
        }

        public virtual void EmettiVerso()
        {
        }

        public double AggiornaPeso(double nuovoPeso)
        {
            _variazionePeso = nuovoPeso - Peso;
            Peso = nuovoPeso;
            return Peso;
        }

        public virtual void MostraInfo()
        {
        }
    }
}
