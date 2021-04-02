using System;

namespace Revisao
{
    public static class Numero
    {
        public static bool IsPrime(int numero)
        {
            if (numero < 4)
                return true;

            int teto = (int)Math.Sqrt(numero) + 1;

            for (int i = 2; i < teto; i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
