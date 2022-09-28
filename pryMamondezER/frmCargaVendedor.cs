using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMamondezER
{
    public partial class frmCargaVendedor : Form
    {
        public frmCargaVendedor()
        {
            InitializeComponent();
        }

        private void cmdCargarVendedor_Click(object sender, EventArgs e)
        {
                                             
                     
            StreamWriter Vendedores = new StreamWriter("./Vendedores.txt");  //Creamos archivo y le cargamos los datos del cliente
            Vendedores.WriteLine(txtNumeroVendedor.Text + "," + txtNombreVendedor.Text + "," + txtActivo.Text + "," + txtComision.Text);
            MessageBox.Show("Usted cargo los datos del vendedor");
            Vendedores.Close(); //Cerramos archivo
            txtNumeroVendedor.Text = "";
            txtNombreVendedor.Text = "";
            txtActivo.Text = "";
            txtComision.Text = "";

        }

        private void frmCargaVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
