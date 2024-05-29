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
    public partial class MainPageLoggedIn : Form
    {
        private readonly UserSessionService _userSessionService;
        private readonly IServiceProvider _serviceProvider;

        public MainPageLoggedIn(UserSessionService userSessionService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userSessionService = userSessionService;
            _serviceProvider = serviceProvider;
        }

        private void lblCategoryTelevisors_Click(object sender, EventArgs e)
        {
            this.Close();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var categoryTelevisorsForm = new CategoryTelevisors(_serviceProvider, userSessionService);
            categoryTelevisorsForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var accountForm = new AccountForm(userSessionService, _serviceProvider);
            accountForm.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Close();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var cartForm = new CartForm(userSessionService, _serviceProvider);
            cartForm.Show();
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

        private void pBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void pBoxSale_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var categoryTelevisorsForm = new CategoryTelevisors(_serviceProvider, userSessionService);
            categoryTelevisorsForm.Show();
        }
    }
}