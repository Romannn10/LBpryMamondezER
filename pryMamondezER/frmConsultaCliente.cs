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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            StreamReader clientes = new StreamReader("./Clientes.txt");
            while (!clientes.EndOfStream)
            {
                string ID = clientes.ReadLine();
                string[] Clientes = ID.Split(',');
                dgvConsulta.Rows.Add(Clientes[0], Clientes[1]);
            }
            clientes.Close();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {

        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
