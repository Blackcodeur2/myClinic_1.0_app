namespace MyClinic_1._0.src.features.controls.medecin
{
    partial class MedecinDashboard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Contrôles

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Label lblTitle;
        private TableLayoutPanel statsLayout;
        private Guna.UI2.WinForms.Guna2Panel cardPatients;
        private Label lblPatientsCount;
        private Label lblPatientsText;
        private Guna.UI2.WinForms.Guna2Panel cardConsults;
        private Label lblConsultsCount;
        private Label lblConsultsText;
        private Guna.UI2.WinForms.Guna2Panel cardRendezvous;
        private Label lblRdvCount;
        private Label lblRdvText;
        private Guna.UI2.WinForms.Guna2Separator separator;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecentConsultations;
        private FlowLayoutPanel actionsPanel;
        private Guna.UI2.WinForms.Guna2Button btnNewConsultation;
        private Guna.UI2.WinForms.Guna2Button btnPrescrire;
        private Guna.UI2.WinForms.Guna2Button btnPatients;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            statsLayout = new TableLayoutPanel();
            cardPatients = new Guna.UI2.WinForms.Guna2Panel();
            lblPatientsCount = new Label();
            lblPatientsText = new Label();
            cardConsults = new Guna.UI2.WinForms.Guna2Panel();
            lblConsultsCount = new Label();
            lblConsultsText = new Label();
            cardRendezvous = new Guna.UI2.WinForms.Guna2Panel();
            lblRdvCount = new Label();
            lblRdvText = new Label();
            separator = new Guna.UI2.WinForms.Guna2Separator();
            dgvRecentConsultations = new Guna.UI2.WinForms.Guna2DataGridView();
            actionsPanel = new FlowLayoutPanel();
            btnNewConsultation = new Guna.UI2.WinForms.Guna2Button();
            btnPrescrire = new Guna.UI2.WinForms.Guna2Button();
            btnPatients = new Guna.UI2.WinForms.Guna2Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            headerPanel.SuspendLayout();
            statsLayout.SuspendLayout();
            cardPatients.SuspendLayout();
            cardConsults.SuspendLayout();
            cardRendezvous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentConsultations).BeginInit();
            actionsPanel.SuspendLayout();
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
            headerPanel.Size = new Size(1410, 70);
            headerPanel.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1390, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tableau de bord — Médecin";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statsLayout
            // 
            statsLayout.ColumnCount = 3;
            statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            statsLayout.Controls.Add(cardPatients, 0, 0);
            statsLayout.Controls.Add(cardConsults, 1, 0);
            statsLayout.Controls.Add(cardRendezvous, 2, 0);
            statsLayout.Dock = DockStyle.Top;
            statsLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            statsLayout.Location = new Point(10, 80);
            statsLayout.Name = "statsLayout";
            statsLayout.Padding = new Padding(10);
            statsLayout.RowCount = 1;
            statsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            statsLayout.Size = new Size(1410, 120);
            statsLayout.TabIndex = 3;
            // 
            // cardPatients
            // 
            cardPatients.BorderRadius = 8;
            cardPatients.Controls.Add(lblPatientsCount);
            cardPatients.Controls.Add(lblPatientsText);
            cardPatients.CustomizableEdges = customizableEdges3;
            cardPatients.Dock = DockStyle.Fill;
            cardPatients.FillColor = Color.FromArgb(250, 250, 250);
            cardPatients.Location = new Point(13, 13);
            cardPatients.Name = "cardPatients";
            cardPatients.Padding = new Padding(12);
            cardPatients.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardPatients.Size = new Size(457, 94);
            cardPatients.TabIndex = 0;
            // 
            // lblPatientsCount
            // 
            lblPatientsCount.AutoSize = true;
            lblPatientsCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPatientsCount.ForeColor = Color.FromArgb(20, 140, 130);
            lblPatientsCount.Location = new Point(12, 12);
            lblPatientsCount.Name = "lblPatientsCount";
            lblPatientsCount.Size = new Size(40, 46);
            lblPatientsCount.TabIndex = 0;
            lblPatientsCount.Text = "0";
            // 
            // lblPatientsText
            // 
            lblPatientsText.AutoSize = true;
            lblPatientsText.Font = new Font("Segoe UI", 10F);
            lblPatientsText.ForeColor = Color.Gray;
            lblPatientsText.Location = new Point(14, 52);
            lblPatientsText.Name = "lblPatientsText";
            lblPatientsText.Size = new Size(115, 23);
            lblPatientsText.TabIndex = 1;
            lblPatientsText.Text = "Patients suivis";
            // 
            // cardConsults
            // 
            cardConsults.BorderRadius = 8;
            cardConsults.Controls.Add(lblConsultsCount);
            cardConsults.Controls.Add(lblConsultsText);
            cardConsults.CustomizableEdges = customizableEdges5;
            cardConsults.Dock = DockStyle.Fill;
            cardConsults.FillColor = Color.FromArgb(250, 250, 250);
            cardConsults.Location = new Point(476, 13);
            cardConsults.Name = "cardConsults";
            cardConsults.Padding = new Padding(12);
            cardConsults.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cardConsults.Size = new Size(457, 94);
            cardConsults.TabIndex = 1;
            // 
            // lblConsultsCount
            // 
            lblConsultsCount.AutoSize = true;
            lblConsultsCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblConsultsCount.ForeColor = Color.FromArgb(220, 80, 60);
            lblConsultsCount.Location = new Point(12, 12);
            lblConsultsCount.Name = "lblConsultsCount";
            lblConsultsCount.Size = new Size(40, 46);
            lblConsultsCount.TabIndex = 0;
            lblConsultsCount.Text = "0";
            // 
            // lblConsultsText
            // 
            lblConsultsText.AutoSize = true;
            lblConsultsText.Font = new Font("Segoe UI", 10F);
            lblConsultsText.ForeColor = Color.Gray;
            lblConsultsText.Location = new Point(14, 52);
            lblConsultsText.Name = "lblConsultsText";
            lblConsultsText.Size = new Size(206, 23);
            lblConsultsText.TabIndex = 1;
            lblConsultsText.Text = "Consultations aujourd'hui";
            // 
            // cardRendezvous
            // 
            cardRendezvous.BorderRadius = 8;
            cardRendezvous.Controls.Add(lblRdvCount);
            cardRendezvous.Controls.Add(lblRdvText);
            cardRendezvous.CustomizableEdges = customizableEdges7;
            cardRendezvous.Dock = DockStyle.Fill;
            cardRendezvous.FillColor = Color.FromArgb(250, 250, 250);
            cardRendezvous.Location = new Point(939, 13);
            cardRendezvous.Name = "cardRendezvous";
            cardRendezvous.Padding = new Padding(12);
            cardRendezvous.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardRendezvous.Size = new Size(458, 94);
            cardRendezvous.TabIndex = 2;
            // 
            // lblRdvCount
            // 
            lblRdvCount.AutoSize = true;
            lblRdvCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblRdvCount.ForeColor = Color.FromArgb(90, 120, 230);
            lblRdvCount.Location = new Point(12, 12);
            lblRdvCount.Name = "lblRdvCount";
            lblRdvCount.Size = new Size(40, 46);
            lblRdvCount.TabIndex = 0;
            lblRdvCount.Text = "0";
            // 
            // lblRdvText
            // 
            lblRdvText.AutoSize = true;
            lblRdvText.Font = new Font("Segoe UI", 10F);
            lblRdvText.ForeColor = Color.Gray;
            lblRdvText.Location = new Point(14, 52);
            lblRdvText.Name = "lblRdvText";
            lblRdvText.Size = new Size(108, 23);
            lblRdvText.TabIndex = 1;
            lblRdvText.Text = "Rendez-vous";
            // 
            // separator
            // 
            separator.Dock = DockStyle.Top;
            separator.FillColor = Color.FromArgb(230, 230, 230);
            separator.Location = new Point(10, 288);
            separator.Name = "separator";
            separator.Size = new Size(1410, 10);
            separator.TabIndex = 1;
            // 
            // dgvRecentConsultations
            // 
            dgvRecentConsultations.AllowUserToAddRows = false;
            dgvRecentConsultations.AllowUserToDeleteRows = false;
            dgvRecentConsultations.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRecentConsultations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRecentConsultations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentConsultations.ColumnHeadersHeight = 45;
            dgvRecentConsultations.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRecentConsultations.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRecentConsultations.Dock = DockStyle.Fill;
            dgvRecentConsultations.GridColor = Color.FromArgb(231, 229, 255);
            dgvRecentConsultations.Location = new Point(10, 298);
            dgvRecentConsultations.Margin = new Padding(10);
            dgvRecentConsultations.Name = "dgvRecentConsultations";
            dgvRecentConsultations.ReadOnly = true;
            dgvRecentConsultations.RowHeadersVisible = false;
            dgvRecentConsultations.RowHeadersWidth = 51;
            dgvRecentConsultations.Size = new Size(1410, 403);
            dgvRecentConsultations.TabIndex = 0;
            dgvRecentConsultations.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRecentConsultations.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRecentConsultations.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvRecentConsultations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvRecentConsultations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvRecentConsultations.ThemeStyle.BackColor = Color.White;
            dgvRecentConsultations.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvRecentConsultations.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvRecentConsultations.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecentConsultations.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvRecentConsultations.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(60, 60, 60);
            dgvRecentConsultations.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecentConsultations.ThemeStyle.HeaderStyle.Height = 45;
            dgvRecentConsultations.ThemeStyle.ReadOnly = true;
            dgvRecentConsultations.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvRecentConsultations.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecentConsultations.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvRecentConsultations.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvRecentConsultations.ThemeStyle.RowsStyle.Height = 31;
            dgvRecentConsultations.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvRecentConsultations.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // actionsPanel
            // 
            actionsPanel.Controls.Add(btnNewConsultation);
            actionsPanel.Controls.Add(btnPrescrire);
            actionsPanel.Controls.Add(btnPatients);
            actionsPanel.Dock = DockStyle.Top;
            actionsPanel.Location = new Point(10, 200);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Padding = new Padding(10);
            actionsPanel.Size = new Size(1410, 88);
            actionsPanel.TabIndex = 2;
            // 
            // btnNewConsultation
            // 
            btnNewConsultation.AutoRoundedCorners = true;
            btnNewConsultation.BorderRadius = 26;
            btnNewConsultation.CustomizableEdges = customizableEdges9;
            btnNewConsultation.Font = new Font("Segoe UI", 9F);
            btnNewConsultation.ForeColor = Color.White;
            btnNewConsultation.Location = new Point(13, 13);
            btnNewConsultation.Name = "btnNewConsultation";
            btnNewConsultation.Padding = new Padding(10, 6, 10, 6);
            btnNewConsultation.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnNewConsultation.Size = new Size(180, 54);
            btnNewConsultation.TabIndex = 0;
            btnNewConsultation.Text = "Nouvelle consultation";
            btnNewConsultation.Click += BtnNewConsultation_Click;
            // 
            // btnPrescrire
            // 
            btnPrescrire.AutoRoundedCorners = true;
            btnPrescrire.BorderRadius = 26;
            btnPrescrire.CustomizableEdges = customizableEdges11;
            btnPrescrire.Font = new Font("Segoe UI", 9F);
            btnPrescrire.ForeColor = Color.White;
            btnPrescrire.Location = new Point(199, 13);
            btnPrescrire.Name = "btnPrescrire";
            btnPrescrire.Padding = new Padding(10, 6, 10, 6);
            btnPrescrire.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnPrescrire.Size = new Size(120, 54);
            btnPrescrire.TabIndex = 1;
            btnPrescrire.Text = "Prescrire";
            btnPrescrire.Click += BtnPrescrire_Click;
            // 
            // btnPatients
            // 
            btnPatients.AutoRoundedCorners = true;
            btnPatients.BorderRadius = 26;
            btnPatients.CustomizableEdges = customizableEdges13;
            btnPatients.Font = new Font("Segoe UI", 9F);
            btnPatients.ForeColor = Color.White;
            btnPatients.Location = new Point(325, 13);
            btnPatients.Name = "btnPatients";
            btnPatients.Padding = new Padding(10, 6, 10, 6);
            btnPatients.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnPatients.Size = new Size(120, 54);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "Mes patients";
            btnPatients.Click += BtnPatients_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Patient";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Date";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Motif";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // MedecinDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvRecentConsultations);
            Controls.Add(separator);
            Controls.Add(actionsPanel);
            Controls.Add(statsLayout);
            Controls.Add(headerPanel);
            Name = "MedecinDashboard";
            Padding = new Padding(10);
            Size = new Size(1430, 711);
            headerPanel.ResumeLayout(false);
            statsLayout.ResumeLayout(false);
            cardPatients.ResumeLayout(false);
            cardPatients.PerformLayout();
            cardConsults.ResumeLayout(false);
            cardConsults.PerformLayout();
            cardRendezvous.ResumeLayout(false);
            cardRendezvous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentConsultations).EndInit();
            actionsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
