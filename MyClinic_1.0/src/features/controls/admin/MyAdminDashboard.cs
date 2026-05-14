using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MyClinic_1._0.src.features.controls.admin
{
    public partial class MyAdminDashboard : UserControl
    {
        private DataTable usersTable = new DataTable();

        public MyAdminDashboard()
        {
            InitializeComponent();
            Load += MyAdminDashboard_Load;
        }

        private void MyAdminDashboard_Load(object? sender, EventArgs e)
        {
            InitializeUsersTable();
            PopulateDummyStats();
            PopulateDummyUsers();
        }

        private void InitializeUsersTable()
        {
            usersTable.Clear();
            usersTable.Columns.Clear();
            usersTable.Columns.Add("Username", typeof(string));
            usersTable.Columns.Add("Role", typeof(string));
            usersTable.Columns.Add("LastLogin", typeof(string));

            dgvUsers.DataSource = usersTable;
        }

        private void PopulateDummyStats()
        {
            // Remplace par des lectures depuis AppDbContext
            lblUsersCount.Text = "128";
            lblSessionsCount.Text = "7";
            lblRequestsCount.Text = "3";
        }

        private void PopulateDummyUsers()
        {
            usersTable.Rows.Clear();

            usersTable.Rows.Add("admin", "Administrateur", DateTime.Now.AddHours(-2).ToString("g"));
            usersTable.Rows.Add("pmartin", "Receptionniste", DateTime.Now.AddDays(-1).ToString("g"));
            usersTable.Rows.Add("dr.kabore", "Médecin", DateTime.Now.AddMinutes(-30).ToString("g"));
            usersTable.Rows.Add("pharmacien1", "Pharmacien", DateTime.Now.AddDays(-3).ToString("g"));
            usersTable.Rows.Add("sdupont", "Comptable", DateTime.Now.AddHours(-5).ToString("g"));
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                var filter = txtSearch.Text.Trim().Replace("'", "''");
                var dt = dgvUsers.DataSource as DataTable;
                if (dt == null) return;

                if (string.IsNullOrEmpty(filter))
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    dt.DefaultView.RowFilter =
                        $"Username LIKE '%{filter}%' OR Role LIKE '%{filter}%'";
                }
            }
            catch
            {
                // silence en cas d'erreur de filtre
            }
        }

        private void BtnAddUser_Click(object? sender, EventArgs e)
        {
            // Ouvrir formulaire d'ajout d'utilisateur — à remplacer par la vraie fenêtre
            MessageBox.Show("Ouvrir le formulaire d'ajout d'utilisateur.", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRoles_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Gérer les rôles et permissions.", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSettings_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Ouvrir les paramètres système.", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvUsers_DoubleClick(object? sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            var username = dgvUsers.CurrentRow.Cells["colUsername"].Value?.ToString();
            if (!string.IsNullOrEmpty(username))
            {
                MessageBox.Show($"Éditer l'utilisateur : {username}", "Édition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
