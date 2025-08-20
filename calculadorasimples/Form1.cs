using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorasimples
{
    public partial class frmCalculadoraSimples : Form
    {
        public frmCalculadoraSimples()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblProdutoCalculo.Text = (float.Parse(txtPrimeiroNumero.Text) + float.Parse(txtSegundoNumero.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblProdutoCalculo.Text = (float.Parse(txtPrimeiroNumero.Text) - float.Parse(txtSegundoNumero.Text)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblProdutoCalculo.Text = (float.Parse(txtPrimeiroNumero.Text) * float.Parse(txtSegundoNumero.Text)).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblProdutoCalculo.Text = (float.Parse(txtPrimeiroNumero.Text) / float.Parse(txtSegundoNumero.Text)).ToString();
        }
    }
}
