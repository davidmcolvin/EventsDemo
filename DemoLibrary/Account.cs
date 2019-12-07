﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class Account
  {
    public event EventHandler<string> TransactionApprovedEvent;

    public string AccountName { get; set; }
    public decimal Balance { get; private set; }
    private List<string> _transactions = new List<string>();

    public IReadOnlyList<string> Transactions
    {
      get { return _transactions.AsReadOnly(); }
    }

    public bool AddDeposit(string depositName, decimal amount)
    {
      _transactions.Add($"Deposited {string.Format("{0:C2}", amount) } for {depositName}");
      Balance += amount;
      TransactionApprovedEvent?.Invoke(this, depositName);
      return true;
    }

    public bool MakePayment(string paymentName, decimal amount, Account backupAccount = null)
    {
      // Ensures we have enough money
      if (Balance >= amount)
      {
        _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
        Balance -= amount;
        TransactionApprovedEvent?.Invoke(this, paymentName);
        return true;
      }
      else
      {
        // We don't have enough money so we check to see if we have a backup account
        if (backupAccount != null)
        {
          // Checks to see if we have enough money in the backup account
          if ((backupAccount.Balance + Balance) >= amount)
          {
            // We have enough backup funds so transfer the amount to this account
            // and then complete the transaction.
            decimal amountNeeded = amount - Balance;
            bool overdraftSucceeded = backupAccount.MakePayment("Overdraft Protection", amountNeeded);

            // This should always be true but we will check anyway
            if (overdraftSucceeded == false)
            {
              //The overdraft failed so this transaction failed.
              return false;
            }
            else
            {
              AddDeposit("Overdraft Protection Deposit", amountNeeded);
              _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
              Balance -= amount;
              TransactionApprovedEvent?.Invoke(this, paymentName);
              return true;
            }
          }
          else
          {
            // Not enough backup funds to do anything so fail
            return false;
          }
        }
        else
        {
          // No backup account detected so fail
          return false;
        }
      }
    }
  }
}
