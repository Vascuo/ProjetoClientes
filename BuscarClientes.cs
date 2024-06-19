using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projClientes
{
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alunoct\\Videos\\TrabLP2MQA\\projClientes\\projClientes\\Clientes.mdf;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(stringDeConexao);
            conexao.Open();
            string comandoSql = "Select nome,endereco from Cliente where cpf = @cpf";
            SqlCommand cmd = new SqlCommand(comandoSql, conexao);
            cmd.Parameters.AddWithValue("@cpf", txtcpf.Text);
            SqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                txtnome.Text = leitor["nome"].ToString();
                txtendereco.Text = leitor["endereco"].ToString();
            }
            leitor.Close();
            conexao.Close();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alunoct\\Videos\\TrabLP2MQA\\projClientes\\projClientes\\Clientes.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection conexao = new SqlConnection(stringDeConexao))
                {
                    conexao.Open();
                    SqlCommand comando = new SqlCommand(" Update Cliente set nome = @nome where cpf = @cpf", conexao);
                    comando.Parameters.AddWithValue("@nome", txtnome.Text);
                    comando.Parameters.AddWithValue("@cpf", txtcpf.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente alterado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alunoct\\Videos\\TrabLP2MQA\\projClientes\\projClientes\\Clientes.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection conexao = new SqlConnection(stringDeConexao))
                {
                    conexao.Open();
                    SqlCommand comando = new SqlCommand("delete from Cliente where cpf = @cpf", conexao);
                    comando.Parameters.AddWithValue("@cpf", txtcpf.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente excluído com sucesso!");
                    txtnome.Text = "";
                    txtcpf.Text = "";
                    txtendereco.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
