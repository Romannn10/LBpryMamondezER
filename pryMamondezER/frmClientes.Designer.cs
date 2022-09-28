namespace pryMamondezER
{
    partial class frmClientes
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
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.cmdCargarCliente = new System.Windows.Forms.Button();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.Location = new System.Drawing.Point(37, 21);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(232, 22);
            this.lblDatosCliente.TabIndex = 0;
            this.lblDatosCliente.Text = "Ingrese los datos del cliente";
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCliente.Location = new System.Drawing.Point(12, 77);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(103, 17);
            this.lblNumeroCliente.TabIndex = 1;
            this.lblNumeroCliente.Text = "Numero cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 114);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(126, 17);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre del cliente";
            // 
            // cmdCargarCliente
            // 
            this.cmdCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarCliente.Location = new System.Drawing.Point(197, 154);
            this.cmdCargarCliente.Name = "cmdCargarCliente";
            this.cmdCargarCliente.Size = new System.Drawing.Size(97, 43);
            this.cmdCargarCliente.TabIndex = 3;
            this.cmdCargarCliente.Text = "Cargar";
            this.cmdCargarCliente.UseVisualStyleBackColor = true;
            this.cmdCargarCliente.Click += new System.EventHandler(this.cmdCargarCliente_Click);
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCliente.Location = new System.Drawing.Point(144, 71);
            this.txtNumeroCliente.MaxLength = 3;
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(62, 23);
            this.txtNumeroCliente.TabIndex = 4;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(144, 111);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(150, 23);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 210);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.cmdCargarCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblNumeroCliente);
            this.Controls.Add(this.lblDatosCliente);
            this.Name = "frmClientes";
            this.Text = "Carga Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button cmdCargarCliente;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
    }
}