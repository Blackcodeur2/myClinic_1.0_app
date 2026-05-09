using MyClinic_1._0.src.cores.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.entities
{
    public class Patient : BaseEntity
    {
        public int Id { get; set; }

        public string NumDossier { get; set; } = string.Empty;

        public string Nom { get; set; } = string.Empty;

        public string Prenom { get; set; } = string.Empty;

        public DateTime DateNaissance { get; set; }

        public SexeEnum Sexe { get; set; }
        public double Taille { get; set; }
        public double Poids { get; set; }

        public string? Telephone { get; set; }

        public string? Email { get; set; }

        public string? Adresse { get; set; }

        // Navigation
        public ICollection<Consultation> Consultations { get; set; }
            = new List<Consultation>();

        public ICollection<Facture> Factures { get; set; }
            = new List<Facture>();
        
    }
}
