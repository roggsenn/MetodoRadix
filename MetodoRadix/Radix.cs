using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoRadix
{
    static class Radix
    {
        public static int[] RadixSort(int[] numeros)
        {
            int numeroMaximo = numeros.Max();              // Número mayor del arreglo
            int posicion = 1;                              // Dígito actual (1, 10, 100…)
            int cantidad = numeros.Length;                 // Total de elementos
            int[] temporal = new int[cantidad];            // Arreglo auxiliar

            while (numeroMaximo / posicion > 0)            // Mientras queden dígitos por ordenar
            {
                int[] contador = new int[10];              // Contador de dígitos (0–9)

                for (int i = 0; i < cantidad; i++)         // Contar frecuencia de cada dígito
                {
                    contador[(numeros[i] / posicion) % 10]++;
                }

                for (int i = 1; i < 10; i++)               // Acumular posiciones
                {
                    contador[i] += contador[i - 1];
                }

                for (int i = cantidad - 1; i >= 0; i--)    // Ordenar según el dígito
                {
                    int digito = (numeros[i] / posicion) % 10;
                    temporal[contador[digito] - 1] = numeros[i];
                    contador[digito]--;
                }

                for (int i = 0; i < cantidad; i++)         // Copiar al arreglo original
                {
                    numeros[i] = temporal[i];
                }

                posicion *= 10;                            // Pasar al siguiente dígito
            }

            return numeros;                                // Devolver arreglo ordenado
        }
    }
}
