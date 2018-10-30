using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //using para los archivos

namespace EntidadesClase14_2
{
  public  class DepositoDeCocinas
    {
        #region Atributos

        private int _capacidadMaxima;
        private List<Cocina> _lista;

        #endregion

        #region Constructores

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        #endregion

        #region Metodos
        public bool Agregar(Cocina c)
        {
            return this + c;
        }
        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad maxima: {0}\r\n", this._capacidadMaxima);
            sb.AppendLine("Listado de Cocinas:");
            
            foreach(Cocina item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        //AGREGO METODOS QUE NO ESTAN EN EL PDF

       //Guardar (string) : bool 
       //el string que recibe es el path (ubicacion) donde guardar el archivo
       //Guarde el contenido de deposito de cocina + cada uno de los detalles de cada una de las cocinas que contenga , llama al to string
       //de cada una de las cocinas , todo esto se va a guardar en un archivo de texto
       //true si se pudo guardar el archivo 
       //false si no pudo
       //tiene que estar dentro de un try catch , si entra al cath retorno false y si solo al try retorno true
       //utilizamos streamriter para escrbiri en un archivo
         public bool Guardar(string path)
        {
            bool retorno = false;

            try
            {
                //V1
                //StreamWriter sm = new StreamWriter(path, false);
                //sm.WriteLine(this.ToString());
                //sm.Close();

                //V2
                using (StreamWriter sm = new StreamWriter(path, false))
                {
                    sm.WriteLine(this.ToString());
                }

                 retorno = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        //Recuperar(string):bool
        //string es el path 
        //Va a recuperar el archivo, es decir leer la informacion 
        //streamReader sirve para leer
        //si el archviode texto que le indico no existe , genera excepcion
        //si recuperamos hacemos el ReadToEnd

        public bool Recuperar(string path)
        {
            bool retorno = false;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
    
                    Console.WriteLine(sr.ReadToEnd());
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        #endregion

        public static bool operator +(DepositoDeCocinas d , Cocina c)
        {
            bool retorno = false;

            if (d._lista.Count + 1 <= d._capacidadMaxima)
            {
                d._lista.Add(c);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Cocina c)
        {
            int retorno = -1;
            int tam;
            int i;

            tam = this._lista.Count;

            for (i = 0; i < tam; i++)
            {

                if (this._lista[i] == c)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;

        }

        public static bool operator -(DepositoDeCocinas d , Cocina c)
        {
            bool retorno = false;
            int indice;

            indice = d.GetIndice(c);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }

            return retorno;
        }
       
    }
}
