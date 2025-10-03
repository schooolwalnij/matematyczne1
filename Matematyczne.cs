using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mATEMATYCZNE
{
    internal class Matematyczne
    {
        public int MinMax(int[] tablica, bool czyMin)
        {
            if (tablica == null || tablica.Length == 0)
                throw new ArgumentException("Tablica nie może być pusta.");
            int wynik = tablica[0];
            foreach (int liczba in tablica)
            {
                if (czyMin && liczba < wynik)
                {
                    wynik = liczba;
                }
                else if (!czyMin && liczba > wynik)
                {
                    wynik = liczba;
                }
            }
            return wynik;
        }

        public int NWD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public bool CzyPierwsza(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public int Potega(int a, int n)
        {
            if (n == 1)
            {
                return a;
            }
            int s = Potega(a, n - 1);
            return a * s;
        }

        public int NWW(int a, int b)
        {
            return (a * b) / NWD(a, b);
        }

        public int Silnia(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * Silnia(n - 1);
        }

        public void BubbleSort(int[] tablica)
        {
            int n = tablica.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
            }
           for (int i = 0; i < n; i++)
           {
               Console.Write(tablica[i] + " ");
            }
        }


    }
}
