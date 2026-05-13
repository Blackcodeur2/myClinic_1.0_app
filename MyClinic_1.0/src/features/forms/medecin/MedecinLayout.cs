using MyClinic_1._0.src.features.controls.medecin;
using MyClinic_1._0.src.features.controls.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinic_1._0.src.features.forms.medecin
{
    public partial class MedecinLayout : Form
    {
        private Dictionary<string, UserControl> _pages = new Dictionary<string, UserControl>();
        private UserControl? _currentPage;
        public MedecinLayout()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(800, 600);
            _pages.Add("dashboard", new MedecinDashboard());
            _pages.Add("consultations", new MedecinConsultations());
            _pages.Add("medicaments", new MedecinMedicaments());
            _pages.Add("services", new MedecinServices());
            _pages.Add("patients", new MedecinPatients());
            _pages.Add("profile", new UserProfile());

            showPage("dashboard");
        }

        private void showPage(string pageKey)
        {
            if (_currentPage != null)
                _currentPage.Visible = false;
            _currentPage = _pages[pageKey];
            _currentPage.Dock = DockStyle.Fill;

            if (!medecinLayoutContainer.Controls.Contains(_currentPage))
                medecinLayoutContainer.Controls.Add(_currentPage);
            _currentPage.Visible = true;
            _currentPage.BringToFront();
        }

        private void MedecinLayout_Load(object sender, EventArgs e)
        {

        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            showPage("medicaments");
        }

        private void btnReceptionisteAccueil_Click(object sender, EventArgs e)
        {
            showPage("dashboard");
        }

        private void btnMedecinProfile_Click(object sender, EventArgs e)
        {
            showPage("profile");
        }

        private void btnMedecinServices_Click(object sender, EventArgs e)
        {
            showPage("services");
        }

        private void btnMedecinConsultaions_Click(object sender, EventArgs e)
        {
            showPage("consultations");
        }

        private void btnMedecinPatients_Click(object sender, EventArgs e)
        {
            showPage("patients");
        }
    }
}
