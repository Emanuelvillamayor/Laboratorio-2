using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //ISerializar -> Xml(string):bool
    //IDeserializar -> Xml(string, out Fruta):bool
    //Implementar (implicitamente) ISerializar en Cajon y manzana
    //Implementar (explicitamente) IDeserializar en manzana
    //Los archivos .xml guardarlos en el escritorio del cliente
    public interface IDeserializar
    {
        bool Xml(string path, out Fruta f);



    }
}
