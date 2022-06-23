using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV1.AD;

namespace TP_PAV1
{
    public partial class DetalleVenta : Form
    {
        public DetalleVenta(int nroCompra)
        {
            InitializeComponent();
            dataGridDetalleVenta.DataSource = AD_Ventas.DetalleCompra(nroCompra);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
