using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public enum AccountType { Account, SavingAccount }
    class BasicAccount
    {
        public decimal Balance { get; private set; }
        public decimal Interest { get; private set; }
        public AccountType AccountType { get; private set; }


        public BasicAccount(AccountType accountType)
        {
            AccountType = accountType;
        }

        public void IncreaseBalance(decimal value)
        {
            Balance += value;
        }

        public void IncreaseInterest(decimal value)
        {
            if (AccountType != AccountType.SavingAccount)
            {
                throw new ArgumentException("Operacja niewspierana.");
            }
            Interest += value;
        }

        public decimal GetValue()
        {
            if (AccountType == AccountType.Account)
            {
                return Balance;
            }
            else if (AccountType == AccountType.SavingAccount)
            {
                return Balance + Interest;
            }
            else
            {
                throw new ArgumentException("Operacja niewspierana.");
            }
        }
    }
}