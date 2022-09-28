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
    public partial class frmCargaVentas : Form
    {
        public frmCargaVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter srCargarVentas = new StreamWriter("./Ventas.txt", true);
            srCargarVentas.WriteLine(lstCliente.Text + "," + lstVendedor.Text + "," + txtNFactura.Text + "," + lstTipoFactura.Text + "," + dtpFecha.Text);
            MessageBox.Show("Venta Cargada");
            srCargarVentas.Close();
            lstCliente.SelectedIndex = -1;
            lstVendedor.SelectedIndex = -1;
            txtNFactura.Text = "";
            dtpFecha.Text = "";

               
        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {
            StreamReader srLeerIDVendedor = new StreamReader("./Vendedores.txt");
            while (!srLeerIDVendedor.EndOfStream) //Preguntamos, si no es final de archivo entra
            {
                string varLeerIDVendedor = srLeerIDVendedor.ReadLine(); //guarda en la variable una linea del archivo
                string[] vecLeerIDvendedor = varLeerIDVendedor.Split(','); //cargamos en el vector separando con coma
                lstVendedor.Items.Add(vecLeerIDvendedor[0]); //le cargamos a la lista desplegable el vector
            }
            srLeerIDVendedor.Close();

            StreamReader srLeerIDCliente = new StreamReader("./Clientes.txt");
            while (!srLeerIDCliente.EndOfStream)
            {
                string varLeerIDCliente = srLeerIDCliente.ReadLine();
                string[] vecLeerIDCliente = varLeerIDCliente.Split(',');
                lstCliente.Items.Add(vecLeerIDCliente[0]);
            }
            srLeerIDCliente.Close();
        }
    }
}
