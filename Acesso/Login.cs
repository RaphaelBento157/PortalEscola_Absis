using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso
{
    public class Login
    {
        public bool Validar(string sUsuario, string sSenha) {

            if (string.IsNullOrWhiteSpace(sUsuario) && string.IsNullOrWhiteSpace(sSenha) )
                return false;
            Usuario Usuario1 = new UsuarioDB().Carrega("Advaldo");
            if (Usuario1.Senha.Equals(sSenha))
                return true;
            return false;

        }
    }
}
