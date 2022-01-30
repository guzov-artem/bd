
namespace Bank
{
  partial class MakeTransactionForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeTransactionForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.button2 = new System.Windows.Forms.Button();
      this.clientsBox = new System.Windows.Forms.ComboBox();
      this.SumText = new System.Windows.Forms.Label();
      this.Sumlabel = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.servicesButton = new System.Windows.Forms.Button();
      this.creditsButton = new System.Windows.Forms.Button();
      this.depositsButton = new System.Windows.Forms.Button();
      this.mainButton = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonLogin = new System.Windows.Forms.Button();
      this.PassField = new System.Windows.Forms.TextBox();
      this.LoginField = new System.Windows.Forms.TextBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.clientsBox);
      this.panel1.Controls.Add(this.SumText);
      this.panel1.Controls.Add(this.Sumlabel);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 30);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(920, 540);
      this.panel1.TabIndex = 17;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.DodgerBlue;
      this.button2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.button2.Location = new System.Drawing.Point(247, 314);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(159, 50);
      this.button2.TabIndex = 2;
      this.button2.Text = "Перевести";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // clientsBox
      // 
      this.clientsBox.FormattingEnabled = true;
      this.clientsBox.Location = new System.Drawing.Point(593, 235);
      this.clientsBox.Name = "clientsBox";
      this.clientsBox.Size = new System.Drawing.Size(121, 23);
      this.clientsBox.TabIndex = 6;
      // 
      // SumText
      // 
      this.SumText.AutoSize = true;
      this.SumText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.SumText.Location = new System.Drawing.Point(593, 91);
      this.SumText.Name = "SumText";
      this.SumText.Size = new System.Drawing.Size(0, 29);
      this.SumText.TabIndex = 5;
      // 
      // Sumlabel
      // 
      this.Sumlabel.AutoSize = true;
      this.Sumlabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.Sumlabel.Location = new System.Drawing.Point(247, 96);
      this.Sumlabel.Name = "Sumlabel";
      this.Sumlabel.Size = new System.Drawing.Size(206, 29);
      this.Sumlabel.TabIndex = 4;
      this.Sumlabel.Text = "Сумма на счете:";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.textBox1.Location = new System.Drawing.Point(593, 158);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(114, 45);
      this.textBox1.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(247, 224);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(159, 32);
      this.label3.TabIndex = 2;
      this.label3.Text = "Получатель:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(247, 158);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(240, 32);
      this.label2.TabIndex = 2;
      this.label2.Text = "Сумма к переводу:";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.button1);
      this.panel2.Controls.Add(this.servicesButton);
      this.panel2.Controls.Add(this.creditsButton);
      this.panel2.Controls.Add(this.depositsButton);
      this.panel2.Controls.Add(this.mainButton);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(0, 81);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(178, 459);
      this.panel2.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.DodgerBlue;
      this.button1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.button1.Location = new System.Drawing.Point(12, 233);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(150, 50);
      this.button1.TabIndex = 2;
      this.button1.Text = "Переводы";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // servicesButton
      // 
      this.servicesButton.BackColor = System.Drawing.Color.DodgerBlue;
      this.servicesButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.servicesButton.Location = new System.Drawing.Point(12, 177);
      this.servicesButton.Name = "servicesButton";
      this.servicesButton.Size = new System.Drawing.Size(150, 50);
      this.servicesButton.TabIndex = 2;
      this.servicesButton.Text = "Услуги";
      this.servicesButton.UseVisualStyleBackColor = false;
      this.servicesButton.Click += new System.EventHandler(this.servicesButton_Click);
      // 
      // creditsButton
      // 
      this.creditsButton.BackColor = System.Drawing.Color.DodgerBlue;
      this.creditsButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.creditsButton.Location = new System.Drawing.Point(12, 117);
      this.creditsButton.Name = "creditsButton";
      this.creditsButton.Size = new System.Drawing.Size(150, 50);
      this.creditsButton.TabIndex = 2;
      this.creditsButton.Text = "Кредиты";
      this.creditsButton.UseVisualStyleBackColor = false;
      this.creditsButton.Click += new System.EventHandler(this.creditsButton_Click);
      // 
      // depositsButton
      // 
      this.depositsButton.BackColor = System.Drawing.Color.DodgerBlue;
      this.depositsButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.depositsButton.Location = new System.Drawing.Point(12, 59);
      this.depositsButton.Name = "depositsButton";
      this.depositsButton.Size = new System.Drawing.Size(150, 50);
      this.depositsButton.TabIndex = 2;
      this.depositsButton.Text = "Депозиты";
      this.depositsButton.UseVisualStyleBackColor = false;
      this.depositsButton.Click += new System.EventHandler(this.depositsButton_Click);
      // 
      // mainButton
      // 
      this.mainButton.BackColor = System.Drawing.Color.DodgerBlue;
      this.mainButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.mainButton.Location = new System.Drawing.Point(12, 3);
      this.mainButton.Name = "mainButton";
      this.mainButton.Size = new System.Drawing.Size(150, 50);
      this.mainButton.TabIndex = 2;
      this.mainButton.Text = "Главная";
      this.mainButton.UseVisualStyleBackColor = false;
      this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel3.Controls.Add(this.label1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(920, 81);
      this.panel3.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(920, 81);
      this.label1.TabIndex = 0;
      this.label1.Text = "Переводы";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // buttonLogin
      // 
      this.buttonLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
      this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
      this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.buttonLogin.ForeColor = System.Drawing.Color.White;
      this.buttonLogin.Location = new System.Drawing.Point(261, 303);
      this.buttonLogin.Name = "buttonLogin";
      this.buttonLogin.Size = new System.Drawing.Size(178, 48);
      this.buttonLogin.TabIndex = 16;
      this.buttonLogin.Text = "Login";
      this.buttonLogin.UseVisualStyleBackColor = false;
      // 
      // PassField
      // 
      this.PassField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PassField.Location = new System.Drawing.Point(247, 215);
      this.PassField.Name = "PassField";
      this.PassField.Size = new System.Drawing.Size(210, 48);
      this.PassField.TabIndex = 14;
      this.PassField.UseSystemPasswordChar = true;
      // 
      // LoginField
      // 
      this.LoginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.LoginField.Location = new System.Drawing.Point(247, 121);
      this.LoginField.Multiline = true;
      this.LoginField.Name = "LoginField";
      this.LoginField.Size = new System.Drawing.Size(210, 64);
      this.LoginField.TabIndex = 15;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(89, 215);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(64, 64);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 13;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(89, 121);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(64, 64);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 12;
      this.pictureBox1.TabStop = false;
      // 
      // MakeTransactionForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(920, 570);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.buttonLogin);
      this.Controls.Add(this.PassField);
      this.Controls.Add(this.LoginField);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.DisplayHeader = false;
      this.DoubleBuffered = false;
      this.Name = "MakeTransactionForm";
      this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
      this.Text = "MakeTransactionForm";
      this.Load += new System.EventHandler(this.MakeTransactionForm_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button servicesButton;
    private System.Windows.Forms.Button creditsButton;
    private System.Windows.Forms.Button depositsButton;
    private System.Windows.Forms.Button mainButton;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonLogin;
    private System.Windows.Forms.TextBox PassField;
    private System.Windows.Forms.TextBox LoginField;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox clientsBox;
    private System.Windows.Forms.Label SumText;
    private System.Windows.Forms.Label Sumlabel;
    private System.Windows.Forms.Button button2;
  }
}