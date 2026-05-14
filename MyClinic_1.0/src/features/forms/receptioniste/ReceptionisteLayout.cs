using MyClinic_1._0.src.features.controls.receptioniste;
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

namespace MyClinic_1._0.src.features.forms.receptioniste
{
    public partial class ReceptionisteLayout : Form
    {
        private Dictionary<string, UserControl> _pages = new Dictionary<string, UserControl>();
        private UserControl? _currentPage;
        public ReceptionisteLayout()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _pages.Add("accueil", new ReceptionisteAccueil());
            _pages.Add("profile", new UserProfile());
            _pages.Add("ventes", new VentesView());

            showPage("accueil");

        }

        private void showPage(string pageKey)
        {
            if (_currentPage != null)
                _currentPage.Visible = false;
            _currentPage = _pages[pageKey];
            _currentPage.Dock = DockStyle.Fill;

            if (!receptionisteLayoutContent.Controls.Contains(_currentPage))
                receptionisteLayoutContent.Controls.Add(_currentPage);
            _currentPage.Visible = true;
            _currentPage.BringToFront();
        }
        private void ReceptionisteLayout_Load(object sender, EventArgs e)
        {

        }

        private void monProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage("profile");
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage("accueil");
        }

        private void ventesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage("ventes");
        }
    }
}
