using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEscola
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregaCad();
        }
        private void CarregaCad()
        {
            string sUsuario = txtUsuario.Text;
            string sSenha = txtSenha.Text;
            string sConfirmaSenha = txtConfirmarSenha.Text;
            string sTipoCadastro = "a";
            Acesso.Cadastro a = new Acesso.Cadastro();
            if (a.Validar(sUsuario, sSenha, sConfirmaSenha, sTipoCadastro))
            {
                lblResultado.Text = "Sucesso!";
                Session["USUARIO"] = sUsuario;
                Response.Redirect("Cadastro.aspx");
            }
            else
                lblResultado.Text = "Acesso inválido!";

        }

    }
}