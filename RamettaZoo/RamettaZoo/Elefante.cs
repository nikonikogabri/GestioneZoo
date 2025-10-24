using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamettaZoo
{
    class Elefante : Animale
    {
        public string Nome { get; set; } = "Dumbo";
        public int Eta { get; set; } = 25;
        public double PesoKg { get; set; } = 4500;
        public string Salute { get; set; } = "Ottima";

        public double LunghezzaProboscideCm { get; set; } = 180;
        public double ConsumoAcquaLitriGiorno { get; set; } = 200;
        public double PesoInizialeKg { get; set; } = 4200;
        public int ControlliVeterinariEffettuati { get; set; } = 5;
        public int SalutePelle { get; set; } = 95;
        public int BagniSettimana { get; set; } = 4;
        public double CiboGiornalieroKg { get; set; } = 180;
        public double CostoMensileEuro { get; set; } = 800;
        public bool MemoriaEccezionale { get; set; } = true;

        private double CalcolaVariazionePesoPercentuale()
        {
            return ((PesoKg - PesoInizialeKg) / PesoInizialeKg) * 100;
        }

        private string ValutaSalutePelle()
        {
            if (SalutePelle >= 90) return "Eccellente";
            if (SalutePelle >= 70) return "Buona";
            return "Scarsa";
        }

        private string ValutaIdratazione()
        {
            return BagniSettimana >= 3 ? "Idratazione ottimale" : "Necessita più bagni";
        }

        public override void CalcolaCostoGestioneMensile()
        {
            base.CalcolaCostoGestioneMensile();
            Console.WriteLine($"Costo mensile di gestione: €{CostoMensileEuro}");
        }

        public override void EmettiVerso()
        {
            base.EmettiVerso();
            Console.WriteLine("L'elefante barrisce!");
        }

        public void MostraSchedaInformativa()
        {
            Console.WriteLine($"[Elefante] {Nome} - {Eta} anni - {PesoKg} kg - Salute: {Salute}");
            Console.WriteLine($"Proboscide: {LunghezzaProboscideCm} cm | Acqua: {ConsumoAcquaLitriGiorno} L/giorno");
            Console.WriteLine($"Peso iniziale: {PesoInizialeKg} kg ({CalcolaVariazionePesoPercentuale():+0.0;-0.0;0.0}%)");
            Console.WriteLine($"Controlli veterinari: {ControlliVeterinariEffettuati}");
            Console.WriteLine($"Salute pelle: {SalutePelle}/100 ({ValutaSalutePelle()})");
            Console.WriteLine($"Bagni settimana: {BagniSettimana} ({ValutaIdratazione()})");
            Console.WriteLine($"Cibo: {CiboGiornalieroKg} kg | Costo: €{CostoMensileEuro}");
            Console.WriteLine($"Memoria: {(MemoriaEccezionale ? "ricorda eventi di 20 anni fa!" : "normale")}");
        }
    }
}

