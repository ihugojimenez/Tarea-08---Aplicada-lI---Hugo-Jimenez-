using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArticulosWebApplication.Consultas
{
    public partial class cArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Articulos a = new Articulos();
                //int id = 0;
                //int.TryParse(IdTextBox.Text, out id);
                DataSet ds = a.GetData();
                ArticulosDataList.DataSource = ds;
                ArticulosDataList.DataBind();

               
            }

            //if (ArticulosDataList.DataKeys.ToString())
            //{
            //    Label3.Text = "Se presiono";
            //}
        }

        

        protected void SearchButton_Click(object sender, EventArgs e)
        {

            

            


        }


        protected void ComandoDatalist(object sender, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Agregar")
            {
                Label3.Text = "Selecciono";

               
            }

        }


        protected void ArticulosDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}