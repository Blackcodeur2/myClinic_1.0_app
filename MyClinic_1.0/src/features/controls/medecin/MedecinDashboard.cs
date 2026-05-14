using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MyClinic_1._0.src.features.controls.medecin
{
    public partial class MedecinDashboard : UserControl
    {
        public MedecinDashboard()
        {
            InitializeComponent();
            // Hook load for initialization
            this.Load += MedecinDashboard_Load;
        }

        private void MedecinDashboard_Load(object? sender, EventArgs e)
        {
            // Remplir l'UI avec des données d'exemple — remplace par des appels réels
            PopulateDummyStats();
            PopulateDummyConsultations();
        }

        private void PopulateDummyStats()
        {
            // Exemple : récupérer depuis ton service / DbContext
            lblPatientsCount.Text = "412";
            lblConsultsCount.Text = "8";
            lblRdvCount.Text = "5";
        }

        private void PopulateDummyConsultations()
        {
            dgvRecentConsultations.Rows.Clear();

            // Ajout de lignes d'exemple. Remplace par des données réelles.
            dgvRecentConsultations.Rows.Add("Dupont Jean", DateTime.Now.AddHours(-1).ToString("g"), "Contrôle");
            dgvRecentConsultations.Rows.Add("Martin Claire", DateTime.Now.AddHours(-3).ToString("g"), "Consultation initiale");
            dgvRecentConsultations.Rows.Add("Ngozi Paul", DateTime.Now.AddDays(-1).ToString("g"), "Suivi traitement");
        }

        private void BtnNewConsultation_Click(object? sender, EventArgs e)
        {
            // Ouvrir formulaire de nouvelle consultation
            MessageBox.Show("Ouvrir le formulaire de nouvelle consultation.", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPrescrire_Click(object? sender, EventArgs e)
        {
            // Ouvrir l'interface de prescription
            MessageBox.Show("Ouvrir la prescription.", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPatients_Click(object? sender, EventArgs e)
        {
            // Naviguer vers la liste des patients
            MessageBox.Show("Afficher la liste des patients.", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
