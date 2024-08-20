using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWeb.Vistas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMensaje.Text = string.Empty;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            //Console.WriteLine();

            //System.Diagnostics.Debug.WriteLine($"Usuario: {usuario} \n pw: {password}");

            Page.Response.Write("<script>console.log('" + $"{usuario}" + "');</script>");


            //Response.Redirect("~/Vistas/default.aspx");
            //if (ValidarUsuario(usuario, password))
            //{

            //    FormsAuthentication.RedirectFromLoginPage(usuario, false);
            //}
            //else
            //{
            //    lblMensaje.Text = "Usuario o contraseña incorrectos.";
            //}
        }

        //private bool ValidarUsuario(string usuario, string password)
        //{
        //    bool esValido = false;
        //    string connectionString = "LAPTOP-LEVCK5RM\\SQLEXPRESS";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", conn);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Usuario", usuario);
        //        cmd.Parameters.AddWithValue("@Password", password);

        //        conn.Open();
        //        object result = cmd.ExecuteScalar();
        //        if (result != null)
        //        {
        //            esValido = Convert.ToBoolean(result);
        //        }
        //    }

        //    return esValido;
        //}
    }
}