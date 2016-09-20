using System;


namespace BankStructs
{

    enum AccountState
    {
        New,
        Active,
        UnderAudit,
        Frozen,
        Closed
    };

    struct Account
    {
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        public int Balance;
        public int Overdragt;
    }

    class Program
    {

        //public static void PrintAccount(Account a);

        static void Main(string[] args)
        {
            const int MAX_CUST = 100;
            Account[] Bank = new Account[MAX_CUST];
            Bank[0].Name = "Rob";
            Bank[0].Address = "Rob's Address";
            Bank[0].Balance = 100000;
            Bank[0].AccountNumber = 123456789;
            Bank[0].State = AccountState.Active;

            PrintAccount(Bank[0]);

            Console.ReadLine();

        }

        public static void PrintAccount(Account a)
        {
            Console.WriteLine("Name: " + a.Name);
            Console.WriteLine("Address: " + a.Address);
            Console.WriteLine("Balance: " + a.Balance);
        }
    }
}
