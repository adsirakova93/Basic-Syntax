using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());


            double crashHeadset = lostGame / 2;
            double crashMouse = lostGame / 3;
            double crashKeyboard = lostGame / 6;
            double crashDisplay = lostGame / 12;

            double totalExpenses = crashHeadset * headsetPrice + crashMouse * mousePrice + crashKeyboard * keyboardPrice + crashDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
