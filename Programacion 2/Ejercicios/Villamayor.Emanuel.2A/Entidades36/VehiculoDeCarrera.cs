using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades36
{
    public class VehiculoDeCarrera
    {
        #region Atributos

        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        #endregion

        #region Propiedades

        public short CantidadCombustible
        {
            get
            {
                return this._cantidadCombustible;
            }
            set
            {
                this._cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this._enCompetencia;
            }
            set
            {
                this._enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this._escuderia;
            }
            set
            {
                this._escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this._numero;
            }
            set
            {
                this._numero = value;
            }
        }

        public short VuletasRestantes
        {
            get
            {
                return this._vueltasRestantes;
            }
            set
            {
                this._vueltasRestantes = value;
            }
        }

        #endregion

        #region Constructores

        public VehiculoDeCarrera(short numero , string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
            this._cantidadCombustible = 0;
            this._enCompetencia = false;
            this._vueltasRestantes = 0;
        }

        #endregion

        #region Metodos

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Numero : {0}\n", this._numero);
            sb.AppendFormat("En Competencia : {0}\n", this._enCompetencia);
            sb.AppendFormat("Cantidad Combustible : {0}\n", this._cantidadCombustible);
            sb.AppendFormat("Vueltas Restantes: {0}\n", this._vueltasRestantes);
            sb.AppendFormat("Escuderia : {0}\n", this._escuderia);

            return sb.ToString();
        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator == ( VehiculoDeCarrera v1 , VehiculoDeCarrera v2)
        {
            bool retorno = false;

            if(v1._numero== v2._numero && v1._escuderia== v2._escuderia)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

        #endregion
    }
}
