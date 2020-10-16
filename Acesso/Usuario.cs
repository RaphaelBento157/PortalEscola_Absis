using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso
{
   public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
        public string TipoCadastro { get; set; }
    }
}
