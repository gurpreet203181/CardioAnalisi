using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    class Controlli
    {
        //metodo per controllare età 
        public static int ControlloEta(int età)
        {
            int risultato = 0;
            try
            {
                Convert.ToInt32(età);
                if (età > 0 && età <= 120)
                {
                    risultato = 1;
                }
                else
                {
                    risultato = -1;
                }

            }
            catch (Exception)
            {
                risultato = -1;
            }


            return risultato;
        }


        //metodo per controllare frequenza
        public static int ControlloFrequenza(int frequenza)
        {
            int risultato = 0;
            try
            {
                Convert.ToInt32(frequenza);
                if (frequenza > 0 && frequenza <= 200)
                {
                    risultato = 1;
                }
                else
                {
                    risultato = -1;
                }

            }
            catch (Exception)
            {
                risultato = -1;
            }


            return risultato;
        }

    }
}
