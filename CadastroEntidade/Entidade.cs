using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroEntidade
{
    [Table("entidade")]
    public class Entidade
    {
        public int idEntidade { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public DateTime dtNascimento { get; set; }
        public DateTime dtCadastro { get; set; }
        public int pessoaFisica { get; set; }
    }
}
