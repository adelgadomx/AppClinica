using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        string user = txtusuario.Text;
        string password = txtPassword.Text;
        string userName = "adelgado";
        string passName = "4ug02000";

        if (user.Equals(userName) && password.Equals(passName))
        {
            Response.Write("<script> alert ('Usuario Correcto'); </script>");
        } else
        {
            Response.Write("<script> alert ('Usuario Incorrecto'); </script>");
        }
    }
}