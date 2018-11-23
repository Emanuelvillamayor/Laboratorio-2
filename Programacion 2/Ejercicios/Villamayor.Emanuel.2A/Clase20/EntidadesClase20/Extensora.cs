using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data;


//Clase estatica solo almacena metodos estaticos , no se puede instanciar , etc

namespace EntidadesClase20
{
  public static  class Extensora
    {

        #region Metodos

        //palabra reservada "this" mas el "tipo de dato" 
        public static string ObtenerDatos(this Entidades.Externa.Sellada.PersonaExternaSellada persona)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n",persona.Nombre);
            sb.AppendFormat("Apellido: {0}\n", persona.Apellido);
            sb.AppendFormat("Edad: {0}\n", persona.Edad);
            sb.AppendFormat("Sexo: {0}\n", persona.Sexo);

            return sb.ToString();
        }

        //cualquier clase que haga , va a tener el metodo "EsNulo" , ya que todo deriva de obj
        public static bool EsNulo(this object obj )
        {
            bool retorno = true;

          //if(obj is null)
            if(obj!=null)
            {
                retorno = false;
            }
            return retorno;
        }

       //ejemplo si le paso 593 , tiene que devolver 3 , si le paso 20 tiene que devolver 2
        public static Int32 CantidadDigitos(this Int32 num)
        {
            return (Convert.ToString(num)).Length;
        }


        /// <summary>
        /// Valida que si el numero que le pasamos por parametro es la cantidad de digitos que tiene el numero que lo invoca a al funcion
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static bool TieneLaMismaCantidad(this Int32 num1 , Int32 num2)
        {

            return num1.CantidadDigitos() == num2; //reutilizo codigo
        }



        public static List<Entidades.Externa.Sellada.PersonaExternaSellada > TraerDB(this Entidades.Externa.Sellada.PersonaExternaSellada persona)
        {
            List<Entidades.Externa.Sellada.PersonaExternaSellada> lista = new List<Entidades.Externa.Sellada.PersonaExternaSellada>();

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SELECT *FROM personas";
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Entidades.Externa.Sellada.PersonaExternaSellada personita = new Entidades.Externa.Sellada.PersonaExternaSellada( lector.GetString(1), lector.GetString(2), lector.GetInt32(3), (Entidades.Externa.Sellada.ESexo)lector.GetInt32(4));
                    lista.Add(personita);
                }
                conexion.Close();

            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }


        public static bool AgregarDB (this Entidades.Externa.Sellada.PersonaExternaSellada persona)
        {
            bool retorno = false;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();


            comando.CommandText = string.Format("INSERT INTO personas values ('{0}','{1}',{2},{3})",persona.Nombre,persona.Apellido,persona.Edad,Convert.ToInt32( persona.Sexo));
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); 
                conexion.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return retorno;
        }

        public static bool QuitarDB(this Entidades.Externa.Sellada.PersonaExternaSellada persona ,int id)
        {
            bool retorno = false;


            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();


            comando.CommandText = string.Format("DELETE personas WHERE id = {0}", id); //id no se modifica porque es clave primaria
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

        public static bool ModificarDB(this Entidades.Externa.Sellada.PersonaExternaSellada persona ,int id)
        {
            bool retorno = false;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();


            comando.CommandText = string.Format("UPDATE personas SET nombre ='{0}',apellido = '{1}',edad = {2},sexo={3} WHERE id={4}", persona.Nombre,persona.Apellido,persona.Edad,(Int32)persona.Sexo, id); //id no se modifica porque es clave primaria
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

        #endregion

    }
}
