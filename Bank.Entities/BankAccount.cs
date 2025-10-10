using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities;

public class BankAccount
{
    private readonly int _accountNumber;
    private readonly double _currentBalance;

    public BankAccount()
    {

    }

    public BankAccount(int accountNumber, double currentBalance)
    {
        _accountNumber = accountNumber;
        _currentBalance = currentBalance;
    }

    public int AccountNumber { get; init; } // init only property
    public double CurrentBalance { get; set; }
}

public class DataStorage
{
    public static List<BankAccount> GetBankAccounts()
    {
        return new List<BankAccount>()
        {
            new BankAccount() { AccountNumber = 1, CurrentBalance = 1000},
            new BankAccount() { AccountNumber = 2, CurrentBalance = 1000}

        };
    }

    public static double GetCurrentBalance(BankAccount bankAccount)
    {
        return bankAccount.CurrentBalance;
    }
}


