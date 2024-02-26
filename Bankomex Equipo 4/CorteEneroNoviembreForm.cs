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
    public partial class CorteEneroNoviembreForm : Form
    {
        private Admin admin;
        public CorteEneroNoviembreForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void chkContinuar_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = chkContinuar.Checked; 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Cuentas de ahorro
            admin.CorteAccountAhorro();

            //Cuentas de credito
            admin.CorteMesAccountCredit();

            //Aplicar cuota si la cuenta esta sobregirada
            admin.CorteOverDraft();

            MessageBox.Show("¡Corte realizado con éxito!",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
