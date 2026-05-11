using MyClinic_1._0.src.features.forms.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinic_1._0.src.features.controls.admin
{
    public partial class AdminUsers : UserControl
    {
        private AdminLayout adminLayoutForm;
        public AdminUsers()
        {
            InitializeComponent();
            this.adminLayoutForm = new AdminLayout();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgAdminUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOpenUsersAddForm_Click(object sender, EventArgs e)
        {
            this.adminLayoutForm.showPage("new-user");
        }
    }
}
