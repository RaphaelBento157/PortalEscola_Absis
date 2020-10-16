using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso
{
    public class UsuarioDB
    {
        public Usuario Carrega(string sLogin)
        {
            return new Usuario() { Login = "Advaldo", Senha = "abc123" };
        }

    }
}
