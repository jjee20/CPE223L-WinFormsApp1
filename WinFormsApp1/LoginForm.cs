using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Domain.Models;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private PasswordHasher<AppUser> _passwordHasher = new();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using var context = new Infastructure.Data.AppDbContext();
            var user = context.Users.FirstOrDefault(u => u.UserName == txtBoxUserName.Text.Trim());

            if(user != null)
            {
                //MessageBox.Show("User found. Verifying password...");

                var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, txtBoxPassword.Text.Trim());

                if(passwordVerificationResult == PasswordVerificationResult.Success)
                {
                    MessageBox.Show("Login successful!");
                    // Proceed to the next form or main application window
                    Hide();
                    var mainForm = new Form1();
                    mainForm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid password.");
                    return;
                }


            }
            else
            {
                MessageBox.Show("User not found.");
                return;
            }
        }
    }
}
