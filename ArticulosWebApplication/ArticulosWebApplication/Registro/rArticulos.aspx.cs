using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArticulosWebApplication.Registro
{
    public partial class rArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LLenarClase(Articulos a)
        {
            a.Descripcion = DescTextBox.Text;
            a.Precio = Convert.ToSingle(PrcTextBox.Text);
            string str = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath("//Imagenes//") + str);
            string path = "~//Imagenes//" + str.ToString();
            a.Foto = path;
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Articulos at = new Articulos();

            LLenarClase(at);
            at.Insertar();
        }
    }
}