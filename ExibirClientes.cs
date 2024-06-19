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
    public partial class ExibirClientes : Form
    {
        public ExibirClientes()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alunoct\\Desktop\\mateus IN205\\LP2 IN205\\projClientes\\Clientes.mdf\";Integrated Security=True";
            SqlConnection conexao = new SqlConnection(stringDeConexao);
            conexao.Open();

            string consulta = "SELECT * FROM Cliente";
            SqlCommand comando = new SqlCommand(consulta, conexao);
            SqlDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                lbclientes.Items.Add(leitor["nome"]);
                lbclientes.Items.Add(leitor["cpf"]);
                lbclientes.Items.Add(leitor["endereco"]);
            }
            leitor.Close();
            conexao.Close();
        }
    }
}
