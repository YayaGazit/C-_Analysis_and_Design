﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_27
{
    public partial class HomePageCustomerService : Form
    {
        public HomePageCustomerService()
        {
            InitializeComponent();
        }

        private void Customers_CRUD_Click(object sender, EventArgs e)
        {
            Crud_Customer CC = new Crud_Customer();
            CC.Show();
            this.Hide();
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            {
                Global.currentUser = null;
                this.Close();
                Login log = new Login();
                log.Show();
            }
        }
    }
}
