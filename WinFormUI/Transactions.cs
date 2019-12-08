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
  public partial class Transactions : Form
  {
    private Customer _customer;

    public Transactions(Customer customer)
    {
      InitializeComponent();
      _customer = customer;

      customerValueLabel.Text = _customer.CustomerName;
      _customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
    }

    private void CheckingAccount_OverdraftEvent(object sender, OverdraftEventArgs e)
    {
      overdraftLabel.Visible = true;
    }

    private void makePurchaseButton_Click(object sender, EventArgs e)
    {
      bool paymentResult = _customer.CheckingAccount.MakePayment("Credit Card Purchase", amountNumericUpDown.Value, _customer.SavingsAccount);
      amountNumericUpDown.Value = 0;
    }

    private void overdraftLabel_Click(object sender, EventArgs e)
    {
      overdraftLabel.Visible = false;
    }

    private void Transactions_FormClosing(object sender, FormClosingEventArgs e)
    {
      _customer.CheckingAccount.OverdraftEvent -= CheckingAccount_OverdraftEvent;
    }
  }
}
