using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[6];

            namn[0] = "Anton";
            namn[1] = "Bertil";
            namn[2] = "Agaton";
            namn[3] = "Sten";
            namn[4] = "Peter";
            namn[5] = "Kevin";

            string första = "Agaton";

            for (int i = 0; i < namn.Length; i++)
            {
                if (namn[i].CompareTo(första) < 0)
                {
                    första = namn[i];
                }
            }

            Console.WriteLine("Det första namnet är " + första);

        }
    }
}