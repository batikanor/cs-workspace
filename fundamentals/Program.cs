using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("dude");
            // Try2DArrays();
            // OwnCat("Roe");
            TryGetterSetter();
            Console.WriteLine(Utils.Sum(1,2,3));
        }

        static void SayHi(string address)
        {
            Console.WriteLine("Hi, " + address + "!");
        }

        static void Try2DArrays()
        {
            int[,] numGrid = {
                {1,2},
                {3,4},
                {5,6}
            };
            int[,] well = new int [2,3];
            well[1,1] = 0;
            numGrid[0,0] = 9;
            Console.WriteLine(numGrid[0,0]);
        }
        static void OwnCat(string catName)
        {
            Cat c = new Cat();
            c.name = catName;
            c.ownerName = "System";
            Console.WriteLine(c.ownerName + " now owns a cat called " + c.name);
        }
        static void TryGetterSetter()
        {
            // These are kinda weird in c#
            Cat c = new Cat();
            c.Type = "green";
            Console.WriteLine("This cat's type is " + c.Type + " but all cats have the same normal leg count, which is: " + Cat.legCount);
        }
    }
}
