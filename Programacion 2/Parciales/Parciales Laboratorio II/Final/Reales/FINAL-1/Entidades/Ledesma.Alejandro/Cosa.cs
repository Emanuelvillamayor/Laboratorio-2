using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cosa<T>
    {
        private List<T> _elementos;

        public int Count
        {
            get { return this._elementos.Count; }
        }

        public Cosa()
        {
            this._elementos = new List<T>();
        }

        public void Add(T e)
        {
            this._elementos.Add(e);
        }
        public void Remove(T e)
        {
            this._elementos.Remove(e);
        }
    }
}
