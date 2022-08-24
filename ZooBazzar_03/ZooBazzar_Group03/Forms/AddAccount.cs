using DataAccessLayer;
using Entities;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazzar_Group03.Forms
{
    public partial class AddAccount : Form
    {
        private AccountManager accountManager = new AccountManager(new AccountManagerDB(), new AccountManagerDB());
        private Panel panel;
        public AddAccount(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbUsername.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                Account temp = new Account(tbUsername.Text, tbPassword.Text);
                if (!accountManager.isExisting(temp))
                {
                    accountManager.AddAccount(temp);
                    AddEmployee addEmployee = new AddEmployee(accountManager.Accounts.First(a => a.Username == temp.Username),panel);

                    addEmployee.TopLevel = false;
                    addEmployee.FormBorderStyle = FormBorderStyle.None;
                    addEmployee.Dock = DockStyle.Fill;
                    panel.Controls.Clear();
                    panel.Controls.Add(addEmployee);
                    panel.Tag = addEmployee;
                    addEmployee.BringToFront();
                    addEmployee.Show();
                }
                else
                {
                    MessageBox.Show("The account already exists!");
                }

            }
        }
    }
}
