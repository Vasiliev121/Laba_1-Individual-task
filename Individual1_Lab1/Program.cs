using System;
using System.Collections;

namespace Table
{
    public class OOP
    {

        public struct Item
        {
            public String surname;
            public Char position;
            public int year;
            public double salary;

            public Item(string surname, Char position, int year, double salary)
            {
                this.surname = surname;
                this.position = position;
                this.year = year;
                this.salary = salary;

            }

            public void Print()
            {
                Console.WriteLine($"|{this.surname,-24}|{this.position,-12}|{this.year,-20}|{this.salary,-15}|");

            }
        }

        private static void Main()
        {
            ArrayList list = new();


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите данные:");

                Console.WriteLine("Фамилия:");
                string surname = Console.ReadLine();

                Console.WriteLine("Дожность (П - преподаватель, С - студент, А - аспирант)");
                Char position = Char.Parse(Console.ReadLine());

                Console.WriteLine("Год рождения:");
                int year = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Оклад (грн)");
                double salary = double.Parse(Console.ReadLine());
                Item value = new(surname, position, year, salary);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить строку?\nда - продолжить\nнет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                            flag = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }

            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Отдел кадров",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Фамилия",-25}|{"Должность",-12}|{"Год рождения",-20}|{"Оклад (грн)",-15}|");
            Console.WriteLine(new String('-', 76));
            foreach (Item item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: П - преподаватель, С - студент, А - аспирант",-75}|");
            Console.WriteLine(new String('-', 76));




            // Задание 2
            /*Console.WriteLine("Введите значения: a, x, b");
            double a, x, b;
            a = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            double z = Math.Sqrt(a * x * Math.Sin(2 * x) + Math.Exp(-2 * x) * (x + b));
            if (a != 0 && b != 0)
            {
                double w = Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) - x / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 3));
                Console.WriteLine("W = " + w);
            }
            else Console.WriteLine("Введенные значения не входят в ОДЗ");
            Console.WriteLine("Z = " + z);*/
        }

    }
}
