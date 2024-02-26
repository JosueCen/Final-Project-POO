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
    public partial class AltaCuentaForm : Form
    {
        private Admin admin;
        public AltaCuentaForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            cmbAccountTypes.DisplayMember = "AccountType";
            cmbAccountTypes.ValueMember = "Id";
            cmbAccountTypes.DataSource = admin.GetAccountTypes();
        }

        private void cmbAccountTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool cond = false;
            int clientid = Convert.ToInt32(txtClientId.Text);
            int accountType = (int)cmbAccountTypes.SelectedValue;

            if (admin.ValidateAccountType(clientid, accountType, cond) == true)
            {
                admin.AltaCuenta(clientid, accountType);

                MessageBox.Show("¡Cuenta dada de alta con éxito!",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("¡El ciente ya tiene este tipo de cuenta!",
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
