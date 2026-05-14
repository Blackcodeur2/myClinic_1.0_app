using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinic_1._0.src.features.forms.splash
{
    public partial class SplashView : Form
    {
        public SplashView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Démarrer invisible pour un fade-in
            this.Opacity = 0D;

            // Valeurs initiales UI
            myProgressBar.Value = 0;
            if (labelPercent != null)
            {
                labelPercent.Text = "0%";
            }
        }

        private void SplashView_Load(object sender, EventArgs e)
        {
            // Lancer l'animation d'apparition puis le timer de progression
            fadeTimer.Start();
            progressTimer.Start();
        }

        private void guna2ContainerControl3_Click(object sender, EventArgs e)
        {

        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            // Incrémenter la barre de progression de façon sûre et mettre à jour le label pourcentage
            var next = myProgressBar.Value + 2;
            if (next > myProgressBar.Maximum) next = myProgressBar.Maximum;
            myProgressBar.Value = next;

            if (labelPercent != null)
            {
                labelPercent.Text = $"{myProgressBar.Value}%";
            }

            if (myProgressBar.Value >= myProgressBar.Maximum)
            {
                progressTimer.Stop();
                // Démarrer le fade-out avant de fermer
                fadeOutTimer.Start();
            }
        }

        private void myProgressBar_ValueChanged(object sender, EventArgs e)
        {
            if (labelPercent != null)
            {
                labelPercent.Text = $"{myProgressBar.Value}%";
            }
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            // Fade-in : augmenter l'opacité jusqu'à 1.0
            if (this.Opacity < 1.0D)
            {
                this.Opacity = Math.Min(1.0D, this.Opacity + 0.08D);
            }
            else
            {
                fadeTimer.Stop();
            }
        }

        private void fadeOutTimer_Tick(object sender, EventArgs e)
        {
            // Fade-out : réduire l'opacité puis fermer en renvoyant OK
            if (this.Opacity > 0.0D)
            {
                this.Opacity = Math.Max(0.0D, this.Opacity - 0.08D);
            }
            else
            {
                fadeOutTimer.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
