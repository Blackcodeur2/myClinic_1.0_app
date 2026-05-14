namespace MyClinic_1._0.src.features.controls.admin
{
    partial class AdminUsers
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Label lblTitle;
        private FlowLayoutPanel actionsPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            actionsPanel = new FlowLayoutPanel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();

            SuspendLayout();

            // headerPanel
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 56;
            headerPanel.Padding = new Padding(10);
            headerPanel.FillColor = System.Drawing.Color.Transparent;
            headerPanel.Controls.Add(lblTitle);

            // lblTitle
            lblTitle.Text = "Utilisateurs du système";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // actionsPanel
            actionsPanel.Dock = DockStyle.Top;
            actionsPanel.Height = 56;
            actionsPanel.Padding = new Padding(10);
            actionsPanel.FlowDirection = FlowDirection.LeftToRight;

            // txtSearch
            txtSearch.PlaceholderText = "Rechercher (login ou rôle)...";
            txtSearch.Width = 300;
            txtSearch.Margin = new Padding(6, 10, 6, 10);
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // btnRefresh
            btnRefresh.Text = "Rafraîchir";
            btnRefresh.AutoRoundedCorners = true;
            btnRefresh.BorderRadius = 16;
            btnRefresh.Size = new System.Drawing.Size(120, 36);
            btnRefresh.Click += BtnRefresh_Click;

            // btnAdd
            btnAdd.Text = "Ajouter";
            btnAdd.AutoRoundedCorners = true;
            btnAdd.BorderRadius = 16;
            btnAdd.Size = new System.Drawing.Size(120, 36);
            btnAdd.Click += BtnAdd_Click;

            // btnDelete
            btnDelete.Text = "Supprimer";
            btnDelete.AutoRoundedCorners = true;
            btnDelete.BorderRadius = 16;
            btnDelete.Size = new System.Drawing.Size(120, 36);
            btnDelete.Click += BtnDelete_Click;

            actionsPanel.Controls.Add(txtSearch);
            actionsPanel.Controls.Add(btnRefresh);
            actionsPanel.Controls.Add(btnAdd);
            actionsPanel.Controls.Add(btnDelete);

            // dgvUsers
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = System.Drawing.Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Margin = new Padding(10);
            dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            // Columns: Id (hidden), Login, Role, DernierAcces
            dgvUsers.Columns.Add("colId", "Id");
            dgvUsers.Columns.Add("colLogin", "Login");
            dgvUsers.Columns.Add("colRole", "Rôle");
            dgvUsers.Columns.Add("colDernierAcces", "Dernier accès");

            dgvUsers.Columns["colId"].Visible = false;
            dgvUsers.DoubleClick += DgvUsers_DoubleClick;

            // Compose control
            Controls.Add(dgvUsers);
            Controls.Add(actionsPanel);
            Controls.Add(headerPanel);

            // UserControl defaults
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Padding = new Padding(10);
            Name = "AdminUsers";
            Size = new System.Drawing.Size(1000, 600);

            ResumeLayout(false);
        }

        #endregion
    }
}
