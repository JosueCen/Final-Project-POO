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
    public partial class DepósitosForm : Form
    {
        private Admin admin;

        public DepósitosForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            bool cond = false;
            int accountId = Convert.ToInt32(txtAccountId.Text);

            if (admin.ValidateAccountId(accountId, cond) == true)
            {
                cmbBalance.DisplayMember = "Balance";
                cmbBalance.ValueMember = "Id";
                cmbBalance.DataSource = admin.GetBalance(accountId);
            }
            else
            {
                MessageBox.Show("¡El ID de cuenta no es válido!",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                Close();
            }
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            btnDepositar.Enabled = true;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            bool cond = false; 
            int accountId = (int)cmbBalance.SelectedValue;
            int abono = Convert.ToInt32(txtAbono.Text);

            if (abono > 0)
            {
                if (admin.ValidateAhorroAccount(accountId, cond) == true)
                {
                    admin.Depósito(accountId, abono);

                    MessageBox.Show("¡Depósito realizado con éxito!",
                                        "Aviso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    if (admin.ValidateDepósito(accountId, abono, cond) == true)
                    {
                        admin.Retiro(accountId, abono);

                        MessageBox.Show("¡Depósito realizado con éxito!",
                                            "Aviso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("¡No se puede depositar una cantidad mayor al balance!",
                                        "Aviso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Cantidad inválida, ingrese número mayor a 0!",
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
