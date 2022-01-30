
namespace Bank
{
  partial class MakeCreditPayment
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
      this.accountSum = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.DepositSumLabel = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // accountSum
      // 
      this.accountSum.AutoSize = true;
      this.accountSum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.accountSum.Location = new System.Drawing.Point(269, 78);
      this.accountSum.Name = "accountSum";
      this.accountSum.Size = new System.Drawing.Size(0, 30);
      this.accountSum.TabIndex = 10;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(8, 78);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(147, 30);
      this.label3.TabIndex = 11;
      this.label3.Text = "Сумма счета:";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.SystemColors.Highlight;
      this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.button1.Location = new System.Drawing.Point(269, 185);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(143, 38);
      this.button1.TabIndex = 9;
      this.button1.Text = "Оплатить";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.textBox1.Location = new System.Drawing.Point(269, 143);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(135, 36);
      this.textBox1.TabIndex = 8;
      // 
      // DepositSumLabel
      // 
      this.DepositSumLabel.AutoSize = true;
      this.DepositSumLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.DepositSumLabel.Location = new System.Drawing.Point(269, 20);
      this.DepositSumLabel.Name = "DepositSumLabel";
      this.DepositSumLabel.Size = new System.Drawing.Size(0, 30);
      this.DepositSumLabel.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(8, 143);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(197, 30);
      this.label2.TabIndex = 5;
      this.label2.Text = "Сумма к платежу:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(8, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 30);
      this.label1.TabIndex = 6;
      this.label1.Text = "Сумма:";
      // 
      // MakeCreditPayment
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(420, 243);
      this.Controls.Add(this.accountSum);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.DepositSumLabel);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "MakeCreditPayment";
      this.Text = "MakeCreditPayment";
      this.Load += new System.EventHandler(this.MakeCreditPayment_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label accountSum;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label DepositSumLabel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}