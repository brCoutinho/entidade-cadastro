using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEntidade
{
    public class Email
    {
        public int idEmail { get; set; }
        public int idEntidade { get; set; }
        public string endereco { get; set; }
    }
}
