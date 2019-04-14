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

        //punto.3
        [TestMethod]
        [DataTestMethod]
        [DataRow(17, 72, 180, 15, 273)]
        [DataRow(0, 0, 0, 0, -1)]
        [DataRow(-43, -78, -170, -15, -1)]

        public void TestMethodCalorieBruciateUomo(int età, double peso, int frequenza, double durata, int CalorieBruciate)
        {
            double risposta_attesa = CalorieBruciate;

            double risposta = CardioanalisiLibrary.DataCardio.CalorieBruciateUomo(età, peso, frequenza, durata);

            Assert.AreEqual(risposta_attesa, risposta);

        }
        [TestMethod]


        [DataTestMethod]
        [DataRow(17, 72, 180, 15, 252)]
        [DataRow(0, 0, 0, 0, -1)]
        [DataRow(-43, -78, -170, -15, -1)]

        public void TestMethodCalorieBruciateDonna(int età, double peso, int frequenza, double durata, int CalorieBruciate)
        {
            double risposta_attesa = CalorieBruciate;

            double risposta = CardioanalisiLibrary.DataCardio.CalorieBruciateDonna(età, peso, frequenza, durata);

            Assert.AreEqual(risposta_attesa, risposta);



        }
        //punto.4
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 72, 130)]
        [DataRow(2.5, 80, 180)]
        [DataRow(-3, 80, -1)]
        [DataRow(3, -80, -1)]
        [DataRow(-3, -80, -1)]
        [DataRow(0, 0, -1)]
        [DataRow(0, 80, 0)]
        [DataRow(0, -80, -1)]
        [DataRow(3, 0, -1)]
        [DataRow(-3, 0, -1)]

        public void TestMethodSpesaEnergeticaCorsa(double KmPercorsi, double peso, double SpesaEnergeticaCorsa)
        {
            double risposta_attesa = SpesaEnergeticaCorsa;

            double risposta = CardioanalisiLibrary.DataCardio.SpesaEnergeticaCorsa(KmPercorsi, peso);

            Assert.AreEqual(risposta_attesa, risposta);



        }
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 70, 105)]
        [DataRow(2.5, 80, 100)]
        [DataRow(-3, 80, -1)]
        [DataRow(3, -80, -1)]
        [DataRow(-3, -80, -1)]
        [DataRow(0, 0, -1)]
        [DataRow(0, 80, 0)]
        [DataRow(0, -80, -1)]
        [DataRow(3, 0, -1)]
        [DataRow(-3, 0, -1)]



        public void TestMethodSpesaEnergeticaCamminata(double KmPercorsi, double peso, double SpesaEnergeticaCamminata)
        {
            double risposta_attesa = SpesaEnergeticaCamminata;

            double risposta = CardioanalisiLibrary.DataCardio.SpesaEnergeticaCamminata(KmPercorsi, peso);

            Assert.AreEqual(risposta_attesa, risposta);



        }

    }

}
