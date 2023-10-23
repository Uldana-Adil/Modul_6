namespace Bankomat
{
    internal class Client
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        public Client(string name, string address, string email)
        {
            Name = name;
            Address = address;
            Email = email;
        }

        public Client()
        {
        }
    }

    class Account
    {
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0.0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }

    }

}

