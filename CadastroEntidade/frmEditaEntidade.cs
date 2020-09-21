using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;
using Npgsql;

namespace CadastroEntidade
{
    public partial class frmEditaEntidade : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection();
        string cadenaConexao;
        public frmEditaEntidade()
        {
            InitializeComponent();
            //cadenaConexao = "Server = localhost; Port = 5432; Database = teste;";
            //cadenaConexao += "User Id = postgres;";
            //cadenaConexao += "Password = 251205;";
            //cadenaConexao = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=251205;Database=teste;";
            cadenaConexao = "server=localhost;Port=5432;user id=postgres;password=251205;database=teste";
            conexao.ConnectionString = cadenaConexao;

            
            try
            {
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Usuário ou senha incorretos");
                conexao.Close();
            }
            if (conexao.State.ToString() == "Open")
            {
                MessageBox.Show("Conexão realizada com sucesso");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verifica se os campos estão preenchidos
            if (!((string.IsNullOrEmpty(txtTipo.Text))  ||
                (string.IsNullOrEmpty(txtLograd.Text))  || 
                (string.IsNullOrEmpty(txtBairro.Text))  ||
                (string.IsNullOrEmpty(txtCep.Text))  ||
                (string.IsNullOrEmpty(txtMunicipio.Text))  ||
                (string.IsNullOrEmpty(txtUf.Text))  ||
                (string.IsNullOrEmpty(txtNumero.Text)) ||
                (string.IsNullOrEmpty(txtDDD.Text)) ||
                (string.IsNullOrEmpty(txtnumTelefone.Text)) ||
                (string.IsNullOrEmpty(txtendEmail.Text)) 
                ))

            {
                Endereco endereco = new Endereco();
                //endereco.idEntidade = cbmEntidade.Items;
                endereco.tipoLogradouro = txtTipo.Text;
                endereco.logradouro = txtLograd.Text;
                endereco.numero = Convert.ToInt32(txtNumero.Text);
                endereco.bairro = txtBairro.Text;
                endereco.cep = txtCep.Text;
                endereco.municipio = txtMunicipio.Text;
                endereco.uf = txtUf.Text;

                Telefone telefone = new Telefone();
                //telefone.idEntidade = cbmEntidade.Items;
                telefone.ddd = txtDDD.Text;
                telefone.numero = txtnumTelefone.Text;

                Email email = new Email();
                //email.idEntidade = cbmEntidade.Items;
                email.endereco = txtendEmail.Text;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }
    }
}
