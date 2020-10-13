using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class MiPantalla : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarFiltros();
            }
        }

        public void CargarFiltros()
        {
            ListaDePaises.Items.Add(new ListItem("Argentina", "1"));
            ListaDePaises.Items.Add(new ListItem("Brasil", "2"));
            ListaDePaises.Items.Add(new ListItem("Paraguay", "3"));
            ListaDePaises.Items.Add(new ListItem("Uruguay", "4"));

            ListaDePaises.Items.Insert(0, new ListItem("Todos", "0"));
        }

        protected void LimpiarCampos(Object sender, EventArgs e)
        {
            TextBoxNombre.Text = "";
            ListaDePaises.SelectedValue = "0";
            TextBoxLocalidad.Text = "";
        }
    }
}