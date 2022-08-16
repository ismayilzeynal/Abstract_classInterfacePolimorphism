using AbstractClassInterfacePolimorphism.Models;
using System;

namespace AbstractClassInterfacePolimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area
            Console.WriteLine("1) Sqaure");
            Console.WriteLine("2) Rectanglular");
            Console.WriteLine("0) Quit");

            int Choise;
            Choise = Convert.ToInt32(Console.ReadLine());     // try parse
            if (Choise == 1)
            {
                Console.Write("input side: ");
                float Side = Convert.ToSingle(Console.ReadLine());
                Square Sq = new Square(Side);
                Console.WriteLine($"Area: {Sq.CalcArea()}");
            }
            else if (Choise == 2)
            {
                Console.Write("input Width: ");
                float Width = Convert.ToSingle(Console.ReadLine());
                Console.Write("input Length: ");
                float Length = Convert.ToSingle(Console.ReadLine());
                Rectangular Rec = new Rectangular(Width, Length);
                Console.WriteLine($"Area: {Rec.CalcArea()}");
            }
            else if (Choise == 0)
            {
                Console.WriteLine("Program ended");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            #endregion









            #region Vehicle
            #endregion


        }
    }
}
