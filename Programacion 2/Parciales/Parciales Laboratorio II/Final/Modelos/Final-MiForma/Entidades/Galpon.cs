using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    //Generar la clase genérica Galpon. Dicha clase tendrá el atributo _elementos:List del tipo genérico.
    //(este sólo se podrá inicializar en el constructor por defecto, que además será privado)
    //y _capacidad:int (generar un constructor que lo reciba como parámetros).
    //Realizar el método Add, que permite agregar un elemento a la colección. 
    //Cada elemento par agregado en la clase Galpon, disparará un evento (ElementosParesEvent).
    //Asociar el manejador del evento anterior a un método de instancia del formulario. 
    //Mostrar en dicho manejador las características por MessageBox.

    public delegate void ElementosParesEvent(object sender, EventArgs e);

    public class Galpon<T>
    {

        #region Atributos

        public List<T> _elementos;
        public int capacidad;
        public EventArgs eve;
        public event ElementosParesEvent evento;
        #endregion

        #region Constructores

        private Galpon()
            {
            this._elementos = new List<T>();
            }
        public Galpon(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        #endregion

        public void Add( T elemento)
        {
            if(this._elementos.Count+1 <=this.capacidad)
            {
                this._elementos.Add(elemento);
                if((this._elementos.Count%2)==0)
                {
                   this.evento(elemento, eve);
                }
            }
        

        }
    }
}
