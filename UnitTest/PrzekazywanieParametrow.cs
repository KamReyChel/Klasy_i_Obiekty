using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KartaOcenFilmow;
namespace UnitTest
{
    [TestClass]
    public class PrzekazywanieParametrow
    {
        [TestMethod]
        public void PrzekazywanieParametrowWartoscKlasa()
        {
            Karta karta1 = new Karta
            {
                Nazwa = "Kamil"
            };

            UstawNazwe(karta1);

            Assert.AreEqual("Kamil", karta1.Nazwa);
        }

        [TestMethod]
        public void PrzekazywanieParametrowWartoscInt()
        {
            int x = 10;
            ZwiekszWartosc(x);

            Assert.AreEqual(10, x);
        }
        [TestMethod]
        public void PrzekazywanieParametrowRefInt()
        {
            int x = 10;
            ZwiekszWartosc(ref x);
            Assert.AreEqual(15, x);
        }

        [TestMethod]
        public void PrzekazywanieParametrowRefKlasa()
        {
            Karta karta1 = new Karta
            {
                Nazwa = "Kamil"
            };

            UstawNazwe(ref karta1);

            Assert.AreEqual("Nowa nazwa", karta1.Nazwa);
        }




        private void ZwiekszWartosc(int x)
        {
            x = 15;
        }

        private void ZwiekszWartosc(ref int x)
        {
            x = 15;
        }

        private void UstawNazwe(Karta karta)
        {
            karta = new Karta();
            karta.Nazwa = "Nowa nazwa";
        }

        private void UstawNazwe(ref Karta karta)
        {
            karta = new Karta();
            karta.Nazwa = "Nowa nazwa";
        }
    }
}
