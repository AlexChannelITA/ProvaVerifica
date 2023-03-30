using System;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valori = { 19, 44, 38, 15, 40 };
            int min = valori[0];

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
