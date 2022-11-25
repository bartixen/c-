using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metoda metoda = new Metoda();
            metoda.Sortowanie();
        }
       
           
    }
    public class Metoda
    {
        int[] t = new int[10];

        private int Minim(int j)
        {
            int min = t[j], index = j;
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                    index = i;
                }
            }
            return index;
        }

        public void Sortowanie()
        {
            int x = Minim(0);
            Console.WriteLine("najmniejsza wartosx to " + t[x] + " na index " + x);
        }

    }
}