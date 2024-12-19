using System;
using System.Windows.Forms;

namespace TRPO_LAB2
{
    public partial class LoginForm : Form
        {
            public LoginForm()
            {
                InitializeComponents();
            }

            private void InitializeComponents()
            {
                this.Text = "Login";
                this.Size = new System.Drawing.Size(300, 200);

                var labelUsername = new Label() { Text = "Username:", Location = new System.Drawing.Point(20, 30) };
                var labelPassword = new Label() { Text = "Password:", Location = new System.Drawing.Point(20, 70) };

                var textBoxUsername = new TextBox() { Location = new System.Drawing.Point(100, 30), Width = 150 };
                var textBoxPassword = new TextBox() { Location = new System.Drawing.Point(100, 70), Width = 150, PasswordChar = '*' };

                var buttonLogin = new Button() { Text = "Login", Location = new System.Drawing.Point(100, 110), Width = 100 };
                buttonLogin.Click += (sender, args) =>
                {
                    // Пример проверки
                    if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "1234")
                    {
                        var mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials!");
                    }
                };

                this.Controls.Add(labelUsername);
                this.Controls.Add(labelPassword);
                this.Controls.Add(textBoxUsername);
                this.Controls.Add(textBoxPassword);
                this.Controls.Add(buttonLogin);
            }
        }
    }
