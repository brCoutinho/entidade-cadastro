using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEntidade
{
    public class Endereco
    {
        public int idEndereco { get; set; }
        public int idEntidade { get; set; }
        public string logradouro { get; set; }
        public string tipoLogradouro { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }
    }
}
