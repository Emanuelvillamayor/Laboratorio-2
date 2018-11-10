using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades41;
namespace Test44
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarInstanciaListaLlamadas()
        {
            Centralita c = new Centralita();
            Assert.IsNotNull(c.Llamadas);

        }

        [TestMethod]
        public void ValidarCentralitaExcepcionLocal()
        {
            Centralita centralita = new Centralita();
            Local local = new Local("111", 20, "222", 400);
            Local local2 = new Local("111", 4330, "222", 300);

            try
            {
                centralita += local;
                centralita += local2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void ValidarCentralitaExcepcionProvincial()
        {
            Centralita centralita = new Centralita();
            Provincial provincial = new Provincial("111", EFranja.Franja_1, 544, "222");
            Provincial provincial2 = new Provincial("111", EFranja.Franja_2, 478, "222");

            try
            {
                centralita += provincial;
                centralita += provincial2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void ValidarComparacionLlamadas()
        {
            Local local = new Local("111", 20, "222", 400);
            Local local2 = new Local("111", 4330, "222", 300);
            Provincial provincial = new Provincial("111", EFranja.Franja_1, 544, "222");
            Provincial provincial2 = new Provincial("111", EFranja.Franja_2, 478, "222");
            Assert.IsTrue(local == local2);
            Assert.IsFalse(local == provincial);
            Assert.IsFalse(local == provincial2);

            Assert.IsTrue(local2 == local);
            Assert.IsFalse(local2 == provincial);
            Assert.IsFalse(local2 == provincial2);

            Assert.IsFalse(provincial == local);
            Assert.IsFalse(provincial == local2);
            Assert.IsTrue(provincial == provincial2);

            Assert.IsFalse(provincial2 == local);
            Assert.IsFalse(provincial2 == local2);
            Assert.IsTrue(provincial2 == provincial);
        }
    }
}
