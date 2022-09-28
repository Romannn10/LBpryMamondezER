namespace pryMamondezER
{
    partial class frmKaktus
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
            this.msVenKaktus = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msVenKaktus.SuspendLayout();
            this.SuspendLayout();
            // 
            // msVenKaktus
            // 
            this.msVenKaktus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.msVenKaktus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.msVenKaktus.Location = new System.Drawing.Point(0, 0);
            this.msVenKaktus.Name = "msVenKaktus";
            this.msVenKaktus.Size = new System.Drawing.Size(443, 27);
            this.msVenKaktus.TabIndex = 0;
            this.msVenKaktus.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClientesToolStripMenuItem,
            this.registrarVendedoresToolStripMenuItem,
            this.registrarVentasToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // registrarClientesToolStripMenuItem
            // 
            this.registrarClientesToolStripMenuItem.Name = "registrarClientesToolStripMenuItem";
            this.registrarClientesToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.registrarClientesToolStripMenuItem.Text = "Registrar Clientes";
            this.registrarClientesToolStripMenuItem.Click += new System.EventHandler(this.registrarClientesToolStripMenuItem_Click);
            // 
            // registrarVendedoresToolStripMenuItem
            // 
            this.registrarVendedoresToolStripMenuItem.Name = "registrarVendedoresToolStripMenuItem";
            this.registrarVendedoresToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.registrarVendedoresToolStripMenuItem.Text = "Registrar Vendedores";
            this.registrarVendedoresToolStripMenuItem.Click += new System.EventHandler(this.registrarVendedoresToolStripMenuItem_Click);
            // 
            // registrarVentasToolStripMenuItem
            // 
            this.registrarVentasToolStripMenuItem.Name = "registrarVentasToolStripMenuItem";
            this.registrarVentasToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.registrarVentasToolStripMenuItem.Text = "Registrar Ventas";
            this.registrarVentasToolStripMenuItem.Click += new System.EventHandler(this.registrarVentasToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaClientesToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // consultaClientesToolStripMenuItem
            // 
            this.consultaClientesToolStripMenuItem.Name = "consultaClientesToolStripMenuItem";
            this.consultaClientesToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.consultaClientesToolStripMenuItem.Text = "Consulta Clientes";
            this.consultaClientesToolStripMenuItem.Click += new System.EventHandler(this.consultaClientesToolStripMenuItem_Click);
            // 
            // frmKaktus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 302);
            this.Controls.Add(this.msVenKaktus);
            this.MainMenuStrip = this.msVenKaktus;
            this.Name = "frmKaktus";
            this.Text = " VenKaktus";
            this.Load += new System.EventHandler(this.frmKaktus_Load);
            this.msVenKaktus.ResumeLayout(false);
            this.msVenKaktus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msVenKaktus;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaClientesToolStripMenuItem;
    }
}

