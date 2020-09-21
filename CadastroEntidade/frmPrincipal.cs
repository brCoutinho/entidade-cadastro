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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroEntidade c = new frmCadastroEntidade();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEditaEntidade c = new frmEditaEntidade();
            c.ShowDialog();
        }
    }
}
