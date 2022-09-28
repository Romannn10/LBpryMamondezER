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
    public partial class frmKaktus : Form
    {
        public frmKaktus()
        {
            InitializeComponent();
        }

        private void registrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes objRegistroCliente = new frmClientes();
            objRegistroCliente.Show();
        }

        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente objConsultaCliente = new frmConsultaCliente();
            objConsultaCliente.Show();
        }

        private void registrarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaVendedor objCargaVendedor = new frmCargaVendedor();
            objCargaVendedor.Show();
        }

        private void registrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaVentas objCargaVenta = new frmCargaVentas();
            objCargaVenta.Show();
                
        }

        private void frmKaktus_Load(object sender, EventArgs e)
        {
            if (File.Exists("./Clientes.txt"))
            {

            }
            else
            {
                File.Create("./Clientes.txt");
            }
            if (File.Exists("./Vendedores.txt"))
            {

            }
            else
            {
                File.Create("./Vendedores.txt");
            }
            if (File.Exists("./Ventas.txt"))
            {

            }
            else
            {
                File.Create("./Ventas.txt");
            }
        }
    }
}
