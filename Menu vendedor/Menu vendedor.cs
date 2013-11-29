using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu_vendedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuBoleta_Click(object sender, EventArgs e)
        {
            Boleta boleta = new Boleta();
            boleta.ShowDialog();
        }

        private void mnuFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.ShowDialog();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        

       
    }
}
