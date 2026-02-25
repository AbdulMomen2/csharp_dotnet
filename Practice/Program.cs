// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
        
//         Console.WriteLine("Triangle Base Problem");

//         for(int i=0; i<4; i++)
//         {
//             for(int j=0; j <= i; j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }


       
//     }
// }

using System;
using Practice;
class Program
{
    static void Main(string[] args)
    {
        // int n = 4;

        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = 0; j < n - i; j++)
        //     {
        //         Console.Write("*");
        //     }

        //     Console.WriteLine();
        // }

            Hammer hammer = new Hammer();
            Saw saw= new Saw();
            Builder builder = new Builder(hammer,saw);

            builder.BuildHouse();
            
            Console.ReadLine();
    }
}