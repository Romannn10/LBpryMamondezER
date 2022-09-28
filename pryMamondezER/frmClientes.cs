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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void cmdCargarCliente_Click(object sender, EventArgs e)
        {
            StreamReader srControlClientes = new StreamReader("./Clientes.txt");

            bool bandera = false; //Creamos una bandera para que no se repita el codigo

            
            while (!srControlClientes.EndOfStream) //Preguntamos, si no es final de archivo entra
            {
                string auxClientes = srControlClientes.ReadLine(); //Cargamos 
                string[] clientes = auxClientes.Split(',');

                if (txtNumeroCliente.Text == clientes[0])
                {
                    MessageBox.Show("No se puede cargar el numero del cliente porque esta repetido");
                    txtNumeroCliente.Text = "";
                    bandera = true; 
                }
            }
            srControlClientes.Close();

            if (bandera == false)
            {
                StreamWriter Clientes = new StreamWriter("./Clientes.txt");
                Clientes.WriteLine(txtNumeroCliente.Text + "," + txtNombreCliente.Text);
                MessageBox.Show("Cargo los datos del cliente correctamente");
                Clientes.Close();
                txtNombreCliente.Text = "";
                txtNumeroCliente.Text = "";

            }





           

            
        }
    }
}
