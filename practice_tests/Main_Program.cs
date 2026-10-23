using System;
using System.Runtime;

namespace Main_Program
{
    class Main_Program
    {
        static void input_Check(string menu)
        {
            if(int.TryParse(menu, out int menu_Int) && (menu_Int==1 || menu_Int==2 || menu_Int==3))
            {
                switch(menu_Int)
                {
                    case 1:
                    Console.WriteLine("Current Balance Menu");
                    break;

                    case 2:
                    Console.WriteLine("Income Menu");
                    break;

                    case 3:
                    Console.WriteLine("Expenses Menu");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid number between 1 and 3");
                Console.WriteLine("1. Current Balance");
                Console.WriteLine("2. Income");
                Console.WriteLine("3. Expenses");
                menu = Console.ReadLine() ?? "";
                input_Check(menu);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Menu by writing the coresponding number:");
            Console.WriteLine("1. Current Balance");
            Console.WriteLine("2. Income");
            Console.WriteLine("3. Expenses");
            string menu = Console.ReadLine() ?? "";
            input_Check(menu);
            return;
        }
    }
}