
namespace Bank
{
  partial class LoginForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.accountType = new MetroFramework.Controls.MetroComboBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.buttonLogin = new System.Windows.Forms.Button();
      this.PassField = new System.Windows.Forms.TextBox();
      this.LoginField = new System.Windows.Forms.TextBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.Autorization = new System.Windows.Forms.Label();
      this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.accountType);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.buttonLogin);
      this.panel1.Controls.Add(this.PassField);
      this.panel1.Controls.Add(this.LoginField);
      this.panel1.Controls.Add(this.pictureBox2);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 30);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(797, 358);
      this.panel1.TabIndex = 1;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(499, 111);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(167, 32);
      this.label1.TabIndex = 13;
      this.label1.Text = "Тип аккаунта";
      // 
      // accountType
      // 
      this.accountType.FormattingEnabled = true;
      this.accountType.ItemHeight = 23;
      this.accountType.Items.AddRange(new object[] {
            "Клиент",
            "Сотрудник Отдела Маркетинга",
            "Сотрудник Финансового Отдела"});
      this.accountType.Location = new System.Drawing.Point(499, 146);
      this.accountType.Name = "accountType";
      this.accountType.Size = new System.Drawing.Size(217, 29);
      this.accountType.TabIndex = 12;
      this.accountType.UseSelectable = true;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
      this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(522, 294);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(178, 48);
      this.button1.TabIndex = 11;
      this.button1.Text = "Register";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(499, 258);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(217, 33);
      this.label3.TabIndex = 10;
      this.label3.Text = "Нет аккаунта?";
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
      this.buttonLogin.Location = new System.Drawing.Point(247, 294);
      this.buttonLogin.Name = "buttonLogin";
      this.buttonLogin.Size = new System.Drawing.Size(178, 48);
      this.buttonLogin.TabIndex = 4;
      this.buttonLogin.Text = "Login";
      this.buttonLogin.UseVisualStyleBackColor = false;
      this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
      // 
      // PassField
      // 
      this.PassField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PassField.Location = new System.Drawing.Point(247, 205);
      this.PassField.Name = "PassField";
      this.PassField.Size = new System.Drawing.Size(210, 48);
      this.PassField.TabIndex = 3;
      this.PassField.UseSystemPasswordChar = true;
      this.PassField.TextChanged += new System.EventHandler(this.PassField_TextChanged);
      // 
      // LoginField
      // 
      this.LoginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.LoginField.Location = new System.Drawing.Point(247, 111);
      this.LoginField.Multiline = true;
      this.LoginField.Name = "LoginField";
      this.LoginField.Size = new System.Drawing.Size(210, 64);
      this.LoginField.TabIndex = 3;
      this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(89, 205);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(64, 64);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 2;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(89, 111);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(64, 64);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel2.Controls.Add(this.Autorization);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(797, 81);
      this.panel2.TabIndex = 0;
      // 
      // Autorization
      // 
      this.Autorization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Autorization.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Autorization.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Autorization.Location = new System.Drawing.Point(0, 0);
      this.Autorization.Name = "Autorization";
      this.Autorization.Size = new System.Drawing.Size(797, 81);
      this.Autorization.TabIndex = 0;
      this.Autorization.Text = "Авторизация";
      this.Autorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.Autorization.Click += new System.EventHandler(this.label1_Click);
      this.Autorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseDown);
      this.Autorization.MouseEnter += new System.EventHandler(this.Autorization_MouseEnter);
      this.Autorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseMove);
      // 
      // metroStyleManager1
      // 
      this.metroStyleManager1.Owner = null;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(797, 388);
      this.Controls.Add(this.panel1);
      this.DisplayHeader = false;
      this.Name = "LoginForm";
      this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label Autorization;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button buttonLogin;
    private System.Windows.Forms.TextBox PassField;
    private System.Windows.Forms.TextBox LoginField;
    private System.Windows.Forms.PictureBox pictureBox2;
    private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private MetroFramework.Controls.MetroComboBox accountType;
  }
}

