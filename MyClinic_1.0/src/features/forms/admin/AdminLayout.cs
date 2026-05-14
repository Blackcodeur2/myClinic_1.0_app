using Guna.UI2.WinForms;
using MyClinic_1._0.src.features.controls.admin;
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

namespace MyClinic_1._0.src.features.forms.admin
{
    public partial class AdminLayout : Form
    {
        private Dictionary<string, UserControl> _pages = new Dictionary<string, UserControl>();
        private UserControl? _currentPage;
        public AdminLayout()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(800, 600);
            _pages.Add("dashboard", new MyAdminDashboard());
            _pages.Add("users", new AdminUsers());
            _pages.Add("new-user", new UserAddForm());
            _pages.Add("profile", new MyUserProfile());

            showPage("dashboard");

        }

        private void showPage(string pageKey)
        {
            if (_currentPage != null)
                _currentPage.Visible = false;
            _currentPage = _pages[pageKey];
            _currentPage.Dock = DockStyle.Fill;

            if (!adminLayoutContainer.Controls.Contains(_currentPage))
                adminLayoutContainer.Controls.Add(_currentPage);
            _currentPage.Visible = true;
            _currentPage.BringToFront();
        }

        private void HighlightButton(Guna2TileButton activeBtn)
        {
            foreach (Control ctrl in adminSideBarPanel.Controls)
            {
                if (ctrl is Guna2TileButton btn)
                    btn.BackColor = Color.FromArgb(45, 45, 48);
            }

            activeBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            showPage("dashboard");
            HighlightButton(btnAdminDashboard);
        }

        private void btnadminUtilisateurs_Click(object sender, EventArgs e)
        {
            showPage("users");
            HighlightButton(btnadminUtilisateurs);
        }

        private void btnAdminActivity_Click(object sender, EventArgs e)
        {
            showPage("new-user");
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            showPage("profile");
        }

        private void btnAdminSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
