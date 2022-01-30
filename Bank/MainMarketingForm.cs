using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
  public partial class MainMarketingForm : MetroFramework.Forms.MetroForm
  {
    public MainMarketingForm()
    {
      InitializeComponent();
    }

    private void MainMarketingForm_Load(object sender, EventArgs e)
    {

    }

    private void depositsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      CompaniesForm companiesForm = new CompaniesForm();
      companiesForm.Show();
    }

    private void creditsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      ServicesManagerForm servicesManagerForm = new ServicesManagerForm();
      servicesManagerForm.Show();
    }
  }
}
