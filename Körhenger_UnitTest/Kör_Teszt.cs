using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KörHenger;

namespace Körhenger_UnitTest
{
    [TestClass]
    public class Kör_Teszt
    {
        [TestMethod]
        public void Kerulet_Teszt()
        {
            // Arrange - Feltételek beállítása
            double sugár = 5;
            Kör Kör = new Kör(sugár);
            double vártEredm = 31.42;

            // Act - Végrehajtás
            Kör.SetKerület();
            double kapottEredm = Kör.GetKerület();

            // Assert - Kiértékelés
            Assert.AreEqual(vártEredm, kapottEredm);

        }
        [TestMethod]
        public void Terulet_Teszt()
        {
            
        }
    }
}
