
namespace Bankomex_Equipo_4
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreCompletoOParcialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.idCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreCompletoOParcialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depósitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eneroNoviembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diciembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.búsquedaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // búsquedaToolStripMenuItem
            // 
            this.búsquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripMenuItem,
            this.nombreCompletoOParcialToolStripMenuItem});
            this.búsquedaToolStripMenuItem.Name = "búsquedaToolStripMenuItem";
            this.búsquedaToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.búsquedaToolStripMenuItem.Text = "Búsqueda";
            // 
            // idToolStripMenuItem
            // 
            this.idToolStripMenuItem.Name = "idToolStripMenuItem";
            this.idToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.idToolStripMenuItem.Text = "Id Cliente";
            this.idToolStripMenuItem.Click += new System.EventHandler(this.idToolStripMenuItem_Click);
            // 
            // nombreCompletoOParcialToolStripMenuItem
            // 
            this.nombreCompletoOParcialToolStripMenuItem.Name = "nombreCompletoOParcialToolStripMenuItem";
            this.nombreCompletoOParcialToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.nombreCompletoOParcialToolStripMenuItem.Text = "Nombre completo o parcial";
            this.nombreCompletoOParcialToolStripMenuItem.Click += new System.EventHandler(this.nombreCompletoOParcialToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.búsquedaToolStripMenuItem1});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(141, 28);
            this.altaToolStripMenuItem1.Text = "Alta";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // búsquedaToolStripMenuItem1
            // 
            this.búsquedaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idCuentaToolStripMenuItem,
            this.idClienteToolStripMenuItem,
            this.nombreCompletoOParcialToolStripMenuItem1});
            this.búsquedaToolStripMenuItem1.Name = "búsquedaToolStripMenuItem1";
            this.búsquedaToolStripMenuItem1.Size = new System.Drawing.Size(141, 28);
            this.búsquedaToolStripMenuItem1.Text = "Búsqueda";
            // 
            // idCuentaToolStripMenuItem
            // 
            this.idCuentaToolStripMenuItem.Name = "idCuentaToolStripMenuItem";
            this.idCuentaToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.idCuentaToolStripMenuItem.Text = "Id Cuenta";
            this.idCuentaToolStripMenuItem.Click += new System.EventHandler(this.idCuentaToolStripMenuItem_Click);
            // 
            // idClienteToolStripMenuItem
            // 
            this.idClienteToolStripMenuItem.Name = "idClienteToolStripMenuItem";
            this.idClienteToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.idClienteToolStripMenuItem.Text = "Id Cliente";
            this.idClienteToolStripMenuItem.Click += new System.EventHandler(this.idClienteToolStripMenuItem_Click);
            // 
            // nombreCompletoOParcialToolStripMenuItem1
            // 
            this.nombreCompletoOParcialToolStripMenuItem1.Name = "nombreCompletoOParcialToolStripMenuItem1";
            this.nombreCompletoOParcialToolStripMenuItem1.Size = new System.Drawing.Size(253, 28);
            this.nombreCompletoOParcialToolStripMenuItem1.Text = "Nombre completo o parcial";
            this.nombreCompletoOParcialToolStripMenuItem1.Click += new System.EventHandler(this.nombreCompletoOParcialToolStripMenuItem1_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depósitosToolStripMenuItem,
            this.retirosToolStripMenuItem,
            this.corteToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // depósitosToolStripMenuItem
            // 
            this.depósitosToolStripMenuItem.Name = "depósitosToolStripMenuItem";
            this.depósitosToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.depósitosToolStripMenuItem.Text = "Depósitos";
            this.depósitosToolStripMenuItem.Click += new System.EventHandler(this.depósitosToolStripMenuItem_Click);
            // 
            // retirosToolStripMenuItem
            // 
            this.retirosToolStripMenuItem.Name = "retirosToolStripMenuItem";
            this.retirosToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.retirosToolStripMenuItem.Text = "Retiros";
            this.retirosToolStripMenuItem.Click += new System.EventHandler(this.retirosToolStripMenuItem_Click);
            // 
            // corteToolStripMenuItem
            // 
            this.corteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eneroNoviembreToolStripMenuItem,
            this.diciembreToolStripMenuItem});
            this.corteToolStripMenuItem.Name = "corteToolStripMenuItem";
            this.corteToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.corteToolStripMenuItem.Text = "Corte";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(61, 27);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Enabled = false;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // eneroNoviembreToolStripMenuItem
            // 
            this.eneroNoviembreToolStripMenuItem.Name = "eneroNoviembreToolStripMenuItem";
            this.eneroNoviembreToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.eneroNoviembreToolStripMenuItem.Text = "Enero - Noviembre";
            this.eneroNoviembreToolStripMenuItem.Click += new System.EventHandler(this.eneroNoviembreToolStripMenuItem_Click);
            // 
            // diciembreToolStripMenuItem
            // 
            this.diciembreToolStripMenuItem.Name = "diciembreToolStripMenuItem";
            this.diciembreToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.diciembreToolStripMenuItem.Text = "Diciembre";
            this.diciembreToolStripMenuItem.Click += new System.EventHandler(this.diciembreToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 240);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankomex v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreCompletoOParcialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem idClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreCompletoOParcialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depósitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eneroNoviembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diciembreToolStripMenuItem;
    }
}

