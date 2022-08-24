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
    public partial class Settings : Form
    {
        private AccountManager accountManager = new AccountManager(new AccountManagerDB(), new AccountManagerDB());
        private Account account;
        public Settings(Account account)
        {
            InitializeComponent();

            this.account = account;
            tbUsernameSettings.Text = account.Username;
           
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPasswordSettings.Text))
            {
                accountManager.UpdatePassword(new Account(account.Username, tbPasswordSettings.Text, account.Salt, account.Id));
            }
        }
        private void LoadTheame()
        {

            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ColorThemeHandler.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ColorThemeHandler.SecondaryColor;
                }
                else if (btns.GetType() == typeof(Label))
                {
                    btns.BackColor = ColorThemeHandler.PrimaryColor;
                    btns.ForeColor = Color.White;
                }

            }

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadTheame();
        }
    }
}
