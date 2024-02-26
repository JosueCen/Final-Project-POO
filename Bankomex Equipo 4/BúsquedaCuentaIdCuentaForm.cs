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
    public partial class BúsquedaCuentaIdCuentaForm : Form
    {
        private Admin admin;

        public BúsquedaCuentaIdCuentaForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int accountId = Convert.ToInt32(txtAccountId.Text);
            bool cond = false;

            if (admin.ValidateAccountId(accountId, cond) == true)
            {
                cmbClient.DisplayMember = "ClientFullName";
                cmbClient.DataSource = admin.GetClientByAccountId(accountId);
                dgvBúsquedaCuentaIdCuenta.DataSource = admin.GetAccountByAccountId(accountId);
            }
            else
            {
                MessageBox.Show("¡ID de cuenta inválido!",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                Close();
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
