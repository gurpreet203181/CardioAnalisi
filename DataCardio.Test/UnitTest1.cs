using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {

        //punto.1   TestMethodFrequenzaMin
        [TestMethod]
        [DataTestMethod]
        [DataRow(20, 140)]
        [DataRow(33, 131)]
        [DataRow(0, -1)]
        [DataRow(-3, -1)]
        [DataRow(200, -1)]


        public void TestMethodFrequenzaMin(int età, int frequenzaMin)
        {
            double risposta_attesa = frequenzaMin;

            double risposta = CardioanalisiLibrary.DataCardio.CalcoloFrequenzaMin(età);

            Assert.AreEqual(risposta_attesa, risposta);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(20, 180)]
        [DataRow(33, 168)]
        [DataRow(0, -1)]
        [DataRow(-3, -1)]
        [DataRow(200, -1)]

        //punto.1 TestMethodFrequenzaMax
        public void TestMethodFrequenzaMax(int età, int frequenzaMax)
        {
            double risposta_attesa = frequenzaMax;

            double risposta = CardioanalisiLibrary.DataCardio.CalcoloFrequenzaMax(età);

            Assert.AreEqual(risposta_attesa, risposta);



        }
       
        //punto.2
        [TestMethod]
        [DataTestMethod]
        [DataRow(59, "Bradicardia")]
        [DataRow(60, "Normale")]
        [DataRow(100, "Normale")]
        [DataRow(87, "Normale")]
        [DataRow(120, "Tachicardia")]
        [DataRow(201, "-1")]
        public void TestMethodFreqCardiacaRiposo(int BattitiAlMinuto, string valoreFrequenza)
        {
            string risposta_attesa = valoreFrequenza;

            string risposta = CardioanalisiLibrary.DataCardio.FreqCardiacaRiposo(BattitiAlMinuto);

            Assert.AreEqual(risposta_attesa, risposta);

        }




    }

}
