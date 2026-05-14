using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using MyClinic_1._0.src.data.database;
using MyClinic_1._0.src.data.entities;

namespace MyClinic_1._0.src.features.controls.admin
{
    public partial class AdminUsers : UserControl
    {
        private readonly DataTable usersTable = new DataTable();

        public AdminUsers()
        {
            InitializeComponent();
            Load += AdminUsers_Load;
        }

        private void AdminUsers_Load(object? sender, EventArgs e)
        {
            InitializeUsersTable();
            LoadUsers();
        }

        private void InitializeUsersTable()
        {
            usersTable.Clear();
            usersTable.Columns.Clear();
            usersTable.Columns.Add("Id", typeof(int));
            usersTable.Columns.Add("Login", typeof(string));
            usersTable.Columns.Add("Role", typeof(string));
            usersTable.Columns.Add("DernierAcces", typeof(string));

            // Bind to grid via DataView for filtering capability
            dgvUsers.DataSource = usersTable;
        }

        private void LoadUsers()
        {
            try
            {
                // Create scope to resolve AppDbContext
                using var scope = MyClinic_1._0.Program.ServiceProvider!.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                usersTable.Rows.Clear();

                var users = db.Users
                    .OrderBy(u => u.Login)
                    .ToList();

                foreach (var u in users)
                {
                    var dernier = u.DernierAcces.HasValue ? u.DernierAcces.Value.ToString("g") : "-";
                    usersTable.Rows.Add(u.Id, u.Login, u.Role.ToString(), dernier);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des utilisateurs : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                var filter = txtSearch.Text.Trim().Replace("'", "''");
                var dataTable = dgvUsers.DataSource as DataTable;
                if (dataTable == null)
                    return;

                if (string.IsNullOrEmpty(filter))
                {
                    dataTable.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    dataTable.DefaultView.RowFilter =
                        $"Login LIKE '%{filter}%' OR Role LIKE '%{filter}%'";

                      //something like this in .net 6+  instead ?
                     // DataView dv = (DataView)dgvUsers.DataSource;
                    // dv.RowFilter = string.Format("Login LIKE '%{0}%' OR Role LIKE '%{0}%'", filter);
                }
            }
            catch
            {
                // ignorer erreurs de filtre
            }
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadUsers();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            // Si tu as un UserAddForm UserControl, on l'héberge dans une Form modale.
            try
            {
                var addControl = new UserAddForm { Dock = DockStyle.Fill };
                using var frm = new Form
                {
                    Text = "Ajouter un utilisateur",
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(600, 420)
                };
                frm.Controls.Add(addControl);
                frm.ShowDialog();

                // Après fermeture, recharger la liste
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Impossible d'ouvrir le formulaire d'ajout : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            var idObj = dgvUsers.CurrentRow.Cells["colId"].Value;
            if (idObj == null) return;

            if (!int.TryParse(idObj.ToString(), out var id)) return;

            var confirm = MessageBox.Show("Confirmer la suppression de l'utilisateur sélectionné ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using var scope = MyClinic_1._0.Program.ServiceProvider!.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                var user = db.Users.Find(id);
                if (user == null)
                {
                    MessageBox.Show("Utilisateur introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.Users.Remove(user);
                db.SaveChanges();

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvUsers_DoubleClick(object? sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            var idObj = dgvUsers.CurrentRow.Cells["colId"].Value;
            if (idObj == null) return;

            if (!int.TryParse(idObj.ToString(), out var id)) return;

            // Ouvrir édition — si tu as un formulaire d'édition, ouvre-le ici.
            MessageBox.Show($"Éditer l'utilisateur Id={id} (à implémenter).", "Édition", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
