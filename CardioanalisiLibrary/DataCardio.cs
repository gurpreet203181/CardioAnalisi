using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    public class DataCardio
    {
        //Punto.1
        //Metodo per calcolare il frequenzaMin 
        public static int CalcoloFrequenzaMin(int età)
        {
            int Controllo = Controlli.ControlloEta(età);//Richiamo il class controlli per controllare la età
            int frequenzaMin = 0;

            if (Controllo != -1)//se il metodo restituisce un valore int diverso da -1  significa che controlli sono andati bene.

            {
                int frequenzaConsigliata = 220 - età;

                frequenzaMin = Convert.ToInt32(frequenzaConsigliata * 0.7);
            }
            else
            {
                frequenzaMin = -1;

            }




            return frequenzaMin;
        }

        //Metodo per calcolare il frequenzaMax 
        public static int CalcoloFrequenzaMax(int età)
        {
            int Controllo = Controlli.ControlloEta(età);//Richiamo il class controlli per controllare la età
            int frequenzaMax = 0;

            if (Controllo != -1)//se il metodo restituisce un valore int diverso da -1  significa che controlli sono andati bene.
            {
                int frequenzaConsigliata = 220 - età;

                frequenzaMax = Convert.ToInt32(frequenzaConsigliata * 0.9);
            }
            else
            {
                frequenzaMax = -1;

            }

            return frequenzaMax;
        }

        //punto.2

        //Metodo che permetta di interpretare i valori di frequenza cardiaca a riposo
        public static string FreqCardiacaRiposo(int BattitiAlMinuto)
        {
            string valoreFrequenza = "";
            int ControlloFrequenza = Controlli.ControlloFrequenza(BattitiAlMinuto);//Richiamo il class controlli e metodo controlloFrequenza per fare controlli sull frequenza inserita
            if (ControlloFrequenza != -1)
            {
                if (BattitiAlMinuto < 60)
                {
                    valoreFrequenza = "Bradicardia";

                }
                else if (BattitiAlMinuto >= 60 && BattitiAlMinuto <= 100)
                {
                    valoreFrequenza = "Normale";


                }
                else if (BattitiAlMinuto > 100)
                {
                    valoreFrequenza = "Tachicardia";
                }
            }
            else
            {
                valoreFrequenza = "-1";
            }
            return valoreFrequenza;
        }


        //Punto.3
        //metodo che calcola le calorie che hai bruciato durante la sessione di esercizi per gli uomini.


        public static int CalorieBruciateUomo(int età, double peso, int frequenza, double durata)
        {
            int CalorieBruciate = 0;
            int ControlloEtà = Controlli.ControlloEta(età);//Richiamo il class controlli e metodo controlloEta per fare controlli sull  età inserita
            double ControlloPeso = Controlli.ControlloPeso(peso);//Richiamo il class controlli e metodo controlloPeso per fare controlli sull peso inserita
            int ControlloFrequenza = Controlli.ControlloFrequenza(frequenza);//Richiamo il class controlli e metodo controlloFrequenza per fare controlli sull frequenza inserita
            double ControlloDurata = Controlli.ControlloDurata(durata);//Richiamo il class controlli e metodo controllodurata per fare controlli sull  tempo inserita

            if (ControlloEtà != -1 && ControlloPeso != -1 && ControlloFrequenza != -1 && ControlloDurata != -1)
            {
                CalorieBruciate = Convert.ToInt32(((età * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * durata / 4.184);


            }
            else
            {
                CalorieBruciate = -1;
            }




            return CalorieBruciate;
        }
        //metodo che calcola le calorie che hai bruciato durante la sessione di esercizi per gli donne.
        public static int CalorieBruciateDonna(int età, double peso, int frequenza, double durata)
        {
            int CalorieBruciate = 0;
            int ControlloEtà = Controlli.ControlloEta(età);//Richiamo il class controlli e metodo controlloEta per fare controlli sull  età inserita
            double ControlloPeso = Controlli.ControlloPeso(peso);//Richiamo il class controlli e metodo controlloPeso per fare controlli sull peso inserita
            int ControlloFrequenza = Controlli.ControlloFrequenza(frequenza);//Richiamo il class controlli e metodo controlloFrequenza per fare controlli sull frequenza inserita
            double ControlloDurata = Controlli.ControlloDurata(durata);//Richiamo il class controlli e metodo controllodurata per fare controlli sull  tempo inserita


            if (ControlloEtà != -1 && ControlloPeso != -1 && ControlloFrequenza != -1 && ControlloDurata != -1)
            {
                CalorieBruciate = Convert.ToInt32(((età * 0.074) + (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * durata / 4.184);

            }
            else
            {
                CalorieBruciate = -1;
            }




            return CalorieBruciate;
        }



        //Punto. 4
        //metodo che permetta di calcolare la spesa energetica che si effettua in caso di corsa
        public static double SpesaEnergeticaCorsa(double KmPercorsi, double peso)
        {
            double SpesaEnergetica = 0;

            double ControlloPeso = Controlli.ControlloPeso(peso);//Richiamo il class controlli e metodo controlloPeso per fare controlli sull peso inserita
            double ControlloKmPercorsi = Controlli.ControlloKmPercorsi(KmPercorsi);//Richiamo il class controlli e metodo controlloKmPercorsi per fare controlli sull Km percorsi inseriti


            if (ControlloPeso != -1 && ControlloKmPercorsi != -1)
            {
                SpesaEnergetica = Math.Round(0.9 * KmPercorsi * peso);
            }
            else
            {
                SpesaEnergetica = -1;
            }

            return SpesaEnergetica;
        }

        //metodo che permetta di calcolare la spesa energetica che si effettua in caso di camminata
        public static double SpesaEnergeticaCamminata(double KmPercorsi, double peso)
        {
            double SpesaEnergetica = 0;

            double ControlloPeso = Controlli.ControlloPeso(peso);//Richiamo il class controlli e metodo controlloPeso per fare controlli sull peso inserita
            double ControlloKmPercorsi = Controlli.ControlloKmPercorsi(KmPercorsi);//Richiamo il class controlli e metodo controlloKmPercorsi per fare controlli sull Km percorsi inseriti



            if (ControlloPeso != -1 && ControlloKmPercorsi != -1)
            {
                SpesaEnergetica = Math.Round(0.50 * KmPercorsi * peso);
            }
            else
            {
                SpesaEnergetica = -1;
            }

            return SpesaEnergetica;
        }


        //Punto.5A
        //metodo che permetta di calcolare La media giornaliera dei battiti

        public static double MediaGiornalieraBattiti(List<int> ListaFrequenzaQuotidiano)//Come utente parametro devi dare una lista di frequenza cardiaca di tipo int
        {
            double risultato = 0;
            bool flag = true;

            for (int i = 0; i < ListaFrequenzaQuotidiano.Count; i++)
            {
                int controlloFreq = Controlli.ControlloFrequenza(ListaFrequenzaQuotidiano[i]);//Richiamo il class controlli e metodo controlloFrequenza per fare controlli sull frequenza inserita
                if (controlloFreq == -1)
                {
                    risultato = -1;
                    flag = false;

                }
                else if (flag)
                {
                    risultato = ListaFrequenzaQuotidiano.Average();
                }

            }


            return risultato;
        }
        //Punto.5B Metodo che permetta di interpretare i valori di frequenza cardiaca a riposo
        public static string BattitoCardiaco_A_Riposo(int BattitiAlMinuto)
        {
            string risultato = FreqCardiacaRiposo(BattitiAlMinuto);//Richiamo metodo FreqCardiacaRiposo che interpretare i valori di frequenza cardiaca a riposo

            return risultato;
        }



    }
}
