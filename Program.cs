using System;

namespace Mathelulw
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Möglichkeiten = { "A", "B", "J", "K"};

            foreach (string P in Möglichkeiten)
            {
                foreach (string S in Möglichkeiten)


                Console.Write("(" + P + "," + S + ")"+",");

            }

        }
    }
}
