using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
  public partial class RegisterForm : MetroFramework.Forms.MetroForm
  {
    private DB dB;
    public RegisterForm()
    {
      InitializeComponent();

      this.PassField.Size = new Size(this.PassField.Size.Width, 64);
      this.PassField.AutoSize = false;
      this.dB = new DB();
      dB.openConnection();
      NameField.Text = "Введите имя";
      NameField.ForeColor = Color.Gray;

      secondName.Text = "Введите фамилию";
      secondName.ForeColor = Color.Gray;

      DocumentField.Text = "Введите паспорт";
      DocumentField.ForeColor = Color.Gray;

      thirdName.Text = "Введите отчество";
      thirdName.ForeColor = Color.Gray;

      birthDateField.Format = DateTimePickerFormat.Custom;
      birthDateField.CustomFormat = "dd/MM/yyyy";
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
    private void Autorization_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - lastPoint.X;
        this.Top += e.Y - lastPoint.Y;
      }
    }
    private void Autorization_MouseDown(object sender, MouseEventArgs e)
    {
      this.lastPoint = new Point(e.X, e.Y);
    }

    private Point lastPoint;

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - lastPoint.X;
        this.Top += e.Y - lastPoint.Y;
      }
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      this.lastPoint = new Point(e.X, e.Y);
    }
    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    

    

    private void textBox1_Enter(object sender, EventArgs e)
    {
      if(NameField.Text == "Введите имя") {
        NameField.Text = "";
        NameField.ForeColor = Color.Black;
      }
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      if (NameField.Text == "") {
        NameField.Text = "Введите имя";
        NameField.ForeColor = Color.Gray;
      }
    }

    private void DocumentField_Enter(object sender, EventArgs e)
    {
      if (DocumentField.Text == "Введите паспорт")
      {
        DocumentField.Text = "";
        DocumentField.ForeColor = Color.Black;
      }
    }

    private void DocumentField_Leave(object sender, EventArgs e)
    {
      if (DocumentField.Text == "")
      {
        DocumentField.Text = "Введите паспорт";
        DocumentField.ForeColor = Color.Gray;
      }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void secondName_Enter(object sender, EventArgs e)
    {
      if (secondName.Text == "Введите фамилию")
      {
        secondName.Text = "";
        secondName.ForeColor = Color.Black;
      }
    }

    private void secondName_Leave(object sender, EventArgs e)
    {
      if (secondName.Text == "")
      {
        secondName.Text = "Введите фамилию";
        secondName.ForeColor = Color.Gray;
      }
    }

    private void RegisterForm_Load_1(object sender, EventArgs e)
    {

    }

    private void ссс(object sender, EventArgs e)
    {

    }

    private void thirdName_Leave(object sender, EventArgs e)
    {
      if (thirdName.Text == "")
      {
        thirdName.Text = "Введите отчество";
        thirdName.ForeColor = Color.Gray;
      }
    }

    private void thirdName_Enter(object sender, EventArgs e)
    {
      if (thirdName.Text == "Введите отчество")
      {
        thirdName.Text = "";
        thirdName.ForeColor = Color.Black;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      String login = LoginField.Text;
      String password = Utils.Encrypt(PassField.Text);
      String FIO = secondName.Text + " " +  NameField.Text + " " + thirdName.Text;
      String Document = DocumentField.Text;
      String date = birthDateField.Text;
      String sex = "";
      if (sexField.Text == "Мужчина")
      {
        sex = "m";
      }
      else if (sexField.Text == "Женщина")
      {
        sex = "w";
      }

      DataTable table = new DataTable();

      OleDbDataAdapter adapter = new OleDbDataAdapter();



      String strSQL = "Insert Into Clients ([FIO], [BirthDate], [Sex], [DocumentNumber], [Login], [Password]) VALUES (?, ?, ?, ?, ?, ?)";

      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = FIO;
      cmdIC.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
      cmdIC.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;
      cmdIC.Parameters.Add("@Document", MySqlDbType.VarChar).Value = Document;
      cmdIC.Parameters.Add("@Login", MySqlDbType.VarChar).Value = login;
      cmdIC.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password;






      if (cmdIC.ExecuteNonQuery() == 1)
      {
        MessageBox.Show("Аккаунт был успешно создан! Войдите в него во вкладке login");
      }
      else
      {
        MessageBox.Show("Не удалось создать аккаунт(((");
      }
    }

    private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
      this.Hide();
      LoginForm loginForm = new LoginForm();
      loginForm.Show();
    }
  }
}
