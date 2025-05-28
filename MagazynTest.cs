using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    [TestClass]

    public class MagazynTest
    {
        [TestMethod]
        public void Dodanie_produktow()
        {
            var magazyn = new Magazyn();
            magazyn.dodajProdukt("Jajka", 30);
            Assert.IsTrue(magazyn.zdejmijProdukt("Jajka", 15));
            Assert.AreEqual(15, magazyn.sprawdzStan("Jajka"));
        }

        [TestMethod]
        public void Zdejmowanie_produktow()
        {
            var magazyn = new Magazyn();
            magazyn.dodajProdukt("Jajka", 20);
            Assert.IsTrue(magazyn.zdejmijProdukt("Jajka", 15));
            Assert.AreEqual(5, magazyn.sprawdzStan("Jajka"));
        }
        [TestMethod]
        public void Zdejmowanie_produktowZaDuz0()
        {
            var magazyn = new Magazyn();
            magazyn.dodajProdukt("Jajka", 10);
            Assert.IsFalse(magazyn.zdejmijProdukt("Jajka", 20));
            Assert.AreEqual(10, magazyn.sprawdzStan("Jajka"));
        }
    }
}

