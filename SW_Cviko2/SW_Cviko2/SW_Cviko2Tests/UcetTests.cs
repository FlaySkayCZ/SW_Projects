using Microsoft.VisualStudio.TestTools.UnitTesting;
using SW_Cviko2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Cviko2.Tests
{
    [TestClass()]
    public class UcetTests
    {
        [TestMethod()]
        public void DisponabilniZustatekTest()
        {
            //Arrange
            Ucet sut = new Ucet("Majitel", 1000, 1000);
            float ocekavano = 2000;

            //Act
            float vysledek = sut.DisponabilniZustatek();

            //Assert
            Assert.AreEqual(ocekavano, vysledek);

        }
        [TestMethod()]
        [ExpectedException(typeof(MyGenericException))]
        public void VlozTest_VlozeniZaporneCastky_VyvolaPositiveNumException()
        {
            //Arrange
            Ucet sut = new Ucet("Majitel", 2000, 0);
            float castka = -1000;

            //Act
            sut.Vloz(castka);

        }

        [TestMethod()]
        public void VyberTest_VyberSKontokorentem()
        {
            //Arrange
            Ucet sut = new Ucet("Majitel", 1000, 1000);
            float vyber = 1000; 
            float odekavanyVysledek = 1000;

            //Act
            float vysledekClassy = sut.DisponabilniZustatek() - vyber;

            //Assert
            Assert.AreEqual(odekavanyVysledek, vysledekClassy);
        }
        [TestMethod()]
        public void VyberTest_VyberBezKontokorentem()
        {
            //Arrange
            Ucet sut = new Ucet("Majitel", 1000, 0);
            float vyber = 1000;
            float odekavanyVysledek = 0;

            //Act
            float vysledekClassy = sut.DisponabilniZustatek() - vyber;

            //Assert
            Assert.AreEqual(odekavanyVysledek, vysledekClassy);
        }
    }
}