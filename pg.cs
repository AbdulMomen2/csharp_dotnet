// class Pogram
// {
//     static void Main(string[] args)
//     {
//       int x;
//       x = 123;

//       int y = 321;

//       int z = x+ y;

//       double r = (x-y)*0.1;

//       Console.WriteLine("x is" + x);

//       Console.WriteLine("y is" + y);

//       Console.WriteLine("The Sum is " + r);


//         double xb = 4;
//         // double xc = Math.Pow(xb,2);
//         double xc= Math.Sqrt(xb);
//         Console.WriteLine(xc);    


//       bool alive = true;
      

//       Console.WriteLine("ARE  you Alive " + alive);


//     }
// }



using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter Side A:");
            // double a = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Enter Side B:");
            // double b = Convert.ToDouble(Console.ReadLine());

            // double c = Math.Sqrt(a*a + (b*b));

            // Console.WriteLine($"Side A: {a}");
            // Console.WriteLine($"Side B: {b}");
            //  Console.WriteLine($"The Hypotenuse is : {c}");


            // Console.WriteLine("enter your age: " );
            // int age = Convert.ToInt32(Console.ReadLine());

            // if (age>18)
            // {
            //     Console.WriteLine("YOu are *** to sign up");
            // }

            // else if (age <50)
            // {
            //     Console.WriteLine("Please Retire");
            // }

            // else
            // {
            //     Console.WriteLine("Rejected");
            // }

            // Console.WriteLine("Enter Your name ");
            // String name = Console.ReadLine();

            // if (name != "")
            // {
            //     Console.WriteLine("hello" + name);

            // }
            // else
            // {
            //     Console.WriteLine("Please Enter Your Name");
            // }


            Console.WriteLine("What is it Toady");

            String day = Console.ReadLine();

            switch(day)

            {
                case "Monday":
                Console.WriteLine("Ok, Its monday");
                break;

                case "Sunday":
                Console.WriteLine("Ok, Its Sunday");
                break;

                case "Saturday":
                Console.WriteLine("Ok, Its Saturday");
                break;

                default:
                Console.WriteLine( day + "day dNo Day");
                break;
            }


        }


        
    }
}