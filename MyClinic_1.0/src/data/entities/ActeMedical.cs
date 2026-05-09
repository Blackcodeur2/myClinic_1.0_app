using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.entities
{
    public class ActeMedical : BaseEntity
    {
        public int Id { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Libelle { get; set; } = string.Empty;

        public string? Categorie { get; set; }

        public decimal PrixUnitaire { get; set; }

        public decimal TauxTVA { get; set; }

        // Navigation
        public ICollection<LigneFacture> LignesFacture { get; set; }
            = new List<LigneFacture>();
    }
}
