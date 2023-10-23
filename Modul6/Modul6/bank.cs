using Bankomat.Bank;
using System;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Введите пароль: ");
                string inputPassword = Console.ReadLine();

                if (bank.CheckPassword(inputPassword))
                {
                    Console.WriteLine("Доступ разрешен.");
                    Client client = new Client();
                    string accountNumber = bank.OpenAccount(client);
                    Console.WriteLine($"Ваш номер счета: {accountNumber}");
                    Console.Write("Введите сумму для пополнения счета: ");
                    double depositAmount;
                    if (double.TryParse(Console.ReadLine(), out depositAmount))
                    {
                        bank.Deposit(accountNumber, depositAmount);
                        Console.WriteLine($"Счет пополнен на {depositAmount:C}");
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат суммы.");
                    }

                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неверный пароль. Осталось попыток: {attempts}");
                }
            }

            if (attempts == 0)
            {
                Console.WriteLine("Превышено количество попыток. Приложение завершается.");
            }
        }
    }

    namespace Bank
    {
        class Bank
        {
            private string correctPassword = "your_password"; 

            public bool CheckPassword(string password)
            {
                return password == correctPassword;
            }

            public string OpenAccount(Client client)
            {
                
                string accountNumber = Guid.NewGuid().ToString();
                
                return accountNumber;
            }

            public void Deposit(string accountNumber, double amount)
            {
                
            }
        }    
    }
}
