using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase07
{
   public class PaletaColleccion
    {
        #region ATRBUTOS

        private List<Tempera>  _colores;
        private int _cantMaximaElementos; //indica siempre cant max de elementos del array

        #endregion

        #region PROPIEDADES

        public int cantiadTemperas{
            get
            {
                return this._colores.Count;
            }
        }

        #endregion

        #region METODOS
        //muestre contenido completo de la paleta , es decir cant maxima y descripcion detallada de todos sus colores
        //llamo al explicit de tempera

        private string Mostrar()
        {
            // string retorno = "Cantidad maxima de elementos: " + this._cantMaximaElementos + "\r\n";
            string retorno = "";

            foreach (Tempera item in this._colores) //this.colores hace referencia al atributo de Paleta de array de temperas
            {
                if (!(Object.Equals(item, null)))
                {
                    retorno += item;         //llama al implicit de tempera que devuelve el mostrar con todos sus datos      
                    retorno += "\r\n";//sirve para mostrarlo uno abajo del otro
                }
            }
            return retorno;
        }

        public static explicit operator string(PaletaColleccion p)
        {
            return p.Mostrar();
        }

        //implicit entre entero y paleta e internamente invoco al constructor

        public static implicit operator PaletaColleccion(int cant)
        {
            PaletaColleccion retorno = new PaletaColleccion(cant);
            return retorno;
        }
        //true si una tempera esta en la paleta , lo que hago es recorrer el array de colores y preguntar por el == que definimos en tempera

        public static bool operator ==(PaletaColleccion p, Tempera t)
        {
            bool retorno = false;
            if ((!(object.Equals(t, null))))
            {
                foreach (Tempera t2 in p._colores)
                {
                    if ((!(object.Equals(t2, null))))   //valido que el array de temperas de paleta este completo y no tenga null
                    {
                        if (t2 == t)
                        {
                            retorno = true;
                            break;
                        }
                    }
                }

                //Esta forma tambien funciona

                /*  for(i=0;i<p._cantMaximaElementos;i++)
                    {
                        if(p._colores.GetValue(i)!=null)
                        {
                            if(p._colores[i]==t)
                            {
                                retorno = true;
                                break;
                            }
                        }
                    }*/
            }
            return retorno;
        }

        public static int operator ==(Tempera t,  PaletaColleccion p)
        {
            int indice=-1;
            int contador = 0;
            foreach(Tempera item in  p._colores)
            {
               
                    if (item == t)
                    {
                        indice = contador;
                    }
                
               contador++;
            }
            return indice;
        }
        public static int operator !=(Tempera t , PaletaColleccion p)
        {       
            return t==p;
        }


        public static bool operator !=(PaletaColleccion p, Tempera t)
        {
            return !(p == t);
        }

        // el operador + agrega color(temperas) a nuestra paleta
        //si a tempera esta en la PALETA , se acumulan las cantidades en el lugar de la tempera
        //ejemplo tengo el rojocon cantidad 5 y si traigo otra roja con 6 , se acumula y queda 11
        //si no esta el color , a la primera vez que quiera ingresar algo , permite agreagr la tempera
        //en el primer lugar libre,como lo busco :
        //metodo privado de instancia obtener indice que retorna entero , lo que hace es recorrer el aray de colores
        //y retornar el Indice cuando encontro el primer null
        // y si esta toda ocupada agrego un valor como guia ejemplo -1

        //devuelva el indice donde se aloja esa tempera , si no esta dentro del array devuelve  negativo

             
       
        public static PaletaColleccion operator +(PaletaColleccion p, Tempera t)
        {

            int indice;

            if (!object.Equals(p, null) && !object.Equals(t, null))
            {
                indice = (t == p);
                if (indice != -1)
                {
                    p._colores[indice] += t;
                    
                }
                else
                {
                    if(p._colores.Count<p._cantMaximaElementos)                 
                    {
                        p._colores.Add(t);
                    }
                }

            }
            return p;
        }


        //quitar tempera , si la temepra esta en la paleta , resto las cantidades
        //tengo un roja de 10 y otra de 2 , resultado una roja con valor 8
        //pero si la resta da menor a 0 , no tengo que restarlo sino quitar la tempera de esa paleta colocando NULL
        //

        public static PaletaColleccion operator -(PaletaColleccion p, Tempera t)
        {
            int indice;
            sbyte aux;
            sbyte aux2;


            indice = (t == p);
                if (indice != -1)
                {
                    aux = (sbyte)p._colores[indice];
                    aux2 = (sbyte)t;                                  

                    if (aux-aux2 <= 0)
                    {

                    // p._colores.Remove(p._colores[indice]);
                    p._colores.RemoveAt(indice);
                    }
                    else
                    {
                        p._colores[indice] += ((sbyte)(aux2 * (-1)));
                    }
                }           
            return p;
        }

        #endregion

        #region CONSTRUCTOR

        private PaletaColleccion() : this(5)
        {

        }

        private PaletaColleccion(int cant)
        {
            this._cantMaximaElementos = cant;
            //this._colores = new Tempera[this._cantMaximaElementos];
            this._colores = new List<Tempera>(this._cantMaximaElementos);
        }
        #endregion

        #region INDEXADOR
        public Tempera this[int indice]
        {


            get 
            {
                if (indice >= this._colores.Count() || indice < 0 && indice <this._cantMaximaElementos)
                    return null;
                else
                    return this._colores[indice];
            }
            set
            {
                if (indice >= 0 && indice < this._cantMaximaElementos)
                    this._colores[indice] = value;
                else
                {
                    Console.WriteLine("Valor erroneo");
                }
             

            }
              /*if (indice >= 0 && indice< this._capitulos.GetLength(0))
                    this._capitulos[indice] = value;
                else if (indice == this._capitulos.GetLength(0)){

                    this._capitulos = this + indice;
                    this[indice] = value;
                }
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }*/
        }
       

        #endregion
    }
}
    
//generar indexador que recorra la clase tempera
//una vez que tengo el indice hago this.pale[0] y ya le puedo pasar el indice asi



    //genero sobre carga del == que retrçorne el indice