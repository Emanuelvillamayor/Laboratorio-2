using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {

        #region Constructores

        public DirectorTecnico(string nombre , string apellido) : base(nombre,apellido)
        {

        }

        #endregion


        #region Metodos

        protected override string FichaTecnica()
        {
            string retorno = "";
            retorno += base.NombreCompleto();
            return retorno;
        }

        #endregion

        #region Sobreescritura

        public override string ToString()
        {
            return this.FichaTecnica();
        }

        #endregion



    }
}
