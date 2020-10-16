using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso
{
    public class Cadastro
    {
        public bool Validar(string sUsuario, string sSenha, string sConfirmarSenha, string sTipoCadastro)
        {

            if (string.IsNullOrWhiteSpace(sUsuario) && string.IsNullOrWhiteSpace(sSenha) && string.IsNullOrWhiteSpace(sConfirmarSenha) && string.IsNullOrWhiteSpace(sTipoCadastro))
                return false;
            Usuario Usuario1 = new UsuarioDB().Carrega("Advaldo");
            if (Usuario1.Senha.Equals(sSenha))
                return true;
            if (Usuario1.ConfirmaSenha.Equals(sConfirmarSenha))
                return true;
            return false;

        }
    }
}
