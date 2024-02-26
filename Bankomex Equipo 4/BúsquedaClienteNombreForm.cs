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
    public partial class BúsquedaClienteNombreForm : Form
    {
        private Admin admin;

        public BúsquedaClienteNombreForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(txtClientName.Text);
            bool cond = true;

            if (admin.ValidateName(name, cond) == true)
            {
                dgvClientesPorNombre.DataSource = admin.GetClientsNames(name);
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

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
