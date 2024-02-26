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
    public partial class AltaClienteForm : Form
    {
        private Admin admin;

        public AltaClienteForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool cond = false;
            string username = Convert.ToString(txtUsername.Text);
            int pin = Convert.ToInt32(txtPin.Text);

            string firstName = Convert.ToString(txtFirstName.Text);
            firstName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstName);

            string lastName = Convert.ToString(txtLastName.Text);
            lastName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastName);

            int digitspin = (int)Math.Floor(Math.Log10(pin) + 1);
            if (digitspin == 4)
            {
                if (admin.ValidateUsername(username, cond) == true)
                {
                    admin.AltaCliente(username, pin, firstName, lastName);

                    MessageBox.Show("¡Cliente dado de alta con éxito!",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡Este nombre de usuario ya está en uso!",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("¡PIN no válido, ingrese un número de cuatro dígitos!",
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
