
namespace Bank
{
  partial class MainMarketingForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMarketingForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
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
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 30);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(920, 540);
      this.panel1.TabIndex = 23;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.button1);
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
      this.button1.Location = new System.Drawing.Point(12, 174);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(150, 50);
      this.button1.TabIndex = 2;
      this.button1.Text = "Акции";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // creditsButton
      // 
      this.creditsButton.BackColor = System.Drawing.Color.DodgerBlue;
      this.creditsButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.creditsButton.Location = new System.Drawing.Point(12, 117);
      this.creditsButton.Name = "creditsButton";
      this.creditsButton.Size = new System.Drawing.Size(150, 50);
      this.creditsButton.TabIndex = 2;
      this.creditsButton.Text = "Услуги";
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
      this.depositsButton.Text = "Компании";
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
      this.label1.Text = "Главная страница";
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
      this.buttonLogin.Location = new System.Drawing.Point(261, 288);
      this.buttonLogin.Name = "buttonLogin";
      this.buttonLogin.Size = new System.Drawing.Size(178, 48);
      this.buttonLogin.TabIndex = 22;
      this.buttonLogin.Text = "Login";
      this.buttonLogin.UseVisualStyleBackColor = false;
      // 
      // PassField
      // 
      this.PassField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PassField.Location = new System.Drawing.Point(247, 200);
      this.PassField.Name = "PassField";
      this.PassField.Size = new System.Drawing.Size(210, 48);
      this.PassField.TabIndex = 20;
      this.PassField.UseSystemPasswordChar = true;
      // 
      // LoginField
      // 
      this.LoginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.LoginField.Location = new System.Drawing.Point(247, 106);
      this.LoginField.Multiline = true;
      this.LoginField.Name = "LoginField";
      this.LoginField.Size = new System.Drawing.Size(210, 64);
      this.LoginField.TabIndex = 21;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(89, 200);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(64, 64);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 19;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(89, 106);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(64, 64);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 18;
      this.pictureBox1.TabStop = false;
      // 
      // MainMarketingForm
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
      this.Name = "MainMarketingForm";
      this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
      this.Text = "MainMarketingForm";
      this.Load += new System.EventHandler(this.MainMarketingForm_Load);
      this.panel1.ResumeLayout(false);
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
  }
}