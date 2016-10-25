﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    /// <summary>
    /// La clase conexion...
    /// </summary>
    public class ConexionDb
    {
        private SqlConnection con;
        private SqlCommand Cmd;        

        public ConexionDb()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["VentasDb"].ConnectionString));//"Data Source = ROOT - PC\\SURPUSER; Initial Catalog = HandlingQuotasDb; Integrated Security = True"
            Cmd = new SqlCommand();
        }
        
        /// <summary>
        /// Ejecuar comandos contra la base de datos
        /// </summary>
        /// <param name="ComandoSql">El comando sql que se desea ejecutar</param>
        /// <returns>Verdadero o Falso dependiendo de si ejecuto correctament o no</returns>
        public bool Ejecutar(String ComandoSql)
        {
            bool retorno = false;

            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = ComandoSql;
                Cmd.ExecuteNonQuery();
                retorno = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }

        public DataTable ObtenerDatos(String ComandoSql)
        {

            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = ComandoSql;

                adapter = new SqlDataAdapter(Cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }


        public Object ObtenerValor(String ComandoSql)
        {
            Object retorno = null;

            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = ComandoSql;
                retorno = Cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }

    }
}
