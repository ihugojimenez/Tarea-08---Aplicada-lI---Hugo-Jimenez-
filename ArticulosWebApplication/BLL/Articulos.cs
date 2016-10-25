using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Articulos : ClaseMaestra
    {
        ConexionDb Conexion = new ConexionDb();

        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public float Precio { get; set; }

        public Articulos()
        {

        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Insertar()
        {
            bool retorno = false;

            try
            {
                retorno = Conexion.Ejecutar(string.Format("Insert into Articulos(Descripcion, Foto, Precio) values('{0}', '{1}',{2})", this.Descripcion, this.Foto, this.Precio));
            }
            catch (Exception ex)
            {
                retorno = false;
                throw ex;

            }
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
