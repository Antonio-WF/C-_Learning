using System;
using System.Runtime;

namespace Main_Program
{
    class Main_Program
    {
        static void InputCheck()
        {
            Console.WriteLine("Please Enter a Menu by writing the coresponding number:");
            while(true)
            {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1. Current Balance");
            Console.WriteLine("2. Income");
            Console.WriteLine("3. Expenses");
            Console.WriteLine("0. Exit");
            string menu = Console.ReadLine() ?? "";

            if(int.TryParse(menu, out int menu_Int) && (menu_Int==0 || menu_Int==1 || menu_Int==2 || menu_Int==3))
            {
                switch(menu_Int)
                {
                    case 1:
                    Console.Clear();
                    Console.WriteLine("Current Balance Menu");
                    Console.WriteLine("--------------------");
                    Current_Balance_Menu();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;

                    case 2:
                    Console.Clear();
                    Console.WriteLine("Income Menu");
                    Console.WriteLine("-----------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;

                    case 3:
                    Console.Clear();
                    Console.WriteLine("Expenses Menu");
                    Console.WriteLine("-------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;

                    case 0:
                    Console.Clear();
                    Console.WriteLine("Data Saved.");
                    Console.WriteLine("Have a nice day! :)");
                    return;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR: Please Enter a valid number between 1 and 3");
            }
            }
        }
        static void Current_Balance_Menu()
        {
            Console.WriteLine("Total Balance (EUR):");
            Console.WriteLine("Available Balance (EUR):");    
            Console.WriteLine("Cash Balance (MKD):");   
            Console.WriteLine("Cash Balance (EUR):");   
            Console.WriteLine("Bank Balance (MKD):");   
            Console.WriteLine("Bank Balance (EUR):"); 
            Console.WriteLine("Crypto Balance (EUR):");   
        }
        static void Main(string[] args)
        {
            InputCheck();
        }
    }
}