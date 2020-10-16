using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEscola
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USUARIO"] != null)
                lblResultado.Text = Session["USUARIO"].ToString();
            Logar();
        }
      

        public void btnLogar_Click(object sender, EventArgs e)
        {
            Logar();

        }
        private void Logar()
        {
            string sUsuario = txtUsuario.Text;
            string sSenha = txtSenha.Text;
            Acesso.Login a = new Acesso.Login();
            if (a.Validar(sUsuario, sSenha))
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