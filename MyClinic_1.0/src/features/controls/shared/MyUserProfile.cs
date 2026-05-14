using System;
using System.Drawing;
using System.Windows.Forms;
using MyClinic_1._0.src.features.forms.auth;

namespace MyClinic_1._0.src.features.controls.shared
{
    public partial class MyUserProfile : UserControl
    {
        public event EventHandler? LogoutRequested;

        public MyUserProfile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge les informations du profil dans l'interface.
        /// Avatar peut être null : une image par défaut sera utilisée.
        /// </summary>
        public void LoadProfile(string fullName, string role, string email, string phone, Image? avatar = null)
        {
            lblName.Text = string.IsNullOrWhiteSpace(fullName) ? "Utilisateur" : fullName;
            lblRole.Text = string.IsNullOrWhiteSpace(role) ? "-" : role;
            lblEmail.Text = string.IsNullOrWhiteSpace(email) ? "-" : email;
            lblPhone.Text = string.IsNullOrWhiteSpace(phone) ? "-" : phone;

            if (avatar != null)
            {
                picAvatar.Image = avatar;
            }
            else
            {
                // Petite icône par défaut : utiliser une ressource si disponible
                picAvatar.Image = SystemIcons.Application.ToBitmap();
            }
        }

        private void BtnEditProfile_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Ouvrir l'édition du profil (à implémenter).", "Profil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnChangePassword_Click(object? sender, EventArgs e)
        {
            // ouvre le formulaire de changement de mot de passe existant
            using var dlg = new ChangePassword();
            dlg.ShowDialog();
        }

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            // Prévenir l'hôte (form) qu'une déconnexion est demandée
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
