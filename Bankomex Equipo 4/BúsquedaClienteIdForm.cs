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
    public partial class BúsquedaClienteIdForm : Form
    {
        private Admin admin;

        public BúsquedaClienteIdForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(txtClientId.Text);
            bool cond = false;
            
            if(admin.ValidateClientId(clientId, cond) == true)
            {
                dgvBúsquedaClienteId.DataSource = admin.GetClientsById(clientId);
            }
            else
            {
                MessageBox.Show("¡ID de cliente inválido!",
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
