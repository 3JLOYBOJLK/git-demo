using System;

namespace HelloWorld
{
    class Program
    {
        static void PrintMoney(string message ,double money, string moneywallet)
        {
            Console.WriteLine($"{message} \n you have {money} {moneywallet}");
        }
        static void Main(string[] args)
        {
            const double wallet=3.27;
            double MoneyUsdToByn;
            double MoneyBynToUsd;
            Console.WriteLine("How much do you want to converte?");
            double convertedmoney=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("you wanna convert \n1.usd to byn\n2.byn to usd");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            do
            {

                switch(userchoice)
                {
                    case 1:
                        {
                            MoneyUsdToByn = convertedmoney * wallet;
                            PrintMoney("Usd to Byn",MoneyUsdToByn,"BYN");
                            break;
                        }
                    case 2:
        
                        {
                            MoneyBynToUsd = convertedmoney / wallet;
                            PrintMoney("Byn to Usd", MoneyBynToUsd,"USD");
                            break;
                        }
                };
                Console.WriteLine("you wanna convert \n1.usd to byn\n2.byn to usd");
                userchoice = Convert.ToInt32(Console.ReadLine());
            } while (userchoice != 0);
        }
    }
}
