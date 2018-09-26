using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePunkt
{
    class Punkt
    {

        public int X { get; private set; }// właściwość 1
        

        public int Y { get; private set; }// właściwość 2
       


        public Punkt(int wspx, int wspy) //konstruktor
        {
            X = wspx;
            Y = wspy;

        }

        public void Prawo(int ileP) //metoda 1
        {
            X += ileP;

        }

        public void Lewo(int ileL) //metoda 2
        {
            X -= ileL;

        }

        public void Gora(int ileG) //metoda 3
        {
            Y += ileG;

        }

        public void Dol(int ileD) //metoda 4
        {
            Y -= ileD;

        }


        public void Wyswietl()
        {

            Console.WriteLine("Współrzędna X: {0}",X);
            Console.WriteLine("Współrzędna Y: {0}",Y);
        }

        public static Punkt operator +(Punkt p1, Punkt p2)
        {
            int x = p1.X+p2.X;
            int y = p1.Y+p2.Y;
            return new Punkt(x, y);            
        }

        public static Punkt operator -(Punkt p1, Punkt p2)
        {
            int x = p1.X-p2.X;
            int y = p1.Y-p2.Y;
            return new Punkt(x, y);            
        }

         public static Punkt operator *(Punkt p1, int a)
        {
            int x = p1.X*a;
            int y = p1.Y*a;
            return new Punkt(x, y);            
        }

    }
}
