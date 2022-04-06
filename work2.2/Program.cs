using System;

namespace work2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRepetitions;
            string message;

            Console.WriteLine("Данная программа осуществляет цикл сообщений от 1 до n-числа.");
            Console.Write($"Введите n-число повторений: ");
            numberOfRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= numberOfRepetitions; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Для продолжения цикла нажмите клавишу 'Enter'");
                Console.WriteLine("Для завершения цикла введите слово 'exit'");
                message = Console.ReadLine();
                if (message == "exit")
                {
                    Console.WriteLine($"Программа завершилась на {i} числе из {numberOfRepetitions} возможных.");
                    break;
                }
            }
        }
    }
}
