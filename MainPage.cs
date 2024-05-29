using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aisapp
{
    public partial class MainPage : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainPage(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var registrationForm = new RegistrationForm(_serviceProvider, userSessionService);
            registrationForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var loginForm = new LoginForm(_serviceProvider, userSessionService);
            loginForm.Show();
        }

        private void lblCategoryTelevisors_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var categoryTelevisorsForm = new CategoryTelevisors(_serviceProvider, userSessionService);
            categoryTelevisorsForm.Show();
        }

        private void lblCategorySmartphones_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoryComputers_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoryLaptops_Click(object sender, EventArgs e)
        {

        }

        private void pBoxSale_Click(object sender, EventArgs e)
        {

        }

        private void pBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            var databaseForm = new DatabaseForm(_serviceProvider);
            databaseForm.Show();
            databaseForm.FormClosed += (s, args) => this.Show(); //главная форма после закрытия 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var categoryTelevisorsForm = new CategoryTelevisors(_serviceProvider, userSessionService);
            categoryTelevisorsForm.Show();
        }
    }
}
