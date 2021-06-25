using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QiuckSort
{
    class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hány elem legyen?");
            int h = int.Parse(Console.ReadLine());
            int[] T = new int[h];
            int B = 0;
            int J = T.Length - 1;
            while (T.Last() == 0)
            {
                int épp = rng.Next(1, T.Length + 1);
                if (!T.Contains(épp))
                {
                    T[B] = épp;
                    B++;
                }
            }
            B = 0;
            foreach (int item in T)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
            Console.WriteLine();
            QiuckSort(T, B, J);
            foreach (int item in T)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
        static void QiuckSort(int[] T, int B, int J)
        {
            if (B < J)
            {
                int P = P_keres(T, B, J);
                if(P > 1) QiuckSort(T, B, P - 1);
                if (P + 1 < J) QiuckSort(T, P + 1, J);
            }
        }

        static int P_keres(int[] T, int B, int J)
        {
            int P = T[B];
            while (true)
            {
                while (P > T[B]) B++;
                while (P < T[J]) J--;
                if (B < J && T[B] != T[J])
                {
                    int csere = T[B];
                    T[B] = T[J];
                    T[J] = csere;
                    //P = T[B];
                    
                }
                else
                {
                    return J;
                }
            }
        }
    }
}
