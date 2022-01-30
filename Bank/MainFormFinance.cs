using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
  public partial class MainFormFinance : MetroFramework.Forms.MetroForm
  {
    public MainFormFinance()
    {
      InitializeComponent();
    }

    private void MainFormFinance_Load(object sender, EventArgs e)
    {

    }

    private void depositsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      DepositsManagerForm depositsManagerForm = new DepositsManagerForm();
      depositsManagerForm.Show();
    }

    private void creditsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      CreditsManagerForm creditsManagerForm = new CreditsManagerForm();
      creditsManagerForm.Show();
    }
  }
}
