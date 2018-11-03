using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesInstanciables;
using EntidadesAbstractas;
namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarNacionalidadInvalidaExcepcion()
        {
            try
            { 
                Alumno a1 = new Alumno(2, "lucas", "villalba", "23456578", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);//le ingreso un dni por debajo de la nacionalidad que tiene
                Assert.Fail("Deberia avisar que el dni es incorrecto de acuerdo a la nacionalidad");
                
            }
            catch(NacionalidadInvalidaException e)
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
         public void ValidarDniInvalidoExcepcion()
        {
            try
            {
                Alumno a1 = new Alumno(2, "lucas", "villalba", "asd", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);//le ingreso un dni con otro formato
                Assert.Fail("Deberia avisar que el dni es incorrecto de acuerdo al formato");
            }
            catch(DniInvalidoException e)
            {
                Assert.IsTrue(true);
            }



        }

    }
}
