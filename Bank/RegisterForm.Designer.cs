
namespace Bank
{
  partial class RegisterForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
      this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
      this.panel2 = new System.Windows.Forms.Panel();
      this.Autorization = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.LoginField = new System.Windows.Forms.TextBox();
      this.NameField = new System.Windows.Forms.TextBox();
      this.DocumentField = new System.Windows.Forms.TextBox();
      this.secondName = new System.Windows.Forms.TextBox();
      this.PassField = new System.Windows.Forms.TextBox();
      this.buttonLogin = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.birthDateField = new MetroFramework.Controls.MetroDateTime();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.sexField = new MetroFramework.Controls.MetroComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.thirdName = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // metroStyleManager1
      // 
      this.metroStyleManager1.Owner = null;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel2.Controls.Add(this.Autorization);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 81);
      this.panel2.TabIndex = 0;
      // 
      // Autorization
      // 
      this.Autorization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Autorization.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Autorization.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Autorization.Location = new System.Drawing.Point(0, 0);
      this.Autorization.Name = "Autorization";
      this.Autorization.Size = new System.Drawing.Size(800, 81);
      this.Autorization.TabIndex = 0;
      this.Autorization.Text = "Регистрация";
      this.Autorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.Autorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseDown);
      this.Autorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Autorization_MouseMove);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(13, 87);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(64, 64);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(13, 168);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(64, 64);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 2;
      this.pictureBox2.TabStop = false;
      // 
      // LoginField
      // 
      this.LoginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.LoginField.Location = new System.Drawing.Point(98, 87);
      this.LoginField.Multiline = true;
      this.LoginField.Name = "LoginField";
      this.LoginField.Size = new System.Drawing.Size(210, 64);
      this.LoginField.TabIndex = 3;
      // 
      // NameField
      // 
      this.NameField.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.NameField.Location = new System.Drawing.Point(328, 87);
      this.NameField.Multiline = true;
      this.NameField.Name = "NameField";
      this.NameField.Size = new System.Drawing.Size(210, 64);
      this.NameField.TabIndex = 3;
      this.NameField.Enter += new System.EventHandler(this.textBox1_Enter);
      this.NameField.Leave += new System.EventHandler(this.textBox1_Leave);
      // 
      // DocumentField
      // 
      this.DocumentField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.DocumentField.Location = new System.Drawing.Point(568, 87);
      this.DocumentField.Multiline = true;
      this.DocumentField.Name = "DocumentField";
      this.DocumentField.Size = new System.Drawing.Size(210, 64);
      this.DocumentField.TabIndex = 3;
      this.DocumentField.Enter += new System.EventHandler(this.DocumentField_Enter);
      this.DocumentField.Leave += new System.EventHandler(this.DocumentField_Leave);
      // 
      // secondName
      // 
      this.secondName.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.secondName.Location = new System.Drawing.Point(328, 168);
      this.secondName.Multiline = true;
      this.secondName.Name = "secondName";
      this.secondName.Size = new System.Drawing.Size(210, 64);
      this.secondName.TabIndex = 3;
      this.secondName.TextChanged += new System.EventHandler(this.ссс);
      this.secondName.Enter += new System.EventHandler(this.secondName_Enter);
      this.secondName.Leave += new System.EventHandler(this.secondName_Leave);
      // 
      // PassField
      // 
      this.PassField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PassField.Location = new System.Drawing.Point(98, 168);
      this.PassField.Name = "PassField";
      this.PassField.Size = new System.Drawing.Size(210, 48);
      this.PassField.TabIndex = 3;
      this.PassField.UseSystemPasswordChar = true;
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
      this.buttonLogin.Location = new System.Drawing.Point(98, 421);
      this.buttonLogin.Name = "buttonLogin";
      this.buttonLogin.Size = new System.Drawing.Size(178, 48);
      this.buttonLogin.TabIndex = 4;
      this.buttonLogin.Text = "Login";
      this.buttonLogin.UseVisualStyleBackColor = false;
      this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
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
      this.button1.Location = new System.Drawing.Point(98, 260);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(178, 48);
      this.button1.TabIndex = 5;
      this.button1.Text = "Register";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // birthDateField
      // 
      this.birthDateField.Location = new System.Drawing.Point(568, 203);
      this.birthDateField.MinimumSize = new System.Drawing.Size(0, 29);
      this.birthDateField.Name = "birthDateField";
      this.birthDateField.Size = new System.Drawing.Size(200, 29);
      this.birthDateField.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(568, 168);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(183, 32);
      this.label1.TabIndex = 7;
      this.label1.Text = "Дата Рождения";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.sexField);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.birthDateField);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.buttonLogin);
      this.panel1.Controls.Add(this.PassField);
      this.panel1.Controls.Add(this.thirdName);
      this.panel1.Controls.Add(this.secondName);
      this.panel1.Controls.Add(this.DocumentField);
      this.panel1.Controls.Add(this.NameField);
      this.panel1.Controls.Add(this.LoginField);
      this.panel1.Controls.Add(this.pictureBox2);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 30);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 503);
      this.panel1.TabIndex = 2;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(82, 375);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(211, 33);
      this.label3.TabIndex = 9;
      this.label3.Text = "Есть аккаунт?";
      // 
      // sexField
      // 
      this.sexField.FormattingEnabled = true;
      this.sexField.ItemHeight = 23;
      this.sexField.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
      this.sexField.Location = new System.Drawing.Point(568, 279);
      this.sexField.Name = "sexField";
      this.sexField.Size = new System.Drawing.Size(99, 29);
      this.sexField.TabIndex = 8;
      this.sexField.UseSelectable = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(568, 244);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 32);
      this.label2.TabIndex = 7;
      this.label2.Text = "Пол";
      // 
      // thirdName
      // 
      this.thirdName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.thirdName.Location = new System.Drawing.Point(328, 254);
      this.thirdName.Multiline = true;
      this.thirdName.Name = "thirdName";
      this.thirdName.Size = new System.Drawing.Size(210, 64);
      this.thirdName.TabIndex = 3;
      this.thirdName.Enter += new System.EventHandler(this.thirdName_Enter);
      this.thirdName.Leave += new System.EventHandler(this.thirdName_Leave);
      // 
      // RegisterForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 533);
      this.Controls.Add(this.panel1);
      this.DisplayHeader = false;
      this.Name = "RegisterForm";
      this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
      this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
      this.Load += new System.EventHandler(this.RegisterForm_Load_1);
      ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label Autorization;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.TextBox LoginField;
    private System.Windows.Forms.TextBox NameField;
    private System.Windows.Forms.TextBox DocumentField;
    private System.Windows.Forms.TextBox secondName;
    private System.Windows.Forms.TextBox PassField;
    private System.Windows.Forms.Button buttonLogin;
    private System.Windows.Forms.Button button1;
    private MetroFramework.Controls.MetroDateTime birthDateField;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private MetroFramework.Controls.MetroComboBox sexField;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox thirdName;
    private System.Windows.Forms.Label label3;
  }
}