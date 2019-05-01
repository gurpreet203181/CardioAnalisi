using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {

        //punto.1   TestMethod Frequenza Min
        [TestMethod]
        [DataTestMethod]
        [DataRow(20, 140)]
        [DataRow(33, 131)]
        [DataRow(0, -1)]
        [DataRow(-3, -1)]
        [DataRow(220, -1)]
        [DataRow(200, 14)]


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
        [DataRow(220, -1)]
        [DataRow(200, 18)]

        //punto.1 TestMethod Frequenza Max
        public void TestMethodFrequenzaMax(int età, int frequenzaMax)
        {
            double risposta_attesa = frequenzaMax;

            double risposta = CardioanalisiLibrary.DataCardio.CalcoloFrequenzaMax(età);

            Assert.AreEqual(risposta_attesa, risposta);



        }

        //punto.2 TestMethod FreqCardiaca Riposo
        [TestMethod]
        [DataTestMethod]
        [DataRow(59, "Bradicardia")]
        [DataRow(60, "Normale")]
        [DataRow(100, "Normale")]
        [DataRow(87, "Normale")]
        [DataRow(120, "Tachicardia")]
        [DataRow(220, "-1")]
        public void TestMethodFreqCardiacaRiposo(int BattitiAlMinuto, string valoreFrequenza)
        {
            string risposta_attesa = valoreFrequenza;

            string risposta = CardioanalisiLibrary.DataCardio.FreqCardiacaRiposo(BattitiAlMinuto);

            Assert.AreEqual(risposta_attesa, risposta);

        }

        //punto.3 TestMethod Calorie Bruciate Uomo
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

        //punto.3  TestMethod Calorie Bruciate Donna
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


        //punto.4 TestMethod Spesa Energetica Corsa
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


        //punto.4 TestMethod Spesa Energetica Camminata
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

        //Punto.5A TestMethod Media Giornaliera Battiti

        [TestMethod]
        
        public void TestMethodMediaGiornalieraBattiti_1()
        {
            List<int> ListaFrequenzaQuotidiano = new List<int>() {202,199,200,189,193 };
            double risposta_attesa =196.6;
           
            double risposta = CardioanalisiLibrary.DataCardio.MediaGiornalieraBattiti (ListaFrequenzaQuotidiano);

            Assert.AreEqual(risposta_attesa, risposta);


        }
        [TestMethod]

        public void TestMethodMediaGiornalieraBattiti1_2()
        {
            List<int> ListaFrequenzaQuotidiano = new List<int>() { 0, 0, 0, 0 };
            double risposta_attesa = -1;

            double risposta = CardioanalisiLibrary.DataCardio.MediaGiornalieraBattiti(ListaFrequenzaQuotidiano);

            Assert.AreEqual(risposta_attesa, risposta);


        }
        [TestMethod]

        public void TestMethodMediaGiornalieraBattiti1_3()
        {
            List<int> ListaFrequenzaQuotidiano = new List<int>() { 202, -199, 200, -2, 193 };
            double risposta_attesa = -1;

            double risposta = CardioanalisiLibrary.DataCardio.MediaGiornalieraBattiti(ListaFrequenzaQuotidiano);

            Assert.AreEqual(risposta_attesa, risposta);


        }
        [TestMethod]
        public void TestMethodMediaGiornalieraBattiti_4()
        {
            List<int> ListaFrequenzaQuotidiano = new List<int>() { 220, 1994, 200, 189, 193 };
            double risposta_attesa = -1;

            double risposta = CardioanalisiLibrary.DataCardio.MediaGiornalieraBattiti(ListaFrequenzaQuotidiano);

            Assert.AreEqual(risposta_attesa, risposta);


        }

        //Punto.5B TestMethod IlBattitoCardiaco_A_Riposo
        [TestMethod]
        [DataTestMethod]
        [DataRow(59, "Bradicardia")]
        [DataRow(60, "Normale")]
        [DataRow(100, "Normale")]
        [DataRow(87, "Normale")]
        [DataRow(120, "Tachicardia")]
        [DataRow(220, "-1")]
        public void TestMethodBattitoCardiaco_A_Riposo(int BattitiAlMinuto, string valoreFrequenza)
        {
            string risposta_attesa = valoreFrequenza;

            string risposta = CardioanalisiLibrary.DataCardio.FreqCardiacaRiposo(BattitiAlMinuto);

            Assert.AreEqual(risposta_attesa, risposta);

        }

        //Punto 5c
        [TestMethod]
        public void TestHRV1()
        {

            double risposta_attesa = 1.93;
            List<double> TempoTraDueBattiti = new List<double> { 0.8, 1.2, 1.0, 0.6, 0.9 };
            double frequenza = CardioanalisiLibrary.DataCardio.HRV(TempoTraDueBattiti);
            Assert.AreEqual(risposta_attesa, frequenza);
        }

        [TestMethod]
        public void TestHRV2()
        {

            double risposta_attesa = -1;
            List<double> tempitempotraduebatti = new List<double> { 8, 1.2, 2.2, 0.6, 0.9 };
            double frequenza = CardioanalisiLibrary.DataCardio.HRV(tempitempotraduebatti);
            Assert.AreEqual(risposta_attesa, frequenza);
        }
        [TestMethod]
        public void TestHRV3()
        {

            double risposta_attesa = -1;
            List<double> tempitempotraduebatti = new List<double> { 0.8, 1.2, -1, 0.6, 0.9 };
            double frequenza = CardioanalisiLibrary.DataCardio.HRV(tempitempotraduebatti);
            Assert.AreEqual(risposta_attesa, frequenza);
        }
        [TestMethod]
        public void TestHRV4()
        {

            double risposta_attesa = -1;
            List<double> tempitempotraduebatti = new List<double> { 0, 1.2, -1, 0.6, 0.9 };
            double frequenza = CardioanalisiLibrary.DataCardio.HRV(tempitempotraduebatti);
            Assert.AreEqual(risposta_attesa, frequenza);
        }



        //Punto.5D
        [TestMethod]
        public void OrdineCrescente_Dei_Battiti_1()
        {
            List<int> ListaFrequenzaDuranteGiornata = new List<int>() { 202, 199, 200, 189, 193 };
            List<int> risposta_attesa = new List<int>() {189,193,199,200,202 };

            List<int> risposta = CardioanalisiLibrary.DataCardio.OrdineCrescente_Dei_Battiti(ListaFrequenzaDuranteGiornata);

            CollectionAssert.AreEqual(risposta_attesa, risposta);


        }
        [TestMethod]
        public void OrdineCrescente_Dei_Battiti_2()
        {
            List<int> ListaFrequenzaDuranteGiornata = new List<int>() { 0, 0, 0, 0, 0 };
            List<int> risposta_attesa = new List<int>() { -1};

            List<int> risposta = CardioanalisiLibrary.DataCardio.OrdineCrescente_Dei_Battiti(ListaFrequenzaDuranteGiornata);

            CollectionAssert.AreEqual(risposta_attesa, risposta);


        }
        [TestMethod]
        public void OrdineCrescente_Dei_Battiti_3()
        {
            List<int> ListaFrequenzaDuranteGiornata = new List<int>() { 202, -199, 200, -2, 193 };
            List<int> risposta_attesa = new List<int>() { -1 };

            List<int> risposta = CardioanalisiLibrary.DataCardio.OrdineCrescente_Dei_Battiti(ListaFrequenzaDuranteGiornata);

            CollectionAssert.AreEqual(risposta_attesa, risposta);


        }
        public void OrdineCrescente_Dei_Battiti_4()
        {
            List<int> ListaFrequenzaDuranteGiornata = new List<int>() {  };
            List<int> risposta_attesa = new List<int>() { -1 };

            List<int> risposta = CardioanalisiLibrary.DataCardio.OrdineCrescente_Dei_Battiti(ListaFrequenzaDuranteGiornata);

            CollectionAssert.AreEqual(risposta_attesa, risposta);


        }

    }

}
