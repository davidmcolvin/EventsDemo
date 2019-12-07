using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
  public partial class Dashboard : Form
  {
    Customer customer = new Customer();

    public Dashboard()
    {
      InitializeComponent();

      LoadTestingData();

      WireUpForm();
    }

    private void LoadTestingData()
    {
      customer.CustomerName = "Tim Corey";
      customer.CheckingAccount = new Account();
      customer.SavingsAccount = new Account();

      customer.CheckingAccount.AccountName = "Tim's Checking Account";
      customer.SavingsAccount.AccountName = "Tim's Savings Account";

      customer.CheckingAccount.AddDeposit("Initial Balance", 155.43M);
      customer.SavingsAccount.AddDeposit("Initial Balance", 98.45M);
    }

    private void WireUpForm()
    {
      customerValueLabel.Text = customer.CustomerName;
      checkingTransactionsListBox.DataSource = customer.CheckingAccount.Transactions;
      savingsTransactionsListBox.DataSource = customer.SavingsAccount.Transactions;
      checkingAmountLabel.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
      savingsAmountLabel.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);
    }

    private void recordTransactionsButton_Click(object sender, EventArgs e)
    {
      Transactions transactions = new Transactions(customer);
      transactions.Show();
    }

    private void overdraftLabel_Click(object sender, EventArgs e)
    {
      overdraftLabel.Visible = false;
    }
  }
}
