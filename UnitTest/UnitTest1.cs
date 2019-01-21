using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KartaOcenFilmow;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool wartosc = true;


            Assert.IsTrue(wartosc);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int zmienna = 35;
            Assert.AreEqual(35, zmienna);
        }
        [TestMethod]
        public void ObliczenieSredniejWartosci()
        {
            Karta karta = new Karta();
            karta.DodajOcene(4);
            karta.DodajOcene(9);
            karta.DodajOcene(5);
            karta.DodajOcene(2);
            KartaStatystyki stat = karta.ObliczStatystyki();

            Assert.AreEqual(5.0, stat.SredniaOcena);

        }
    }
}
