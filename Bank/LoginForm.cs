using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
  public partial class LoginForm : MetroFramework.Forms.MetroForm
  {
    
    public LoginForm()
    {
      InitializeComponent();
      this.dB = new DB();
      

      this.PassField.Size = new Size(this.PassField.Size.Width, 64);
      this.PassField.AutoSize = false;
    }
    private DB dB;

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {

    }

    private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

   

    private Point lastPoint;

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if(e.Button == MouseButtons.Left) {
        this.Left += e.X - lastPoint.X;
        this.Top += e.Y - lastPoint.Y;
      }
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      this.lastPoint = new Point(e.X, e.Y);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      dB.openConnection();
      String login = LoginField.Text;
      String password = Utils.Encrypt(PassField.Text);
      String accountType = this.accountType.Text;

      DataTable table = new DataTable();
      OleDbDataAdapter adapter = new OleDbDataAdapter();


      if (accountType == "Клиент")
      {
        String strSQL = " Select * FROM Clients " + "WHERE Login = ? AND Password = ?";

        OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());

        cmdIC.Parameters.Add("@Login", MySqlDbType.VarChar).Value = login;
        cmdIC.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password;


        adapter.SelectCommand = cmdIC;
        adapter.Fill(table);

        if (table.Rows.Count > 0)
        {
          MessageBox.Show("OK");
          User user = new User();
          user.id = (int)table.Rows[0][0];
          user.FIO = (String)table.Rows[0][1];
          user.BirthDate = ((DateTime)table.Rows[0][2]).ToString();
          user.Sex = (String)table.Rows[0][3];
          user.DocumentNumber = (String)table.Rows[0][4];
          user.login = (String)table.Rows[0][5];
          user.Role = accountType;
          Utils.currentUser = user;
          this.Hide();
          MainForm mainForm = new MainForm();
          mainForm.Show();
        }
        else
        {
          MessageBox.Show("Failed");
        }
      }
      else if (accountType == "Сотрудник Отдела Маркетинга")
      {
        String strSQL = " Select * FROM Employee " + "WHERE Login = ? AND Password = ?";

        OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());

        cmdIC.Parameters.Add("@Login", MySqlDbType.VarChar).Value = login;
        cmdIC.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password;


        adapter.SelectCommand = cmdIC;
        adapter.Fill(table);

        if (table.Rows.Count > 0)
        {
          MessageBox.Show("OK");
          User user = new User();
          user.id = (int)table.Rows[0][0];
          user.FIO = (String)table.Rows[0][1];
          user.BirthDate = ((DateTime)table.Rows[0][2]).ToString();
          user.Sex = (String)table.Rows[0][3];
          user.DocumentNumber = (String)table.Rows[0][4];
          user.login = (String)table.Rows[0][5];
          user.Role = accountType;
          Utils.currentUser = user;
          this.Hide();
          MainMarketingForm mainMarketingForm = new MainMarketingForm();
          mainMarketingForm.Show();

        }
      }
      else if (accountType == "Сотрудник Финансового Отдела")
      {
        String strSQL = " Select * FROM Employee " + "WHERE Login = ? AND Password = ?";

        OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());

        cmdIC.Parameters.Add("@Login", MySqlDbType.VarChar).Value = login;
        cmdIC.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password;


        adapter.SelectCommand = cmdIC;
        adapter.Fill(table);

        if (table.Rows.Count > 0)
        {
          MessageBox.Show("OK");
          User user = new User();
          user.id = (int)table.Rows[0][0];
          user.FIO = (String)table.Rows[0][1];
          user.BirthDate = ((DateTime)table.Rows[0][2]).ToString();
          user.Sex = (String)table.Rows[0][3];
          user.DocumentNumber = (String)table.Rows[0][4];
          user.login = (String)table.Rows[0][5];
          user.Role = accountType;
          Utils.currentUser = user;
          this.Hide();
          MainFormFinance mainFormFinance = new MainFormFinance();
          mainFormFinance.Show();

        }


      }
      dB.closeConnection();
    }

    private void Autorization_MouseDown(object sender, MouseEventArgs e)
    {
      this.lastPoint = new Point(e.X, e.Y);
    }

    private void Autorization_MouseEnter(object sender, EventArgs e)
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

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void PassField_TextChanged(object sender, EventArgs e)
    {

    }

    private void LoginField_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      this.Hide();
      RegisterForm registerForm = new RegisterForm();
      registerForm.Show();
    }

    private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      LoginField.Text = Utils.Encrypt("1234");
    }
  }
}
