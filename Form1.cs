﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGitProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login1_OnLoginClick(object sender, ctrlLoginInfo.Login.LoginInfoEventArgs e)
        {
            MessageBox.Show($"Username : {e.Username}\n\nPassword : {e.Password}\n\nRemember me : {e.RememberMe}",
                "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
