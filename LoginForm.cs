using Microsoft.EntityFrameworkCore;
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
    public partial class LoginForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserSessionService _userSessionService;

        public LoginForm(IServiceProvider serviceProvider, UserSessionService userSessionService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userSessionService = userSessionService;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Все поля обязательны для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (email == "admin" && password == "admin")
            {
                this.Close();
                var adminPanelForm = _serviceProvider.GetRequiredService<AdminPanelForm>();
                adminPanelForm.Show();
                return;
            }
            //проверка формата email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Некорректный формат email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool userExists = await ValidateUserAsync(email, password);

            if (userExists)
            {  

                    _userSessionService.UserEmail = email; //сохранение email 
                    MessageBox.Show("Вход успешен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    var mainPageLoggedIn = _serviceProvider.GetRequiredService<MainPageLoggedIn>();
                    mainPageLoggedIn.Show();

            }
            else
            {
                MessageBox.Show("Данные введены неверно или такого пользователя не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> ValidateUserAsync(string email, string password)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();
                return await context.Clients.AnyAsync(client => client.Email == email && client.Password == password);
            }
        }

        private bool IsValidEmail(string email)
        {
            //проверка формата email
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
