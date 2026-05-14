namespace MyClinic_1._0.src.features.controls.shared
{
    partial class MyUserProfile
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Label lblName;
        private Label lblRole;
        private Label lblEmail;
        private Label lblPhone;
        private Guna.UI2.WinForms.Guna2Button btnEditProfile;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private TableLayoutPanel detailsLayout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            detailsLayout = new TableLayoutPanel();
            lblName = new Label();
            buttonsPanel = new FlowLayoutPanel();
            btnEditProfile = new Guna.UI2.WinForms.Guna2Button();
            btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            lblRole = new Label();
            contactPanel = new FlowLayoutPanel();
            lblEmail = new Label();
            lblPhone = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            detailsLayout.SuspendLayout();
            buttonsPanel.SuspendLayout();
            contactPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(picAvatar);
            mainPanel.Controls.Add(detailsLayout);
            mainPanel.CustomizableEdges = customizableEdges8;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.FillColor = Color.White;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(16);
            mainPanel.ShadowDecoration.CustomizableEdges = customizableEdges9;
            mainPanel.Size = new Size(1010, 412);
            mainPanel.TabIndex = 0;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.ImageRotate = 0F;
            picAvatar.Location = new Point(24, 24);
            picAvatar.Name = "picAvatar";
            picAvatar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            picAvatar.ShadowDecoration.Enabled = true;
            picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            picAvatar.Size = new Size(120, 120);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // detailsLayout
            // 
            detailsLayout.ColumnCount = 2;
            detailsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            detailsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            detailsLayout.Controls.Add(lblName, 0, 0);
            detailsLayout.Controls.Add(buttonsPanel, 1, 0);
            detailsLayout.Controls.Add(lblRole, 0, 1);
            detailsLayout.Controls.Add(contactPanel, 0, 2);
            detailsLayout.Location = new Point(160, 16);
            detailsLayout.Name = "detailsLayout";
            detailsLayout.Padding = new Padding(8);
            detailsLayout.RowCount = 3;
            detailsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            detailsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            detailsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            detailsLayout.Size = new Size(831, 377);
            detailsLayout.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(30, 30, 30);
            lblName.Location = new Point(11, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(523, 120);
            lblName.TabIndex = 0;
            lblName.Text = "Nom complet";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnEditProfile);
            buttonsPanel.Controls.Add(btnChangePassword);
            buttonsPanel.Controls.Add(btnLogout);
            buttonsPanel.Location = new Point(540, 11);
            buttonsPanel.Name = "buttonsPanel";
            detailsLayout.SetRowSpan(buttonsPanel, 3);
            buttonsPanel.Size = new Size(279, 226);
            buttonsPanel.TabIndex = 1;
            // 
            // btnEditProfile
            // 
            btnEditProfile.AutoRoundedCorners = true;
            btnEditProfile.BorderRadius = 16;
            btnEditProfile.CustomizableEdges = customizableEdges2;
            btnEditProfile.FillColor = Color.FromArgb(45, 125, 220);
            btnEditProfile.Font = new Font("Segoe UI", 9F);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(3, 3);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnEditProfile.Size = new Size(191, 34);
            btnEditProfile.TabIndex = 0;
            btnEditProfile.Text = "Modifier";
            btnEditProfile.Click += BtnEditProfile_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.AutoRoundedCorners = true;
            btnChangePassword.BorderRadius = 16;
            btnChangePassword.CustomizableEdges = customizableEdges4;
            btnChangePassword.FillColor = Color.FromArgb(20, 140, 130);
            btnChangePassword.Font = new Font("Segoe UI", 9F);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(3, 43);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnChangePassword.Size = new Size(191, 34);
            btnChangePassword.TabIndex = 1;
            btnChangePassword.Text = "Changer mdp";
            btnChangePassword.Click += BtnChangePassword_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoRoundedCorners = true;
            btnLogout.BorderRadius = 16;
            btnLogout.CustomizableEdges = customizableEdges6;
            btnLogout.FillColor = Color.FromArgb(220, 80, 60);
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(3, 83);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnLogout.Size = new Size(191, 34);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Déconnexion";
            btnLogout.Click += BtnLogout_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Fill;
            lblRole.Font = new Font("Segoe UI", 10F);
            lblRole.ForeColor = Color.Gray;
            lblRole.Location = new Point(11, 128);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(523, 120);
            lblRole.TabIndex = 2;
            lblRole.Text = "Rôle";
            lblRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contactPanel
            // 
            contactPanel.Controls.Add(lblEmail);
            contactPanel.Controls.Add(lblPhone);
            contactPanel.Location = new Point(11, 251);
            contactPanel.Name = "contactPanel";
            contactPanel.Size = new Size(200, 100);
            contactPanel.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.FromArgb(60, 60, 60);
            lblEmail.Location = new Point(3, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(149, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "email@exemple.com";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 9F);
            lblPhone.ForeColor = Color.FromArgb(60, 60, 60);
            lblPhone.Location = new Point(3, 20);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(123, 20);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "+229 00 00 00 00";
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MyUserProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainPanel);
            Name = "MyUserProfile";
            Size = new Size(1010, 412);
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            detailsLayout.ResumeLayout(false);
            detailsLayout.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            contactPanel.ResumeLayout(false);
            contactPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel buttonsPanel;
        private FlowLayoutPanel contactPanel;
    }
}