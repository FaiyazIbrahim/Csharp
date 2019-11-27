using System;

namespace csharp25._2
{
    


    class pyramidUpsideDown
    {
        static void Main(string[] args)
        {
            int i, j;
            int space = 10;
            int MAX = space;

                        space = 0;
 
            for (i = MAX; i > 0; i--)
            {
 
                for (j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
 
                Console.Write("\n");
                space++;
            }
            Console.ReadLine();
        }
    }
}
