using Services;
using System;

namespace View
{
    internal class TelaMenu
    {
        public static void Menu()
        {
            Console.Write("What tipe of information? (Number/String)");
            string option = Console.ReadLine();

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int lenth = int.Parse(Console.ReadLine());

            for(int i = 0; i < lenth; i++)
            {
                int values = int.Parse(Console.ReadLine());
                printService.AddValue(values);
            }

            printService.PrintValues();
        }
    }
}
