using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEntidade
{
    public partial class frmCadastroEntidade : Form
    {
        public frmCadastroEntidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!((string.IsNullOrEmpty(txtNome.Text)) ||
                (string.IsNullOrEmpty(txtcpfCnpj.Text)) || (string.IsNullOrEmpty(txtdataNasc.Text))))

            {
                Entidade entidade = new Entidade();
                entidade.nome = txtNome.Text;
                entidade.cnpj = txtcpfCnpj.Text;
                entidade.cpf = txtcpfCnpj.Text;
                entidade.dtNascimento = txtdataNasc.Value;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        public void limpaCampos()
        {
            txtNome.Text = "";
            txtdataNasc.Text = "";
            txtcpfCnpj.Text = "";
        }
    }
}
