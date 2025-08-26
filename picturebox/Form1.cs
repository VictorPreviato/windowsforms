using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class frmPictureBox : Form
    {
        private string imagemLocalizada;
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnVerImagem_Click(object sender, EventArgs e)
        {
            pbCidade.Image = Image.FromFile(@"C:\Users\victor.gpreviato\Downloads\Sampa.PNG");
            pbCidade.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            try
            {
                // caixa de diálogo para abrir arquivo
                OpenFileDialog abrirarquivo = new OpenFileDialog();
                abrirarquivo.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagemLocalizada = abrirarquivo.FileName;

                    pbAnexarImagem.ImageLocation = imagemLocalizada;
                }


            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
