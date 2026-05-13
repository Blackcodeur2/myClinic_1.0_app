using MyClinic_1._0.src.features.forms.medecin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinic_1._0.src.features.controls.medecin
{
    public partial class MedecinMedicaments : UserControl
    {
        public MedecinMedicaments()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddMedicamentForm addForm = new AddMedicamentForm();
            addForm.ShowDialog();
        }
    }
}
