using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodiConversioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] b = { true, false, true, false }; //numero binario
            Console.WriteLine("Conversione da binario a intero:");
            Console.WriteLine(Convert_Binario_To_Intero(b));
            Console.WriteLine("===============");
            int[] dp = { 10, 100, 2, 4 }; //numero decimale puntato
            Console.WriteLine("Conversione da decimale puntato a intero:");
            Console.WriteLine(Convert_Decimale_Puntato_To_Decimale(dp));
            Console.ReadLine();
        }
        static int Convert_Binario_To_Intero(bool[] b)
        {
            int nIntero = 0; //numero intero che verrà convertito
            int esponente = 0; //viene incrementato ad ogni ciclo
            for (int i = b.Length - 1; i >= 0; i--) //ciclo che viene decrementato ad ogni iterazione
            {
                if (b[i])
                {
                    nIntero = nIntero + (int)Math.Pow(2, esponente); //formula di conversione
                }
                esponente++;
            }
            return nIntero; //numero intero convertito
        }
        static int Convert_Decimale_Puntato_To_Decimale(int[] dp)
        {
            int nIntero = 0;
            int esponente = 0;
            for (int i = dp.Length - 1; i >= 0; i--)
            {
                nIntero = nIntero + dp[i] * (int)Math.Pow(256, esponente);
                esponente++;
            }
            return nIntero;
        }
    }
}
