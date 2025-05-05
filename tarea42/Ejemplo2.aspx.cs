using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tarea42
{
    public partial class Ejemplo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cookiePrueba");
            cookie.Values["Usuario"] = "perez";
            cookie.Values["Contraseña"] = "superalumno";
            cookie.Values["AñosBuscados"] = "4";
            cookie.Values["Preferencia"] = "redes";
            cookie.Values["UltimaVisita"] = DateTime.Now.ToString();
            cookie.Values["VariableServer"] = Request.ServerVariables["HTTP_USER_AGENT"];
            cookie.Expires = DateTime.Now.AddMinutes(10);

            Response.Cookies.Add(cookie);

            foreach (string key in cookie.Values.AllKeys)
            {
                lblCookies.Text += $"{key}: {cookie.Values[key]}<br />";
            }

            Response.Redirect("Respuesta_EjercicioCookies.aspx", false);
        }
    }
}