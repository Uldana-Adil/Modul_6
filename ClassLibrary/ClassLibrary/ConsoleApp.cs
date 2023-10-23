using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {           
            string cardPassword = "1234";
            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Введите пароль: ");
                string userPassword = Console.ReadLine();

                if (userPassword == cardPassword)
                {
                    Console.WriteLine("Доступ разрешен!");
                    
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неверный пароль. Осталось {attempts} попыток.");
                }
            }

            if (attempts == 0)
            {
                Console.WriteLine("Попытки исчерпаны. Пожалуйста, обратитесь в банк.");
            }
        }
    }
}

