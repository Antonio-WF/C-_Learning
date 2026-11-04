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
            Console.WriteLine("4. Input Item");
            Console.WriteLine("0. Exit");
            string menu = Console.ReadLine() ?? "";

            if(int.TryParse(menu, out int menu_Int) && (menu_Int==0 || menu_Int==1 || menu_Int==2 || menu_Int==3 || menu_Int==4))
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
                    Income_Menu();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;

                    case 3:
                    Console.Clear();
                    Console.WriteLine("Expenses Menu");
                    Console.WriteLine("-------------");
                    Expenses_Menu();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
                    
                    case 4:
                    Console.Clear();
                    Console.WriteLine("Input Item Menu");
                    Console.WriteLine("-------------");
                    Input_Data();
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
        static void Income_Menu()
        {
            Console.WriteLine(" Code |      Month     | Total Income /m");
            Console.WriteLine("------+----------------+----------------"); 
            Console.WriteLine("sep26 | September 2026 | 32.980.00 EUR");
            Console.WriteLine("oct26 |  October 2026  | 35.954.00 EUR");
            Console.WriteLine("nov26 |  November 2026 | 1.980.00 EUR");
            Console.WriteLine("dec26 |  December 2026 | 55.120.00 EUR");
            Console.WriteLine("jan27 |  January 2027  | 89.348.00 EUR");
            Console.WriteLine("feb27 |  February 2027 | 32.980.00 EUR");
            Console.WriteLine("mar27 |   March 2027   | 3.880.00 EUR");
            Console.WriteLine("apr27 |   April 2027   | 58.080.00 EUR");
            Console.WriteLine("may27 |    May 2027    | 11.000.00 EUR");
            Console.WriteLine("jun27 |    June 2027   | 27.980.00 EUR");
            Console.WriteLine("jul27 |    July 2027   | 7.777.00 EUR");
        }
                static void Expenses_Menu()
        {
            Console.WriteLine(" Code |      Month     | Total Expense /m");
            Console.WriteLine("------+----------------+----------------"); 
            Console.WriteLine("sep26 | September 2026 | 32.980.00 EUR");
            Console.WriteLine("oct26 |  October 2026  | 35.954.00 EUR");
            Console.WriteLine("nov26 |  November 2026 | 1.980.00 EUR");
            Console.WriteLine("dec26 |  December 2026 | 55.120.00 EUR");
            Console.WriteLine("jan27 |  January 2027  | 89.348.00 EUR");
            Console.WriteLine("feb27 |  February 2027 | 32.980.00 EUR");
            Console.WriteLine("mar27 |   March 2027   | 3.880.00 EUR");
            Console.WriteLine("apr27 |   April 2027   | 58.080.00 EUR");
            Console.WriteLine("may27 |    May 2027    | 11.000.00 EUR");
            Console.WriteLine("jun27 |    June 2027   | 27.980.00 EUR");
            Console.WriteLine("jul27 |    July 2027   | 7.777.00 EUR");
        }
        static void Input_Data()
        {
            Console.WriteLine("Please Input the Income/Expense Name");
            string name = Console.ReadLine() ?? "";
            float f_price;
            Console.WriteLine("Please Input the Price");
            while(true)
            {
            string price = Console.ReadLine() ?? "";

            if (float.TryParse(price, out f_price))
                {
                    break;
                }
            else
            {
                Console.WriteLine("Please input a valid price.");
            }
            }
            Console.WriteLine("Input/Expense Name: " + name); //testing Input Data
            Console.WriteLine("Input/Expense Price: " + f_price); //testing Input Data
        }
        static void Main(string[] args)
        {
            InputCheck();
        }
    }
}