namespace WinFormUI
{
  partial class Transactions
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
      this.headerCreditCardMachineLabel = new System.Windows.Forms.Label();
      this.customerValueLabel = new System.Windows.Forms.Label();
      this.headerCustomerLabel = new System.Windows.Forms.Label();
      this.headerAmountLabel = new System.Windows.Forms.Label();
      this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.makePurchaseButton = new System.Windows.Forms.Button();
      this.overdraftLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // headerCreditCardMachineLabel
      // 
      this.headerCreditCardMachineLabel.AutoSize = true;
      this.headerCreditCardMachineLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerCreditCardMachineLabel.Location = new System.Drawing.Point(29, 9);
      this.headerCreditCardMachineLabel.Name = "headerCreditCardMachineLabel";
      this.headerCreditCardMachineLabel.Size = new System.Drawing.Size(260, 37);
      this.headerCreditCardMachineLabel.TabIndex = 1;
      this.headerCreditCardMachineLabel.Text = "Credit Card Machine";
      // 
      // customerValueLabel
      // 
      this.customerValueLabel.AutoSize = true;
      this.customerValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.customerValueLabel.Location = new System.Drawing.Point(173, 71);
      this.customerValueLabel.Name = "customerValueLabel";
      this.customerValueLabel.Size = new System.Drawing.Size(63, 20);
      this.customerValueLabel.TabIndex = 6;
      this.customerValueLabel.Text = "<none>";
      // 
      // headerCustomerLabel
      // 
      this.headerCustomerLabel.AutoSize = true;
      this.headerCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerCustomerLabel.Location = new System.Drawing.Point(15, 71);
      this.headerCustomerLabel.Name = "headerCustomerLabel";
      this.headerCustomerLabel.Size = new System.Drawing.Size(83, 21);
      this.headerCustomerLabel.TabIndex = 5;
      this.headerCustomerLabel.Text = "Customer";
      // 
      // headerAmountLabel
      // 
      this.headerAmountLabel.AutoSize = true;
      this.headerAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerAmountLabel.Location = new System.Drawing.Point(15, 132);
      this.headerAmountLabel.Name = "headerAmountLabel";
      this.headerAmountLabel.Size = new System.Drawing.Size(72, 21);
      this.headerAmountLabel.TabIndex = 7;
      this.headerAmountLabel.Text = "Amount";
      // 
      // amountNumericUpDown
      // 
      this.amountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.amountNumericUpDown.Location = new System.Drawing.Point(177, 132);
      this.amountNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.amountNumericUpDown.Name = "amountNumericUpDown";
      this.amountNumericUpDown.Size = new System.Drawing.Size(120, 26);
      this.amountNumericUpDown.TabIndex = 8;
      // 
      // makePurchaseButton
      // 
      this.makePurchaseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.makePurchaseButton.Location = new System.Drawing.Point(101, 194);
      this.makePurchaseButton.Name = "makePurchaseButton";
      this.makePurchaseButton.Size = new System.Drawing.Size(117, 51);
      this.makePurchaseButton.TabIndex = 13;
      this.makePurchaseButton.Text = "Make Purchase";
      this.makePurchaseButton.UseVisualStyleBackColor = true;
      this.makePurchaseButton.Click += new System.EventHandler(this.makePurchaseButton_Click);
      // 
      // overdraftLabel
      // 
      this.overdraftLabel.AutoSize = true;
      this.overdraftLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.overdraftLabel.ForeColor = System.Drawing.Color.Red;
      this.overdraftLabel.Location = new System.Drawing.Point(75, 262);
      this.overdraftLabel.Name = "overdraftLabel";
      this.overdraftLabel.Size = new System.Drawing.Size(161, 21);
      this.overdraftLabel.TabIndex = 14;
      this.overdraftLabel.Text = "You are overdrafting! ";
      this.overdraftLabel.Visible = false;
      this.overdraftLabel.Click += new System.EventHandler(this.overdraftLabel_Click);
      // 
      // Transactions
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(318, 292);
      this.Controls.Add(this.overdraftLabel);
      this.Controls.Add(this.makePurchaseButton);
      this.Controls.Add(this.amountNumericUpDown);
      this.Controls.Add(this.headerAmountLabel);
      this.Controls.Add(this.customerValueLabel);
      this.Controls.Add(this.headerCustomerLabel);
      this.Controls.Add(this.headerCreditCardMachineLabel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Transactions";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Transactions";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transactions_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerCreditCardMachineLabel;
    private System.Windows.Forms.Label customerValueLabel;
    private System.Windows.Forms.Label headerCustomerLabel;
    private System.Windows.Forms.Label headerAmountLabel;
    private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    private System.Windows.Forms.Button makePurchaseButton;
    private System.Windows.Forms.Label overdraftLabel;
  }
}