using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace BaseDatos
{
    public class Televisor
    {
        //#region Atributos

        //public int id;
        //public string marca;
        //public double precio;
        //public int pulgadas;
        //public string pais;

        ////delegado prueba
        //public event MiDelegado miEvento;

        ////delegado con parametros
        //public event DelegadoTV eventoTv;



        //#endregion

        //#region Constructores
        //public Televisor()
        //{

        //}
        //public Televisor(int id, string marca, double precio, int pulgadas, string pais)
        //{
        //    this.id = id;
        //    this.marca = marca;
        //    this.precio = precio;
        //    this.pulgadas = pulgadas;
        //    this.pais = pais;
        //}

        //#endregion

        //#region Metodos

        ///// <summary>
        ///// Metodo que permite agregar un objeto de tipo Televisor a la tabla Televisores de mi base de datos
        ///// </summary>
        ///// <returns>true si pudo agregar , false si no pudo , excepcion si falla  la conexion o si quiero insertar uno que ya existe a la base de datos</returns>
        //public bool Insertar()
        //{
        //    bool retorno = false;

        //    SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
        //    SqlCommand comando = new SqlCommand();


        //    comando.CommandText = string.Format("INSERT INTO Televisores values ({0},'{1}',{2},{3},'{4}')", this.id, this.marca, this.precio, this.pulgadas, this.pais);
        //    comando.CommandType = System.Data.CommandType.Text;
        //    comando.Connection = conexion;
        //    try
        //    {
        //        conexion.Open();
        //        comando.ExecuteNonQuery(); //ejecuta consultas que no van a retornar ningun tipo de resultado
        //        conexion.Close();

        //        //LANZAMOS EL EVENTO
        //        this.miEvento();
        //        //Lanzamos el segundo evento con parametros
        //        this.eventoTv(this, new TVEventsArgs());
        //        retorno = true;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //    return retorno;
        //}


        ///// <summary>
        ///// Metodo que permite modificar un objeto de tipo televisor el cual toma como referencia la "PRIMARY" en este caso es el "CODIGO" para saber 
        ///// si ese elemento existe en mi base de datos o no y asi pueda modificarlo , si el elemento no existe en mi base de datos no pasa nada ni tira excepcion
        ///// </summary>
        ///// <param name="t">televisor a modificar </param>
        ///// <returns>true si pudo modificar , false si no pudo y excepcion si </returns>
        //public static bool Modificar(Televisor t)
        //{
        //    bool retorno = false;

        //    SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
        //    SqlCommand comando = new SqlCommand();


        //    comando.CommandText = string.Format("UPDATE Televisores SET marca ='{0}',precio = {1},pulgadas = {2},pais='{3}' WHERE codigo={4}", t.marca, t.precio, t.pulgadas, t.pais, t.id); //id no se modifica porque es clave primaria
        //    comando.CommandType = System.Data.CommandType.Text;
        //    comando.Connection = conexion;

        //    try
        //    {
        //        conexion.Open();
        //        comando.ExecuteNonQuery(); //ejecuta consultas que no van a retornar ningun tipo de resultado
        //        conexion.Close();
        //        retorno = true;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //    return retorno;
        //}

        ///// <summary>
        ///// Metodo que borra un determinado objeto de tipo televisor de la base de datos de la tabla televisores teniendo en cuenta la "PRIMARY KEY"
        ///// como referencia a que objeto en especifico borrar , si  no hay un objeto con esa primary key es decir que no existe , no pasa nada y no tira excepcion
        ///// </summary>
        ///// <param name="t">objeto televisor a borrar</param>
        ///// <returns>true si pudo borrar , false si no pudo</returns>
        //public static bool Borrar(Televisor t)
        //{
        //    bool retorno = false;

        //    SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
        //    SqlCommand comando = new SqlCommand();


        //    comando.CommandText = string.Format("DELETE Televisores WHERE codigo = {0}", t.id); //id no se modifica porque es clave primaria
        //    comando.CommandType = System.Data.CommandType.Text;
        //    comando.Connection = conexion;

        //    try
        //    {
        //        conexion.Open();
        //        comando.ExecuteNonQuery(); //ejecuta consultas que no van a retornar ningun tipo de resultado
        //        conexion.Close();
        //        retorno = true;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //    return retorno;
        //}

        ///// <summary>
        ///// Metodo que retorna toda la tabla de televisores en una lista de objetos televisor desde la base de datos a programa
        ///// </summary>
        ///// <returns>lista de televisores</returns>
        //public static List<Televisor> TraerTodos()
        //{
        //    List<Televisor> televisores = new List<Televisor>();

        //    SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
        //    SqlCommand comando = new SqlCommand();

        //    comando.CommandText = "SELECT *FROM Televisores";
        //    comando.CommandType = System.Data.CommandType.Text;
        //    comando.Connection = conexion;

        //    try
        //    {
        //        conexion.Open();

        //        SqlDataReader lector = comando.ExecuteReader();

        //        while (lector.Read())
        //        {
        //            Televisor tele = new Televisor(lector.GetInt32(0), lector.GetString(1), lector.GetDouble(2), lector.GetInt32(3), lector.GetString(4));
        //            televisores.Add(tele);
        //        }
        //        conexion.Close();

        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //    return televisores;
        //}


        ///// <summary>
        ///// Metodo que se encarga de traer un objeto de tipo televisor desde la base de datos teniendo como referencia un entero
        ///// el cual refiere al codigo de ese objeto en especifico
        ///// </summary>
        ///// <param name="id">codigo del televisor a traer</param>
        ///// <returns>televisore que obtenemos de la base de datos</returns>
        //public static Televisor TraerUno(int id)//id que va a elegir para obtener
        //{
        //    Televisor tele;

        //    SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
        //    SqlCommand comando = new SqlCommand();

        //    comando.CommandText = string.Format("SELECT *FROM Televisores where codigo = {0}", id); //el *From es porque quiere todos los campos 
        //    comando.CommandType = System.Data.CommandType.Text;
        //    comando.Connection = conexion;

        //    try
        //    {
        //        conexion.Open();

        //        SqlDataReader lector = comando.ExecuteReader();

        //        lector.Read(); //es importante colocarlo sino no lee nada

        //        if (lector.HasRows)
        //        {
        //            tele = new Televisor(lector.GetInt32(0), lector.GetString(1), lector.GetDouble(2), lector.GetInt32(3), lector.GetString(4));
        //        }
        //        else
        //        {
        //            tele = null;
        //        }
        //        conexion.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //    return tele;
        //}
        //#endregion
    }


    //#region DELEGADOS SIEMPRE A NIVEL DEL NAMESPACE

    ////defino delegado a nivel de NAMESPACE
    //public delegate void MiDelegado();

    ////nuevo delegado con parametros
    //public delegate void DelegadoTV(Televisor t, TVEventsArgs args);

    //#endregion
}

