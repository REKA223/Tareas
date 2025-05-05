using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tarea42
{
    public partial class Respuesta_EjercicioCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cookiePrueba"];

            if (cookie != null)
            {
                Label1.Text = "Usuario: " + cookie.Values["Usuario"];
                Label2.Text = "Preferencia: " + cookie.Values["Preferencia"];
                Label3.Text = "Última Visita: " + cookie.Values["UltimaVisita"];
            }
            else
            {
                Label1.Text = "No se encontró la cookie.";
                Label2.Text = "";
                Label3.Text = "";
            }
        }
    }
}