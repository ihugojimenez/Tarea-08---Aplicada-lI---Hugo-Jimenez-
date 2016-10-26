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
            i
        }

        

        protected void SearchButton_Click(object sender, EventArgs e)
        {

            Articulos a = new Articulos();
            //int id = 0;
            //int.TryParse(IdTextBox.Text, out id);
            DataSet ds = a.GetData();
            ArticulosDataList.DataSource = ds;
            ArticulosDataList.DataBind();

            


        }



    }
}