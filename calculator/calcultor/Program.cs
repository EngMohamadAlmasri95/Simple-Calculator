using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcultor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Calculator By CSharp");
            Console.Write("Entter the first val: ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entter the second val: ");
            int val2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entter the oprator:");
            string opr = Console.ReadLine();
            int res;
            switch (opr)
            {
                case "+":
                    res=val1 + val2;
                    Console.WriteLine("the reslut = "+ res);
                    break;
                case "-":
                    Console.WriteLine("the reslut = " +( val1 - val2));
                    break;

                case "*":
                   int res1=val1 * val2;
                    Console.WriteLine("the reslut = " + res1);
                    break;
                case "/":
                    if (val2 == 0)
                        Console.WriteLine("Eeorrrrrrrrrrrrr!!!!!!!!!!!!!!!!");
                    else
                    {
                        int res2 = val2 / val1;
                        Console.WriteLine("the reslut = " +res2);
                    }
                    break;
                    default:
                    Console.WriteLine("Enter the correct opretr Please !!!!");
                        break;

            }
        }
    }
}

