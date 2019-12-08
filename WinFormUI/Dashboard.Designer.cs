namespace WinFormUI
{
  partial class Dashboard
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
      this.headerBankingDemoLabel = new System.Windows.Forms.Label();
      this.headerCustomerLabel = new System.Windows.Forms.Label();
      this.headerCheckingBalanceLabel = new System.Windows.Forms.Label();
      this.headerSavingsBalanceLabel = new System.Windows.Forms.Label();
      this.customerValueLabel = new System.Windows.Forms.Label();
      this.checkingAmountLabel = new System.Windows.Forms.Label();
      this.savingsAmountLabel = new System.Windows.Forms.Label();
      this.overdraftLabel = new System.Windows.Forms.Label();
      this.headerCheckingTransactionsLabel = new System.Windows.Forms.Label();
      this.headerSavingsTransactionsLabel = new System.Windows.Forms.Label();
      this.checkingTransactionsListBox = new System.Windows.Forms.ListBox();
      this.savingsTransactionsListBox = new System.Windows.Forms.ListBox();
      this.recordTransactionsButton = new System.Windows.Forms.Button();
      this.denyOverdraftCheckBox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // headerBankingDemoLabel
      // 
      this.headerBankingDemoLabel.AutoSize = true;
      this.headerBankingDemoLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerBankingDemoLabel.Location = new System.Drawing.Point(2, 6);
      this.headerBankingDemoLabel.Name = "headerBankingDemoLabel";
      this.headerBankingDemoLabel.Size = new System.Drawing.Size(191, 37);
      this.headerBankingDemoLabel.TabIndex = 0;
      this.headerBankingDemoLabel.Text = "Banking Demo";
      // 
      // headerCustomerLabel
      // 
      this.headerCustomerLabel.AutoSize = true;
      this.headerCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerCustomerLabel.Location = new System.Drawing.Point(4, 113);
      this.headerCustomerLabel.Name = "headerCustomerLabel";
      this.headerCustomerLabel.Size = new System.Drawing.Size(83, 21);
      this.headerCustomerLabel.TabIndex = 1;
      this.headerCustomerLabel.Text = "Customer";
      // 
      // headerCheckingBalanceLabel
      // 
      this.headerCheckingBalanceLabel.AutoSize = true;
      this.headerCheckingBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerCheckingBalanceLabel.Location = new System.Drawing.Point(4, 162);
      this.headerCheckingBalanceLabel.Name = "headerCheckingBalanceLabel";
      this.headerCheckingBalanceLabel.Size = new System.Drawing.Size(145, 21);
      this.headerCheckingBalanceLabel.TabIndex = 2;
      this.headerCheckingBalanceLabel.Text = "Checking Balance";
      // 
      // headerSavingsBalanceLabel
      // 
      this.headerSavingsBalanceLabel.AutoSize = true;
      this.headerSavingsBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerSavingsBalanceLabel.Location = new System.Drawing.Point(4, 211);
      this.headerSavingsBalanceLabel.Name = "headerSavingsBalanceLabel";
      this.headerSavingsBalanceLabel.Size = new System.Drawing.Size(133, 21);
      this.headerSavingsBalanceLabel.TabIndex = 3;
      this.headerSavingsBalanceLabel.Text = "Savings Balance";
      // 
      // customerValueLabel
      // 
      this.customerValueLabel.AutoSize = true;
      this.customerValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.customerValueLabel.Location = new System.Drawing.Point(151, 113);
      this.customerValueLabel.Name = "customerValueLabel";
      this.customerValueLabel.Size = new System.Drawing.Size(63, 20);
      this.customerValueLabel.TabIndex = 4;
      this.customerValueLabel.Text = "<none>";
      // 
      // checkingAmountLabel
      // 
      this.checkingAmountLabel.AutoSize = true;
      this.checkingAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkingAmountLabel.Location = new System.Drawing.Point(151, 162);
      this.checkingAmountLabel.Name = "checkingAmountLabel";
      this.checkingAmountLabel.Size = new System.Drawing.Size(49, 20);
      this.checkingAmountLabel.TabIndex = 5;
      this.checkingAmountLabel.Text = "$0.00";
      // 
      // savingsAmountLabel
      // 
      this.savingsAmountLabel.AutoSize = true;
      this.savingsAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.savingsAmountLabel.Location = new System.Drawing.Point(151, 211);
      this.savingsAmountLabel.Name = "savingsAmountLabel";
      this.savingsAmountLabel.Size = new System.Drawing.Size(49, 20);
      this.savingsAmountLabel.TabIndex = 6;
      this.savingsAmountLabel.Text = "$0.00";
      // 
      // overdraftLabel
      // 
      this.overdraftLabel.AutoSize = true;
      this.overdraftLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.overdraftLabel.ForeColor = System.Drawing.Color.Red;
      this.overdraftLabel.Location = new System.Drawing.Point(260, 40);
      this.overdraftLabel.Name = "overdraftLabel";
      this.overdraftLabel.Size = new System.Drawing.Size(349, 21);
      this.overdraftLabel.TabIndex = 7;
      this.overdraftLabel.Text = "You had an overdraft protection transfer of $0.00";
      this.overdraftLabel.Visible = false;
      this.overdraftLabel.Click += new System.EventHandler(this.overdraftLabel_Click);
      // 
      // headerCheckingTransactionsLabel
      // 
      this.headerCheckingTransactionsLabel.AutoSize = true;
      this.headerCheckingTransactionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerCheckingTransactionsLabel.Location = new System.Drawing.Point(260, 87);
      this.headerCheckingTransactionsLabel.Name = "headerCheckingTransactionsLabel";
      this.headerCheckingTransactionsLabel.Size = new System.Drawing.Size(180, 21);
      this.headerCheckingTransactionsLabel.TabIndex = 8;
      this.headerCheckingTransactionsLabel.Text = "Checking Transactions";
      // 
      // headerSavingsTransactionsLabel
      // 
      this.headerSavingsTransactionsLabel.AutoSize = true;
      this.headerSavingsTransactionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerSavingsTransactionsLabel.Location = new System.Drawing.Point(598, 87);
      this.headerSavingsTransactionsLabel.Name = "headerSavingsTransactionsLabel";
      this.headerSavingsTransactionsLabel.Size = new System.Drawing.Size(168, 21);
      this.headerSavingsTransactionsLabel.TabIndex = 9;
      this.headerSavingsTransactionsLabel.Text = "Savings Transactions";
      // 
      // checkingTransactionsListBox
      // 
      this.checkingTransactionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkingTransactionsListBox.FormattingEnabled = true;
      this.checkingTransactionsListBox.ItemHeight = 20;
      this.checkingTransactionsListBox.Location = new System.Drawing.Point(263, 125);
      this.checkingTransactionsListBox.Name = "checkingTransactionsListBox";
      this.checkingTransactionsListBox.Size = new System.Drawing.Size(321, 264);
      this.checkingTransactionsListBox.TabIndex = 10;
      // 
      // savingsTransactionsListBox
      // 
      this.savingsTransactionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.savingsTransactionsListBox.FormattingEnabled = true;
      this.savingsTransactionsListBox.ItemHeight = 20;
      this.savingsTransactionsListBox.Location = new System.Drawing.Point(602, 125);
      this.savingsTransactionsListBox.Name = "savingsTransactionsListBox";
      this.savingsTransactionsListBox.Size = new System.Drawing.Size(308, 264);
      this.savingsTransactionsListBox.TabIndex = 11;
      // 
      // recordTransactionsButton
      // 
      this.recordTransactionsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.recordTransactionsButton.Location = new System.Drawing.Point(51, 308);
      this.recordTransactionsButton.Name = "recordTransactionsButton";
      this.recordTransactionsButton.Size = new System.Drawing.Size(117, 51);
      this.recordTransactionsButton.TabIndex = 12;
      this.recordTransactionsButton.Text = "Record Transactions";
      this.recordTransactionsButton.UseVisualStyleBackColor = true;
      this.recordTransactionsButton.Click += new System.EventHandler(this.recordTransactionsButton_Click);
      // 
      // denyOverdraftCheckBox
      // 
      this.denyOverdraftCheckBox.AutoSize = true;
      this.denyOverdraftCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.denyOverdraftCheckBox.Location = new System.Drawing.Point(12, 257);
      this.denyOverdraftCheckBox.Name = "denyOverdraftCheckBox";
      this.denyOverdraftCheckBox.Size = new System.Drawing.Size(143, 25);
      this.denyOverdraftCheckBox.TabIndex = 13;
      this.denyOverdraftCheckBox.Text = "Deny Overdrafts";
      this.denyOverdraftCheckBox.UseVisualStyleBackColor = true;
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(932, 450);
      this.Controls.Add(this.denyOverdraftCheckBox);
      this.Controls.Add(this.recordTransactionsButton);
      this.Controls.Add(this.savingsTransactionsListBox);
      this.Controls.Add(this.checkingTransactionsListBox);
      this.Controls.Add(this.headerSavingsTransactionsLabel);
      this.Controls.Add(this.headerCheckingTransactionsLabel);
      this.Controls.Add(this.overdraftLabel);
      this.Controls.Add(this.savingsAmountLabel);
      this.Controls.Add(this.checkingAmountLabel);
      this.Controls.Add(this.customerValueLabel);
      this.Controls.Add(this.headerSavingsBalanceLabel);
      this.Controls.Add(this.headerCheckingBalanceLabel);
      this.Controls.Add(this.headerCustomerLabel);
      this.Controls.Add(this.headerBankingDemoLabel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Dashboard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Banking Dashboard";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerBankingDemoLabel;
    private System.Windows.Forms.Label headerCustomerLabel;
    private System.Windows.Forms.Label headerCheckingBalanceLabel;
    private System.Windows.Forms.Label headerSavingsBalanceLabel;
    private System.Windows.Forms.Label customerValueLabel;
    private System.Windows.Forms.Label checkingAmountLabel;
    private System.Windows.Forms.Label savingsAmountLabel;
    private System.Windows.Forms.Label overdraftLabel;
    private System.Windows.Forms.Label headerCheckingTransactionsLabel;
    private System.Windows.Forms.Label headerSavingsTransactionsLabel;
    private System.Windows.Forms.ListBox checkingTransactionsListBox;
    private System.Windows.Forms.ListBox savingsTransactionsListBox;
    private System.Windows.Forms.Button recordTransactionsButton;
    private System.Windows.Forms.CheckBox denyOverdraftCheckBox;
  }
}

