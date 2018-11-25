using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //using para que se conecte con la base de datos
using System.Data;
using System.Windows.Forms;
namespace Entidades
{
    public class Producto
    {
        #region Atributos

        public string nombre;
        public int stock;

        #endregion

        #region Constructores

        public Producto()
        {

        }

        public Producto(string nombre , int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }

        #endregion

        public override string ToString()
        {
            return string.Format("{0} - {1}\n", this.nombre, this.stock);
        }

        //Agregar método de extensión (clase Extensora) en Producto: AgregarBD():bool.
        //AgregarBD insertará sobre la Base de Datos la instancia que lo invoque (Nombre y Stock)
        //Base de Datos (productosDB) -> Tabla productos (nombre - stock)

        public bool AgregarBD()
        {
            bool retorno = false;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandType= System.Data.CommandType.Text;
            comando.CommandText = string.Format("INSERT INTO productos values ('{0}',{1})", this.nombre, this.stock );
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                retorno = true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return retorno;
        }

        //Agregar metodo de extension (clase Extensora) en Producto: MostrarBD():string.
        //MostrarBD retornara una cadena (Nombre y Stock) de todos los registros de la BD.
        //Base de Datos (productosDB) -> Tabla productos (nombre - stock)

        public string MostrarBD()
        {
            string retorno = "";
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = string.Format("SELECT *FROM productos"); //el *From es porque quiere todos los campos 
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Producto p = new Producto(lector.GetString(0), lector.GetInt32(1));
                    retorno += p.ToString();                 
                }

                conexion.Close();//cierra conexion
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return retorno;
        }

        

    }
}
