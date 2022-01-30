
namespace Bank
{
  partial class CompaniesForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.makePayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.button2 = new System.Windows.Forms.Button();
      this.telephoneField = new System.Windows.Forms.TextBox();
      this.NameField = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
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
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
      this.tabPage2.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.panel1.Controls.Add(this.tabControl1);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 30);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(920, 540);
      this.panel1.TabIndex = 29;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.tabControl1.Location = new System.Drawing.Point(178, 81);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(742, 459);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.tabPage1.Controls.Add(this.metroGrid1);
      this.tabPage1.Location = new System.Drawing.Point(4, 34);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(734, 421);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Список компаний";
      this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
      // 
      // metroGrid1
      // 
      this.metroGrid1.AllowUserToAddRows = false;
      this.metroGrid1.AllowUserToDeleteRows = false;
      this.metroGrid1.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
      this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.metroGrid1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
      this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.metroGrid1.ColumnHeadersHeight = 56;
      this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.makePayment});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
      this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.metroGrid1.EnableHeadersVisualStyles = false;
      this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.metroGrid1.Location = new System.Drawing.Point(3, 40);
      this.metroGrid1.Name = "metroGrid1";
      this.metroGrid1.ReadOnly = true;
      this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle5;
      this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.metroGrid1.RowTemplate.Height = 50;
      this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.metroGrid1.Size = new System.Drawing.Size(728, 378);
      this.metroGrid1.TabIndex = 7;
      // 
      // Column5
      // 
      this.Column5.HeaderText = "Название";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Width = 150;
      // 
      // makePayment
      // 
      this.makePayment.HeaderText = "Телефон";
      this.makePayment.Name = "makePayment";
      this.makePayment.ReadOnly = true;
      this.makePayment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.makePayment.Width = 170;
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.tabPage2.Controls.Add(this.button2);
      this.tabPage2.Controls.Add(this.telephoneField);
      this.tabPage2.Controls.Add(this.NameField);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Location = new System.Drawing.Point(4, 34);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(734, 421);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Добавить компанию";
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.DodgerBlue;
      this.button2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.button2.Location = new System.Drawing.Point(39, 169);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(150, 50);
      this.button2.TabIndex = 2;
      this.button2.Text = "Добавить";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // telephoneField
      // 
      this.telephoneField.Location = new System.Drawing.Point(263, 94);
      this.telephoneField.Multiline = true;
      this.telephoneField.Name = "telephoneField";
      this.telephoneField.Size = new System.Drawing.Size(147, 42);
      this.telephoneField.TabIndex = 1;
      // 
      // NameField
      // 
      this.NameField.Location = new System.Drawing.Point(264, 33);
      this.NameField.Multiline = true;
      this.NameField.Name = "NameField";
      this.NameField.Size = new System.Drawing.Size(147, 42);
      this.NameField.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(39, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(106, 30);
      this.label3.TabIndex = 0;
      this.label3.Text = "Телефон:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(39, 36);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(116, 30);
      this.label2.TabIndex = 0;
      this.label2.Text = "Название:";
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
      this.label1.Text = "Компании";
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
      this.buttonLogin.Location = new System.Drawing.Point(261, 273);
      this.buttonLogin.Name = "buttonLogin";
      this.buttonLogin.Size = new System.Drawing.Size(178, 48);
      this.buttonLogin.TabIndex = 28;
      this.buttonLogin.Text = "Login";
      this.buttonLogin.UseVisualStyleBackColor = false;
      // 
      // PassField
      // 
      this.PassField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PassField.Location = new System.Drawing.Point(247, 185);
      this.PassField.Name = "PassField";
      this.PassField.Size = new System.Drawing.Size(210, 48);
      this.PassField.TabIndex = 26;
      this.PassField.UseSystemPasswordChar = true;
      // 
      // LoginField
      // 
      this.LoginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.LoginField.Location = new System.Drawing.Point(247, 91);
      this.LoginField.Multiline = true;
      this.LoginField.Name = "LoginField";
      this.LoginField.Size = new System.Drawing.Size(210, 64);
      this.LoginField.TabIndex = 27;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(89, 185);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(64, 64);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 25;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(89, 91);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(64, 64);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 24;
      this.pictureBox1.TabStop = false;
      // 
      // CompaniesForm
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
      this.Cursor = System.Windows.Forms.Cursors.Default;
      this.DisplayHeader = false;
      this.Name = "CompaniesForm";
      this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
      this.Text = "CompaniesForm";
      this.Load += new System.EventHandler(this.CompaniesForm_Load);
      this.panel1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
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
    private MetroFramework.Controls.MetroGrid metroGrid1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox telephoneField;
    private System.Windows.Forms.TextBox NameField;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn makePayment;
  }
}