using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crud
{
    public partial class frmCadastroDeClientes : Form
    {

        //Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";

        public frmCadastroDeClientes()
        {
            InitializeComponent();

            //Configuração inicial do ListView para exibição dos dados dos clientes
            lstCliente.View = View.Details;               //Define a visualiazação em "detalhes"
            lstCliente.LabelEdit = true;                 //Permite editar os títulos das colunas
            lstCliente.AllowColumnReorder = true;       //Permite reordenar as colunas
            lstCliente.FullRowSelect = true;           //Sekeciona a linha inteira ai clicar
            lstCliente.GridLines = true;              //Exibe as linhas de grade no ListView

            //Definindo as counas no ListView
            lstCliente.Columns.Add("Codigo", 100, HorizontalAlignment.Left); //Coluna do Código
            lstCliente.Columns.Add("Nome Completo", 200, HorizontalAlignment.Left); //Coluna de nome completo
            lstCliente.Columns.Add("Nome Social", 200, HorizontalAlignment.Left); //Coluna de nome social
            lstCliente.Columns.Add("E-mail", 200, HorizontalAlignment.Left); //Coluna de E-mail
            lstCliente.Columns.Add("CPF", 200, HorizontalAlignment.Left); //Coluna de CPF

            //Carrega os dados dos clientes na interface
            carregar_cliente();
        }

        private void carregar_clientes_com_query(string query)
        {
            try
            {
                //Cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta SQL forncecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém o parâmtro @q, adiciona o valor da caixa de pesquisa
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                //Executa o comando e obtem os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os intens existentes no ListView antes de adicionar novos
                lstCliente.Items.Clear();

                //Preenche o ListView com os dados do cliente
                while (reader.Read())
                {
                    string[] row =
                {
                    Convert.ToString(reader.GetInt32(0)), //Codigo
                    reader.GetString(1),                   //Nome Completo
                    reader.GetString(2),                   //Nome Social    
                    reader.GetString(3),                   //E-mail
                    reader.GetString(4),                   //CPF
                };

                    //Adiciona a Linha ao ListView
                    lstCliente.Items.Add(new ListViewItem(row));
              }
            }


            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MYSQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)
            {
                //Trta outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        //Método para carregar todos os clientes do ListView (usando uma consulta sem parâmetros)

        private void carregar_cliente()
        {
            string query = "SELECT * FROM dadosdocliente ORDER BY idcliente DESC";
            carregar_clientes_com_query(query);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validação de campos obrigatórios
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCPF.Text.Trim()))
                {

                    MessageBox.Show("Todos os campos devem ser preenchidos. ",
                        "Validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return; //Impede o prosseguimento
                }


                //Validação do CPF
                string cpf = txtCPF.Text.Trim();

                if (!isValidCPFLenght(cpf))
                {
                    MessageBox.Show("CPF inválido. Certifique-se do que o CPF tenha 11 dígitos numéricos.",
                        "Validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return; //Impede o prosseguimento se o CPF for inválido
                }
                //Cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };

                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf) " +
                    "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";


                //Adiciona os parâmetros com os dados do formulário
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf",cpf);

                //Excuta o comando de inserção no banco
                cmd.ExecuteNonQuery();

                //Mensagem de sucesso
                MessageBox.Show("Contato inserido com Sucesso: ",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Limpa os campos após os successo
                txtNomeCompleto.Text = String.Empty;
                txtNomeSocial.Text = " ";
                txtEmail.Text = " ";
                txtCPF.Text = " ";

                //Recarrega os clientes no ListView
                carregar_cliente();

                // Muda para a aba de pesquisa
                tbControl.SelectedIndex = 1;



            }

            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MYSQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            catch(Exception ex)
            {
                //Trta outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if(Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        private bool isValidCPFLenght(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            return cpf.Length == 11;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdocliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY idcliente DESC";
                carregar_clientes_com_query(query);
        }
    }
}


