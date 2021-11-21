using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            BasicAccount account = new BasicAccount(AccountType.Account);
            account.IncreaseBalance(2000M);
            //account.IncreaseInterest(11M);
            BasicAccount savingAccount = new BasicAccount(AccountType.SavingAccount);
            savingAccount.IncreaseBalance(1000M);
            savingAccount.IncreaseInterest(200M);
            bank.AddAccount(account);
            bank.AddAccount(savingAccount);
            Console.WriteLine(bank.GetValue());

        }
    }
}