using Consulta_con_Grilla.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consulta_con_Grilla
{
    public partial class Consulta : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Consultar(Object sender, EventArgs e)
        {
            List<Establecimiento> lista = (List<Establecimiento>)Application["Establecimientos"];

            List<Establecimiento> gridData = new List<Establecimiento>();

            foreach (Establecimiento est in lista)
            {
                bool incluir = true;

                if (!string.IsNullOrEmpty(txtNombre.Text)) {
                    if (!est.Nombre.Equals(txtNombre.Text))
                    {
                        incluir = false;
                    }
                }

                if (!string.IsNullOrEmpty(txtDireccion.Text))
                {
                    if (!est.Direccion.Equals(txtDireccion.Text))
                    {
                        incluir = false;
                    }
                }

                if (est.FechaApertura <= calFechaApertura.SelectedDate)
                    {
                        incluir = false;
                    }

                if (incluir)
                {
                    gridData.Add(est);
                }
            }

            GridViewConsulta.DataSource = gridData;
            GridViewConsulta.DataBind();

            foreach (GridViewRow row in GridViewConsulta.Rows)
            {
                row.Cells[4].Text = row.Cells[4].Text.Remove(10, 11);
            }
        }


        protected void GridViewConsulta_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Accion1":
                    //Obtenemos el índice del registro seleccionado
                    int indiceBuscar = Convert.ToInt32(e.CommandArgument);
                    //Obtenemos la fila del registro
                    GridViewRow rowBuscar = GridViewConsulta.Rows[indiceBuscar];
                    
                    GridViewConsulta_Accion1(rowBuscar);
                    break;

                case "Accion2":
                    int indiceEditar = Convert.ToInt32(e.CommandArgument);
                    GridViewRow rowEditar = GridViewConsulta.Rows[indiceEditar];
                    
                    GridViewConsulta_Accion2(rowEditar);
                    break;
            }
        }

        protected void GridViewConsulta_Accion1(GridViewRow row)
        {
            Establecimiento est = new Establecimiento { Nombre = row.Cells[2].Text, Direccion = row.Cells[3].Text};

            Cache["Establecimiento"] = est;

            Response.Redirect("PaginaDestino.aspx");
        }

        protected void GridViewConsulta_Accion2(GridViewRow row)
        {
            //Funcionalidad Acción 2
        }
    }
}