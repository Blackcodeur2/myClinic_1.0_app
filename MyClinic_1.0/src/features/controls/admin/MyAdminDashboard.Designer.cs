namespace MyClinic_1._0.src.features.controls.admin
{
    partial class MyAdminDashboard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Contrôles
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Label lblTitle;
        private TableLayoutPanel statsLayout;
        private Guna.UI2.WinForms.Guna2Panel cardUsers;
        private Label lblUsersCount;
        private Label lblUsersText;
        private Guna.UI2.WinForms.Guna2Panel cardSessions;
        private Label lblSessionsCount;
        private Label lblSessionsText;
        private Guna.UI2.WinForms.Guna2Panel cardRequests;
        private Label lblRequestsCount;
        private Label lblRequestsText;
        private FlowLayoutPanel actionsPanel;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnRoles;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Separator separator;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        #endregion

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            statsLayout = new TableLayoutPanel();
            cardUsers = new Guna.UI2.WinForms.Guna2Panel();
            lblUsersCount = new Label();
            lblUsersText = new Label();
            cardSessions = new Guna.UI2.WinForms.Guna2Panel();
            lblSessionsCount = new Label();
            lblSessionsText = new Label();
            cardRequests = new Guna.UI2.WinForms.Guna2Panel();
            lblRequestsCount = new Label();
            lblRequestsText = new Label();
            actionsPanel = new FlowLayoutPanel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            btnRoles = new Guna.UI2.WinForms.Guna2Button();
            btnSettings = new Guna.UI2.WinForms.Guna2Button();
            separator = new Guna.UI2.WinForms.Guna2Separator();
            dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            headerPanel.SuspendLayout();
            statsLayout.SuspendLayout();
            cardUsers.SuspendLayout();
            cardSessions.SuspendLayout();
            cardRequests.SuspendLayout();
            actionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblTitle);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.FillColor = Color.Transparent;
            headerPanel.Location = new Point(10, 10);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10);
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(1374, 64);
            headerPanel.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1354, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tableau de bord — Administration";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statsLayout
            // 
            statsLayout.ColumnCount = 3;
            statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            statsLayout.Controls.Add(cardUsers, 0, 0);
            statsLayout.Controls.Add(cardSessions, 1, 0);
            statsLayout.Controls.Add(cardRequests, 2, 0);
            statsLayout.Dock = DockStyle.Top;
            statsLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            statsLayout.Location = new Point(10, 74);
            statsLayout.Name = "statsLayout";
            statsLayout.Padding = new Padding(10);
            statsLayout.RowCount = 1;
            statsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            statsLayout.Size = new Size(1374, 120);
            statsLayout.TabIndex = 3;
            // 
            // cardUsers
            // 
            cardUsers.BorderRadius = 8;
            cardUsers.Controls.Add(lblUsersCount);
            cardUsers.Controls.Add(lblUsersText);
            cardUsers.CustomizableEdges = customizableEdges3;
            cardUsers.Dock = DockStyle.Fill;
            cardUsers.FillColor = Color.FromArgb(250, 250, 250);
            cardUsers.Location = new Point(13, 13);
            cardUsers.Name = "cardUsers";
            cardUsers.Padding = new Padding(12);
            cardUsers.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardUsers.Size = new Size(445, 94);
            cardUsers.TabIndex = 0;
            // 
            // lblUsersCount
            // 
            lblUsersCount.AutoSize = true;
            lblUsersCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUsersCount.ForeColor = Color.FromArgb(20, 140, 130);
            lblUsersCount.Location = new Point(12, 12);
            lblUsersCount.Name = "lblUsersCount";
            lblUsersCount.Size = new Size(40, 46);
            lblUsersCount.TabIndex = 0;
            lblUsersCount.Text = "0";
            // 
            // lblUsersText
            // 
            lblUsersText.AutoSize = true;
            lblUsersText.Font = new Font("Segoe UI", 10F);
            lblUsersText.ForeColor = Color.Gray;
            lblUsersText.Location = new Point(14, 52);
            lblUsersText.Name = "lblUsersText";
            lblUsersText.Size = new Size(94, 23);
            lblUsersText.TabIndex = 1;
            lblUsersText.Text = "Utilisateurs";
            // 
            // cardSessions
            // 
            cardSessions.BorderRadius = 8;
            cardSessions.Controls.Add(lblSessionsCount);
            cardSessions.Controls.Add(lblSessionsText);
            cardSessions.CustomizableEdges = customizableEdges5;
            cardSessions.Dock = DockStyle.Fill;
            cardSessions.FillColor = Color.FromArgb(250, 250, 250);
            cardSessions.Location = new Point(464, 13);
            cardSessions.Name = "cardSessions";
            cardSessions.Padding = new Padding(12);
            cardSessions.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cardSessions.Size = new Size(445, 94);
            cardSessions.TabIndex = 1;
            // 
            // lblSessionsCount
            // 
            lblSessionsCount.AutoSize = true;
            lblSessionsCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSessionsCount.ForeColor = Color.FromArgb(220, 80, 60);
            lblSessionsCount.Location = new Point(12, 12);
            lblSessionsCount.Name = "lblSessionsCount";
            lblSessionsCount.Size = new Size(40, 46);
            lblSessionsCount.TabIndex = 0;
            lblSessionsCount.Text = "0";
            // 
            // lblSessionsText
            // 
            lblSessionsText.AutoSize = true;
            lblSessionsText.Font = new Font("Segoe UI", 10F);
            lblSessionsText.ForeColor = Color.Gray;
            lblSessionsText.Location = new Point(14, 52);
            lblSessionsText.Name = "lblSessionsText";
            lblSessionsText.Size = new Size(129, 23);
            lblSessionsText.TabIndex = 1;
            lblSessionsText.Text = "Sessions actives";
            // 
            // cardRequests
            // 
            cardRequests.BorderRadius = 8;
            cardRequests.Controls.Add(lblRequestsCount);
            cardRequests.Controls.Add(lblRequestsText);
            cardRequests.CustomizableEdges = customizableEdges7;
            cardRequests.Dock = DockStyle.Fill;
            cardRequests.FillColor = Color.FromArgb(250, 250, 250);
            cardRequests.Location = new Point(915, 13);
            cardRequests.Name = "cardRequests";
            cardRequests.Padding = new Padding(12);
            cardRequests.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardRequests.Size = new Size(446, 94);
            cardRequests.TabIndex = 2;
            // 
            // lblRequestsCount
            // 
            lblRequestsCount.AutoSize = true;
            lblRequestsCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblRequestsCount.ForeColor = Color.FromArgb(90, 120, 230);
            lblRequestsCount.Location = new Point(12, 12);
            lblRequestsCount.Name = "lblRequestsCount";
            lblRequestsCount.Size = new Size(40, 46);
            lblRequestsCount.TabIndex = 0;
            lblRequestsCount.Text = "0";
            // 
            // lblRequestsText
            // 
            lblRequestsText.AutoSize = true;
            lblRequestsText.Font = new Font("Segoe UI", 10F);
            lblRequestsText.ForeColor = Color.Gray;
            lblRequestsText.Location = new Point(14, 52);
            lblRequestsText.Name = "lblRequestsText";
            lblRequestsText.Size = new Size(175, 23);
            lblRequestsText.TabIndex = 1;
            lblRequestsText.Text = "Demandes en attente";
            // 
            // actionsPanel
            // 
            actionsPanel.Controls.Add(txtSearch);
            actionsPanel.Controls.Add(btnRoles);
            actionsPanel.Controls.Add(btnAddUser);
            actionsPanel.Controls.Add(btnSettings);
            actionsPanel.Dock = DockStyle.Top;
            actionsPanel.FlowDirection = FlowDirection.RightToLeft;
            actionsPanel.Location = new Point(10, 194);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Padding = new Padding(10);
            actionsPanel.Size = new Size(1374, 89);
            actionsPanel.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(1028, 20);
            txtSearch.Margin = new Padding(6, 10, 6, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Rechercher un utilisateur...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.Size = new Size(320, 48);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // btnAddUser
            // 
            btnAddUser.AutoRoundedCorners = true;
            btnAddUser.BorderRadius = 26;
            btnAddUser.CustomizableEdges = customizableEdges13;
            btnAddUser.Font = new Font("Segoe UI", 9F);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(753, 13);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Padding = new Padding(10, 6, 10, 6);
            btnAddUser.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAddUser.Size = new Size(160, 55);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Ajouter utilisateur";
            btnAddUser.Click += BtnAddUser_Click;
            // 
            // btnRoles
            // 
            btnRoles.AutoRoundedCorners = true;
            btnRoles.BorderRadius = 26;
            btnRoles.CustomizableEdges = customizableEdges11;
            btnRoles.Font = new Font("Segoe UI", 9F);
            btnRoles.ForeColor = Color.White;
            btnRoles.Location = new Point(919, 13);
            btnRoles.Name = "btnRoles";
            btnRoles.Padding = new Padding(10, 6, 10, 6);
            btnRoles.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnRoles.Size = new Size(100, 55);
            btnRoles.TabIndex = 2;
            btnRoles.Text = "Rôles";
            btnRoles.Click += BtnRoles_Click;
            // 
            // btnSettings
            // 
            btnSettings.AutoRoundedCorners = true;
            btnSettings.BorderRadius = 26;
            btnSettings.CustomizableEdges = customizableEdges15;
            btnSettings.Font = new Font("Segoe UI", 9F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(627, 13);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 6, 10, 6);
            btnSettings.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnSettings.Size = new Size(120, 55);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Paramètres";
            btnSettings.Click += BtnSettings_Click;
            // 
            // separator
            // 
            separator.Dock = DockStyle.Top;
            separator.FillColor = Color.FromArgb(230, 230, 230);
            separator.Location = new Point(10, 283);
            separator.Name = "separator";
            separator.Size = new Size(1374, 10);
            separator.TabIndex = 1;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 45;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.GridColor = Color.FromArgb(231, 229, 255);
            dgvUsers.Location = new Point(10, 293);
            dgvUsers.Margin = new Padding(10);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(1374, 345);
            dgvUsers.TabIndex = 0;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUsers.ThemeStyle.BackColor = Color.White;
            dgvUsers.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUsers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvUsers.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(60, 60, 60);
            dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.ThemeStyle.HeaderStyle.Height = 45;
            dgvUsers.ThemeStyle.ReadOnly = true;
            dgvUsers.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUsers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUsers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUsers.ThemeStyle.RowsStyle.Height = 31;
            dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvUsers.DoubleClick += DgvUsers_DoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nom d'utilisateur";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Rôle";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Dernière connexion";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // MyAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvUsers);
            Controls.Add(separator);
            Controls.Add(actionsPanel);
            Controls.Add(statsLayout);
            Controls.Add(headerPanel);
            Name = "MyAdminDashboard";
            Padding = new Padding(10);
            Size = new Size(1394, 648);
            headerPanel.ResumeLayout(false);
            statsLayout.ResumeLayout(false);
            cardUsers.ResumeLayout(false);
            cardUsers.PerformLayout();
            cardSessions.ResumeLayout(false);
            cardSessions.PerformLayout();
            cardRequests.ResumeLayout(false);
            cardRequests.PerformLayout();
            actionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
