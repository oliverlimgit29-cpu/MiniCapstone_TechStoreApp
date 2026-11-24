using MiniCapstone_TechStoreApp.DatabaseMongoDB;
using MiniCapstone_TechStoreApp.FormsUI;
using MiniCapstone_TechStoreApp.Helper;
using MiniCapstone_TechStoreApp.Models;
using MiniCapstone_TechStoreApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCapstone_TechStoreApp
{
    public partial class LoginForm : Form
    {
        //Login Test Credentials:
        //admin - 12345678
        //lim - 12345678
        private AuthenticatorService authService;

        public LoginForm(AuthenticatorService authService)
        {
            InitializeComponent();

            this.authService = authService;

            CenterLoginPanel();
            this.Resize += RegistrationForm_Resize;
        }

        private void CenterLoginPanel()
        {
            int panelWidth = pnlLogin.Width;
            int panelHeight = pnlLogin.Height;
            FormLayoutHelper.CenterPanel(this, pnlLogin, panelWidth, panelHeight);
        }

        private void RegistrationForm_Resize(object sender, EventArgs e)
        {
            CenterLoginPanel();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            btnLogin.Enabled = false;

            try
            {
                // Authenticate username and password
                UserDB user = await authService.LoginAsync(username, password);

                // Store the logged-in user
                UserSession.Login(user);

                // Open the appropriate dashboard
                if (UserSession.IsBuyer)
                {
                    UserDashboardForm buyerForm = new UserDashboardForm();

                    buyerForm.FormClosed += (s, args) =>
                    {
                        this.Show();
                    };

                    this.Hide();
                    buyerForm.Show();
                }
                else if (UserSession.IsAdmin)
                {
                    AdminDashboardForm adminForm = new AdminDashboardForm();

                    adminForm.FormClosed += (s, args) => { this.Show(); };

                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    UserSession.Logout();

                    MessageBox.Show("Invalid user role.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error");
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
