using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mATEMATYCZNE
{
    internal class Matematyczne
    {
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
    }
}
