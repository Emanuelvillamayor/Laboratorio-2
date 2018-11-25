using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace Entidades
{
    //Crear las interfaces: 
    //ISerializar -> Xml(string):bool
    //IDeserializar -> Xml(string, out Fruta):bool
    //Implementar (implicitamente) ISerializar en Cajon y manzana
    //Implementar (explicitamente) IDeserializar en manzana
    //Los archivos .xml guardarlos en el escritorio del cliente

    public delegate void PrecioExcedido(object sender);

    public class Cajon<T>:ISerializar
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;
        public event PrecioExcedido eventoPrecio;
        public List<T> Elementos
        {
            get
            {
                return this._elementos;
            }
        }

        //Si el precio total del cajon supera los 55 pesos, se disparará el evento EventoPrecio. 
        //Diseñarlo (de acuerdo a las convenciones vistas) en la clase cajon. 
        //Crear el manejador necesario para que se imprima en un archivo de texto: 
        //la fecha (con hora, minutos y segundos) y el total del precio del cajón en un nuevo renglón.
        public double PrecioTotal
        {
            get
            {
                if((this._precioUnitario*this._elementos.Count)>55)
                {
                    this.eventoPrecio(this);
                }

              return  this._precioUnitario * this._elementos.Count;
             
            }
         }

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad): this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precioUnitario,int capacidad ) : this(capacidad)
        {
            this._precioUnitario = precioUnitario;
        }


        //ToString: Mostrará en formato de tipo string, la capacidad, la cantidad total de elementos, el precio total 
        //y el listado de todos los elementos contenidos en el cajón. Reutilizar código.
        //Sobrecarga de operador
        //(+) Será el encargado de agregar elementos al cajón, siempre y cuando no supere la capacidad del mismo.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad: {0}", this._capacidad);
            sb.AppendFormat("Cantidad total de elementos: {0}", this._elementos.Count);
            sb.AppendFormat("Precio Total: {0}",this.PrecioTotal);

           foreach(T item in this._elementos )
            {
                if(item!=null)
                {
                    sb.AppendLine(item.ToString());
                }
                
              
            }

            return sb.ToString();
        }

       
        public bool Xml(string path)
        {
            string path2 = @"\" + path;
            bool retorno = false;
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Cajon<T>));
                XmlTextWriter xw = new XmlTextWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + path2), Encoding.UTF8);

                sr.Serialize(xw, this);
                xw.Close();
                retorno = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return retorno;


        }

        public static Cajon<T> operator + (Cajon<T> cajon,T item)
        {
            

            if(cajon._elementos.Count+1 <=cajon._capacidad )
            {
                if(cajon.PrecioTotal<=55)
                {
                    cajon._elementos.Add(item);
                }
                else
                {
                    cajon.eventoPrecio(cajon);
                }
               
            }
            else
            {
                throw new CajonLlenoException("El cajon esta lleno");

            }
            return cajon;
        }


    }

   
}
