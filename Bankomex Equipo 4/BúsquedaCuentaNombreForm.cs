using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomex_Equipo_4
{
    public partial class BúsquedaCuentaNombreForm : Form
    {
        private Admin admin;

        public BúsquedaCuentaNombreForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(txtClientName.Text);
            bool cond = true;

            if (admin.ValidateName(name, cond) == true)
            {
                cmbClient.DisplayMember = "ClientFullname";
                cmbClient.ValueMember = "Id";
                cmbClient.DataSource = admin.GetClientNames(name);
            }
            else
            {
                MessageBox.Show("¡Nombre de cliente inválido!",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                Close();
            }
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clientId = (int)cmbClient.SelectedValue;

            dgvBúsquedaCuentaNombre.DataSource = admin.GetAccountByClientId(clientId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
