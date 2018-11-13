using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades47
{
    public class Araña : Animal, Mascota
    {
        #region Constructores

        public Araña()
        {

        }

        public Araña(int patas): base(patas)
        {

        }

        #endregion
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Comer()
        {
            return "Insectos";
        }

        public void Jugar()
        {
            Console.WriteLine("Juega con telaraña");
        }

        public override string Caminar()
        {
            return "Este animal camina sobre 8 patas";
        }
    }
}
