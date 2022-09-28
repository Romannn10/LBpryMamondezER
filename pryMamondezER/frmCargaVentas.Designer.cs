namespace pryMamondezER
{
    partial class frmCargaVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClienteVenta = new System.Windows.Forms.Label();
            this.lblVendedorVenta = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIngreseDatosVenta = new System.Windows.Forms.Label();
            this.lstCliente = new System.Windows.Forms.ComboBox();
            this.lstVendedor = new System.Windows.Forms.ComboBox();
            this.txtNFactura = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmdCargaVenta = new System.Windows.Forms.Button();
            this.lstTipoFactura = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblClienteVenta
            // 
            this.lblClienteVenta.AutoSize = true;
            this.lblClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteVenta.Location = new System.Drawing.Point(5, 68);
            this.lblClienteVenta.Name = "lblClienteVenta";
            this.lblClienteVenta.Size = new System.Drawing.Size(51, 17);
            this.lblClienteVenta.TabIndex = 0;
            this.lblClienteVenta.Text = "Cliente";
            // 
            // lblVendedorVenta
            // 
            this.lblVendedorVenta.AutoSize = true;
            this.lblVendedorVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorVenta.Location = new System.Drawing.Point(5, 108);
            this.lblVendedorVenta.Name = "lblVendedorVenta";
            this.lblVendedorVenta.Size = new System.Drawing.Size(70, 17);
            this.lblVendedorVenta.TabIndex = 1;
            this.lblVendedorVenta.Text = "Vendedor";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.Location = new System.Drawing.Point(5, 148);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(104, 17);
            this.lblTipoFactura.TabIndex = 2;
            this.lblTipoFactura.Text = "Tipo de factura";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(5, 188);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(126, 17);
            this.lblNumeroFactura.TabIndex = 3;
            this.lblNumeroFactura.Text = "Numero de factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(5, 228);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblIngreseDatosVenta
            // 
            this.lblIngreseDatosVenta.AutoSize = true;
            this.lblIngreseDatosVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseDatosVenta.Location = new System.Drawing.Point(43, 19);
            this.lblIngreseDatosVenta.Name = "lblIngreseDatosVenta";
            this.lblIngreseDatosVenta.Size = new System.Drawing.Size(229, 22);
            this.lblIngreseDatosVenta.TabIndex = 5;
            this.lblIngreseDatosVenta.Text = "Ingrese los datos de ventas";
            // 
            // lstCliente
            // 
            this.lstCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(138, 64);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(169, 24);
            this.lstCliente.TabIndex = 6;
            // 
            // lstVendedor
            // 
            this.lstVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVendedor.FormattingEnabled = true;
            this.lstVendedor.Location = new System.Drawing.Point(138, 105);
            this.lstVendedor.Name = "lstVendedor";
            this.lstVendedor.Size = new System.Drawing.Size(169, 24);
            this.lstVendedor.TabIndex = 7;
            // 
            // txtNFactura
            // 
            this.txtNFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFactura.Location = new System.Drawing.Point(138, 186);
            this.txtNFactura.MaxLength = 4;
            this.txtNFactura.Name = "txtNFactura";
            this.txtNFactura.Size = new System.Drawing.Size(73, 23);
            this.txtNFactura.TabIndex = 9;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(138, 226);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(169, 23);
            this.dtpFecha.TabIndex = 10;
            // 
            // cmdCargaVenta
            // 
            this.cmdCargaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargaVenta.Location = new System.Drawing.Point(212, 265);
            this.cmdCargaVenta.Name = "cmdCargaVenta";
            this.cmdCargaVenta.Size = new System.Drawing.Size(95, 32);
            this.cmdCargaVenta.TabIndex = 11;
            this.cmdCargaVenta.Text = "Cargar";
            this.cmdCargaVenta.UseVisualStyleBackColor = true;
            this.cmdCargaVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstTipoFactura
            // 
            this.lstTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTipoFactura.FormattingEnabled = true;
            this.lstTipoFactura.ItemHeight = 16;
            this.lstTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstTipoFactura.Location = new System.Drawing.Point(138, 148);
            this.lstTipoFactura.Name = "lstTipoFactura";
            this.lstTipoFactura.Size = new System.Drawing.Size(169, 20);
            this.lstTipoFactura.TabIndex = 12;
            // 
            // frmCargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 309);
            this.Controls.Add(this.lstTipoFactura);
            this.Controls.Add(this.cmdCargaVenta);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNFactura);
            this.Controls.Add(this.lstVendedor);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.lblIngreseDatosVenta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.lblVendedorVenta);
            this.Controls.Add(this.lblClienteVenta);
            this.Name = "frmCargaVentas";
            this.Text = "Cargar Ventas";
            this.Load += new System.EventHandler(this.frmCargaVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClienteVenta;
        private System.Windows.Forms.Label lblVendedorVenta;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblIngreseDatosVenta;
        private System.Windows.Forms.ComboBox lstCliente;
        private System.Windows.Forms.ComboBox lstVendedor;
        private System.Windows.Forms.TextBox txtNFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button cmdCargaVenta;
        private System.Windows.Forms.ListBox lstTipoFactura;
    }
}