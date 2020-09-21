using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEntidade
{
    public class Telefone
    {
        public int idTelefone { get; set; }
        public int idEntidade { get; set; }
        public string ddd { get; set; }
        public string numero { get; set; }
    }
}
