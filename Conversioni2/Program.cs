using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversioni2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] b = { true, false, true, false };
            int[] dp = { 10, 10, 10, 10 };
            long numero = 124352562;

            int[] bin_decPuntato = new int[4];
            bool[] decPuntato_bin= new bool[32];
            int[] dec_decPuntato = new int[4];
            bool[] dec_bin = new bool[32];

            Console.WriteLine($"\nda binario a decimale puntato");
            bin_decPuntato = Convert_Binario_To_Decimale_Puntato(b);
            for(int i=0; i<bin_decPuntato.Length; i++)
            {
                Console.Write(bin_decPuntato[i] + " ");
            }
            Console.WriteLine($"\nda decimale puntato a binario");
            decPuntato_bin = Convert_Decimale_Puntato_To_Binario( dp);
            for (int i = 0; i < decPuntato_bin.Length; i++)
            {
                if (decPuntato_bin[i] == true)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine($"\nda decimale a decimale puntato ");
            dec_decPuntato = Convert_Numero_Decimale_To_Decimale_Puntato( numero);
            for (int i = 0; i < dec_decPuntato.Length; i++)
            {
                Console.Write(dec_decPuntato[i] + " ");
            }
            Console.WriteLine($"\nda decimale a binario");
            dec_bin = Convert_Numero_Decimale_To_Binario(numero);
            for (int i = 0; i < dec_bin.Length; i++)
            {
                if (dec_bin[i]==true)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
                
            }
            Console.ReadLine();

        }
        static int[] Convert_Binario_To_Decimale_Puntato(bool[] b)
        {
            int[] dp = new int[4];
            int k = b.Length - 1;
            double numero = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (b[k])
                    {
                        numero = numero + (1 * Math.Pow(2, i));
                        k -- ; 
                        }
                }
                dp[j] = Convert.ToInt32(numero);
                numero = 0;
            }
            return dp;


        }


        static bool[] Convert_Decimale_Puntato_To_Binario(int[] dp)
        {
            bool[] b = new bool[dp.Length * 8];
            int numero;
            for (int i = 0; i < dp.Length; i++)
            {
                numero = (int)dp[i];
                numero = (int)dp[i];
                for (int j = 7; j >= 0 && numero > 0; j--)
                {
                    if (numero % 2 == 1)
                    {
                        b[j + i * 8] = true;
                    }
                    numero = numero / 2;
                }
            }
            return b;

        }

        static int[] Convert_Numero_Decimale_To_Decimale_Puntato(long numero)
        {
            int[] dp = new int[4];
            for (int i = 0; i < dp.Length && numero > 0; i++)
            {
                dp[dp.Length - i - 1] = (int)(numero % 256);
                numero = numero / 256;
            }
            return dp;
        }

        static bool[] Convert_Numero_Decimale_To_Binario(long numero)
        {
            bool[] b = new bool[32];
            for (int i = b.Length - 1; i >= 0 && numero > 0; i--)
            {
                if (numero % 2 == 1)
                {
                    b[i] = true;
                }
                numero = numero / 2;
            }
            return b;

        }
    }
}
