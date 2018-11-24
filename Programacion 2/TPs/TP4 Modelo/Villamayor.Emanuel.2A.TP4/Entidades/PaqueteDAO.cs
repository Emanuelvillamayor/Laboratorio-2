using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data;
namespace Entidades
{
   public static class PaqueteDAO 
    {
        #region Atributos

        private static SqlCommand comando;
        private static SqlConnection conexion;

        #endregion

        #region Constructor

        static PaqueteDAO()
        {
           comando = new SqlCommand();
           conexion = new SqlConnection(Properties.Settings.Default.conexion);
           comando.Connection = conexion;        
        }

        #endregion

        #region Metodos

        public static bool Insertar(Paquete p)
        {
            bool retorno = false;
            comando.CommandText = string.Format("INSERT INTO Paquetes values ('{0}','{1}','{2}')", p.DireccionEntrega, p.TrackingID, "Emanuel Villamayor");
            comando.CommandType = System.Data.CommandType.Text;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();             
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;             
            }
            finally
            {
                conexion.Close();
            }
            return retorno;
        }

        #endregion


    }
}
