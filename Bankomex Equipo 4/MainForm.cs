using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace Bankomex_Equipo_4
{    
    public partial class MainForm : Form
    {
        private Admin admin;

        public MainForm()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin.Close();
            Close();
        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BúsquedaClienteIdForm form = new BúsquedaClienteIdForm(admin);
            form.ShowDialog();
        }

        private void nombreCompletoOParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BúsquedaClienteNombreForm form = new BúsquedaClienteNombreForm(admin);
            form.ShowDialog();
        }

        private void idCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BúsquedaCuentaIdCuentaForm form = new BúsquedaCuentaIdCuentaForm(admin);
            form.ShowDialog();
        }

        private void idClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BúsquedaCuentaIdClienteForm form = new BúsquedaCuentaIdClienteForm(admin);
            form.ShowDialog();
        }

        private void nombreCompletoOParcialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BúsquedaCuentaNombreForm form = new BúsquedaCuentaNombreForm(admin);
            form.ShowDialog();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaClienteForm form = new AltaClienteForm(admin);
            form.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaCuentaForm form = new AltaCuentaForm(admin);
            form.ShowDialog();
        }

        private void depósitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepósitosForm form = new DepósitosForm(admin);
            form.ShowDialog();
        }

        private void retirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetirosForm form = new RetirosForm(admin);
            form.ShowDialog();
        }

        private void eneroNoviembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorteEneroNoviembreForm form = new CorteEneroNoviembreForm(admin);
            form.ShowDialog();
        }

        private void diciembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorteDiciembreForm form = new CorteDiciembreForm(admin);
            form.ShowDialog();
        }
    }
}
