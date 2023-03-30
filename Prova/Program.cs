using System;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valori = new int[5];
            int min = valori[0];

            for(int i =0; i<valori.Length; i++)
            {
                Console.Write("Dimmi un valore intero: ");
                valori[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= valori.Length - 1; i++)
            {
                for (int j = i + 1; j <= valori.Length - 1; j++)
                {
                    if (valori[i] > valori[j])
                    {
                        min = valori[j];
                        valori[j] = valori[i];
                        valori[i] = min;

                    }
                }

            }
            foreach (int a in valori)
                Console.WriteLine($"sort 1 valori ordinati:/n {a}");


        }
    }
}
