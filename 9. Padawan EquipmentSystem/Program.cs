using System;

namespace _9._Padawan_EquipmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyStart = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double priceSabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());
            double saberextra = Math.Ceiling(0.10 * students);
            double freeBelts = Math.Floor(students / 6);

            double needMoney = (priceSabers * (students + saberextra) + (robes * students) + (belts * (students - freeBelts)));

            if (needMoney <= moneyStart)
            {
                Console.WriteLine($"The money is enough - it would cost {needMoney:f2}lv.");
            }
            else
            {
                double diff = needMoney - moneyStart;
                Console.WriteLine($"Ivan Cho will need {diff:f2}lv more.");
            }
        }
    }
}
