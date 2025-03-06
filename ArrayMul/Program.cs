using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

    
            float[] valores = new float[6];
            for (int i = 0; i < 6; i++)
            {
                float.TryParse(args[i], NumberStyles.Float, CultureInfo.InvariantCulture, out valores[i]);	
            }

            
            float[,] matriz = {
                { valores[0], valores[1] },
                { valores[2], valores[3] }
            };

            
            float[] vetor = { valores[4], valores[5] };

            
            float[] resultado = new float[2];

            
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 2; j++) 
                {
                    resultado[i] += matriz[i, j] * vetor[j];
                }
            }


            foreach (float valor in resultado)
            {
                Console.WriteLine($"|{valor,7:F2} |");
            }
            
        }
        
    }
}
