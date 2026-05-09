using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.entities
{
    public class LigneFacture
    {
        public int Id { get; set; }

        public int FactureId { get; set; }

        public int ActeId { get; set; }

        public int Quantite { get; set; } = 1;

        public decimal PrixUnitaire { get; set; }

        public decimal TauxTVA { get; set; }

        public decimal Remise { get; set; }

        public decimal SousTotal { get; set; }

        // Navigation
        public Facture Facture { get; set; } = null!;

        public ActeMedical ActeMedical { get; set; } = null!;
    }
}
