using System;
using System.Linq; // Necesario para Enumerable y ToArray()

public class Algoritmo
{
    public int[] GenerarNumeros(int n)
    {
        // Semilla fija (42) garantiza que todos los alumnos ordenen la misma secuencia
        Random r = new Random(42);
        return Enumerable.Range(0, n).Select(_ => r.Next(0, 50000)).ToArray();
    }

    public bool EstaOrdenado(int[] arr)
    {
        if (arr == null || arr.Length == 0) return true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Si el actual es mayor al siguiente, no está ordenado
            if (arr[i] > arr[i + 1]) return false;
        }
        return true;
    }

    public void BubbleSort(int[] arr)
    {
        if (arr == null || arr.Length <= 1) return;

        // Obtener la longitud del arreglo
        int n = arr.Length;

        // Bucle externo: controla cuántas pasadas hacemos por el arreglo
        for (int i = 0; i < n - 1; i++)
        {
            // Indicador para detectar si ya está ordenado y poder salir temprano
            bool swapped = false;

            // Bucle interno: compara elementos adyacentes
            // El "- i" es una optimización, ya que los últimos 'i' elementos ya están ordenados
            for (int j = 0; j < n - i - 1; j++)
            {
                // Si el elemento actual es mayor al siguiente, se intercambian
                if (arr[j] > arr[j + 1])
                {
                    // Intercambio (Swap) usando una variable temporal
                    int temporal = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temporal;
                    swapped = true;
                }
            }

            // Si en una pasada no hubo intercambios, ya está ordenado
            if (!swapped) break;
        }
    }
}

