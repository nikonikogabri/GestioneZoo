using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamettaZoo
{
    class Pinguino : Animale
    {
        public string Nome { get; set; } = "Skipper";
        public int Eta { get; set; } = 4;
        public double PesoKg { get; set; } = 12;
        public string Salute { get; set; } = "Buona";

        public double TemperaturaAcquaIdealeC { get; set; } = 2.0;
        public int UovaQuestAnno { get; set; } = 2;
        public double PesoInizialeKg { get; set; } = 11.5;
        public int ControlliVeterinariEffettuati { get; set; } = 2;
        public double SpessoreGrassoMm { get; set; } = 25;
        public double TempoInAcquaOggiOre { get; set; } = 6;
        public double CiboGiornalieroKg { get; set; } = 1.5;
        public double CostoMensileEuro { get; set; } = 250;
        public double VelocitaNuotoKmH { get; set; } = 12;

        private double CalcolaVariazionePesoPercentuale()
        {
            return ((PesoKg - PesoInizialeKg) / PesoInizialeKg) * 100;
        }

        private bool VerificaIsolamentoOttimale()
        {
            return SpessoreGrassoMm >= 20 && SpessoreGrassoMm <= 30;
        }

        private string ValutaAttivitaGiornaliera()
        {
            return TempoInAcquaOggiOre >= 5 ? "Sufficiente" : "Insufficiente";
        }

        public override void CalcolaCostoGestioneMensile()
        {
            base.CalcolaCostoGestioneMensile();
            Console.WriteLine($"Costo mensile di gestione: €{CostoMensileEuro}");
        }

        public override void EmettiVerso()
        {
            base.EmettiVerso();
            Console.WriteLine("Il pinguino emette un verso gracchiante!");
        }

        public void MostraSchedaInformativa()
        {
            Console.WriteLine($"[Pinguino] {Nome} - {Eta} anni - {PesoKg} kg - Salute: {Salute}");
            Console.WriteLine($"Acqua ideale: {TemperaturaAcquaIdealeC}°C | Uova: {UovaQuestAnno}");
            Console.WriteLine($"Peso iniziale: {PesoInizialeKg} kg ({CalcolaVariazionePesoPercentuale():+0.0;-0.0;0.0}%)");
            Console.WriteLine($"Controlli veterinari: {ControlliVeterinariEffettuati}");
            Console.WriteLine($"Grasso: {SpessoreGrassoMm} mm");
            Console.WriteLine($"Tempo in acqua: {TempoInAcquaOggiOre}h");
            Console.WriteLine($"Cibo: {CiboGiornalieroKg} kg | Costo: €{CostoMensileEuro}");
            Console.WriteLine($"Nuoto: {VelocitaNuotoKmH} km/h");
        }
    }
}