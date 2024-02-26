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
    public partial class RetirosForm : Form
    {
        private Admin admin;
        public RetirosForm(Admin admin)
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
            btnRetirar.Enabled = true;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            bool cond = false;
            int accountId = (int)cmbBalance.SelectedValue;
            int retiro = Convert.ToInt32(txtAbono.Text);

            if (retiro > 0)
            {
                if (admin.ValidateAhorroAccount(accountId, cond) == true)
                {
                    cond = false;
                    if (admin.ValidateRetiroAhorro(accountId, retiro, cond) == true)
                    {
                        admin.Retiro(accountId, retiro);

                        MessageBox.Show("¡Retiro realizado con éxito!",
                                        "Aviso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("¡No se puede retirar una cantidad mayor al balance!",
                                        "Aviso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        Close();
                    }
                }
                else
                {
                    cond = false;

                    if(admin.ValidateOverDraft(accountId, retiro, cond) == true)
                    {
                        cond = false;

                        if (admin.ValidateOverDraftCondition(accountId, cond) == true)
                        {
                            admin.Depósito(accountId, retiro);

                            MessageBox.Show("¡Cuenta Sobregirada, retiro realizado con éxito!",
                                            "Aviso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("¡Esta operación va a sobregirar la cuenta, esta cuenta NO se puede sobregirar!",
                                        "Aviso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                            Close();
                        }
                    }
                    else
                    {
                        admin.Depósito(accountId, retiro);

                        MessageBox.Show("¡Retiro realizado con éxito!",
                                        "Aviso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
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
