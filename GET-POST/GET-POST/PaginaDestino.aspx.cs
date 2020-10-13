using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GET_POST
{
    public partial class PaginaDestino : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtDestino.Text = Request["TextoGET"];
            //txtDestino.Text = Request.QueryString["TextoGET"];
            //txtDestino.Text = Request.Params["TextoGET"];
            txtDestino.Text = Request["TextoPOST"];
        }
    }
}