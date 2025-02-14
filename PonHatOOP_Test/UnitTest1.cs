using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PonHatOOP;

namespace PonHatOOP_Test
{
    [TestClass]
    public class PontHatTests
    {
        private PontHat _pontHat;

        [TestMethod]
        public void Test_Pontszam_True()
        {
            // Teszteljük a valid pontszámokat
            _pontHat.PontszamBeallitas(50);
            Assert.AreEqual("Pontszám: 50, Osztályzat: 2", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(65);
            Assert.AreEqual("Pontszám: 65, Osztályzat: 3", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(80);
            Assert.AreEqual("Pontszám: 80, Osztályzat: 4", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(90);
            Assert.AreEqual("Pontszám: 90, Osztályzat: 5", _pontHat.Eredmeny());
        }

        [TestMethod]
        public void Test_Pontszam_False()
        {
            // Teszteljük a hibás pontszámokat
            ArgumentException ex = Assert.ThrowsException<ArgumentException>(() => _pontHat.PontszamBeallitas(-1));
            Assert.AreEqual("Hibás pontszám! A pontszám 0 és 100 között kell legyen.", ex.Message);

            ex = Assert.ThrowsException<ArgumentException>(() => _pontHat.PontszamBeallitas(101));
            Assert.AreEqual("Hibás pontszám! A pontszám 0 és 100 között kell legyen.", ex.Message);
        }

        [TestMethod]
        public void Test_HatarErtek()
        {
            // Teszteljük a határértékeket
            _pontHat.PontszamBeallitas(49);
            Assert.AreEqual("Pontszám: 49, Osztályzat: 1", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(50);
            Assert.AreEqual("Pontszám: 50, Osztályzat: 2", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(64);
            Assert.AreEqual("Pontszám: 64, Osztályzat: 2", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(65);
            Assert.AreEqual("Pontszám: 65, Osztályzat: 3", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(79);
            Assert.AreEqual("Pontszám: 79, Osztályzat: 3", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(80);
            Assert.AreEqual("Pontszám: 80, Osztályzat: 4", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(89);
            Assert.AreEqual("Pontszám: 89, Osztályzat: 4", _pontHat.Eredmeny());

            _pontHat.PontszamBeallitas(90);
            Assert.AreEqual("Pontszám: 90, Osztályzat: 5", _pontHat.Eredmeny());
        }
    }
}

