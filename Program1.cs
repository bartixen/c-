using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{

    public class Tablice
    {
        public int[] t = new int[5];
        public string napis = "";

        public void wczytywanie()
        {
            for (int i = 0; i < t.Length; i++) {
                Console.Write("Podaj liczbe " + (i + 1) + " ");
                t[i] = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        public void wartosci()
        {

            foreach (int w in t)
            {
                napis += w + "; ";
            }
        }

        public int mat(char z)
        {
            int wynik = t[0];
            
            if(z == '+')
            {
                foreach (int w in t)
                {
                    wynik += w; 
                }
            }else if(z == '*')
            {
                
                foreach(int w in t)
                {
                    wynik *= w;
                }
            }

           return wynik;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablice tablice = new Tablice();
            tablice.wczytywanie();
            tablice.wartosci();
            Console.WriteLine(tablice.napis);
            Console.WriteLine("Podaj znak +/* ");
            char p = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(tablice.mat(p));
        }
    }
}
