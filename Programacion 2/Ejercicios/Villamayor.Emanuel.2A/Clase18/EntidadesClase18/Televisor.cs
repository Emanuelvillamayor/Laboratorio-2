using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //using para que se conecte con la base de datos
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace EntidadesClase18 
{
   public class Televisor
    {
        #region Atributos

        public int id;
        public string marca;
        public double precio;
        public int pulgadas;
        public string pais;

        #endregion

        #region Constructores
        public Televisor()
        {

        }
        public Televisor(int id, string marca, double precio, int pulgadas, string pais)
        {
            this.id = id;
            this.marca = marca;
            this.precio = precio;
            this.pulgadas = pulgadas;
            this.pais = pais;
        }

        #endregion

        #region Metodos

        public bool Insertar()
        {
            bool retorno = false;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();


            comando.CommandText = string.Format("INSERT INTO Televisores values ({0},'{1}',{2},{3},'{4}')", this.id, this.marca, this.precio, this.pulgadas, this.pais);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta consultas que no van a retornar ningun tipo de resultado
                conexion.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }
       
            return retorno;
        }


        public static bool Modificar(Televisor t)
        {
            bool retorno = false;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();


            comando.CommandText = string.Format("UPDATE Televisores SET marca ='{0}',precio = {1},pulgadas = {2},pais='{3}' WHERE codigo={4}",t.marca, t.precio, t.pulgadas, t.pais,t.id); //id no se modifica porque es clave primaria
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta consultas que no van a retornar ningun tipo de resultado
                conexion.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return retorno;
        }


        public static bool Borrar(Televisor t)
        {
            bool retorno = false;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();


            comando.CommandText = string.Format("DELETE Televisores WHERE codigo = {0}", t.id); //id no se modifica porque es clave primaria
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta consultas que no van a retornar ningun tipo de resultado
                conexion.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return retorno;
        }


        public static List<Televisor> TraerTodos()
        {
            List<Televisor> televisores = new List<Televisor>();

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SELECT *FROM Televisores";
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Televisor tele = new Televisor(lector.GetInt32(0), lector.GetString(1), lector.GetDouble(2), lector.GetInt32(3), lector.GetString(4));              
                    televisores.Add(tele);
                }
                conexion.Close();
               
            }
            catch (Exception e)
            {
                throw e;
            }

            return televisores;
        }

        public static Televisor TraerUno(int id )//id que va a elegir para obtener
        {
            Televisor tele ;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();

             comando.CommandText =string.Format("SELECT *FROM Televisores where codigo = {0}",id); //el *From es porque quiere todos los campos 
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                lector.Read(); //es importante colocarlo sino no lee nada

                if(lector.HasRows)
                {
                    tele = new Televisor(lector.GetInt32(0), lector.GetString(1), lector.GetDouble(2), lector.GetInt32(3), lector.GetString(4));
                }
                else
                {
                    tele = null;
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            return tele;
        }
        #endregion
    }
}
