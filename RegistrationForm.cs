using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aisapp
{
    public partial class RegistrationForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserSessionService _userSessionService;

        public RegistrationForm(IServiceProvider serviceProvider, UserSessionService userSessionService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userSessionService = userSessionService;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string patronymic = txtPatronymic.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            //проверка на пустые поля
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(patronymic) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Все поля обязательны для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //проверка формата email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Некорректный формат email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //проверка пароля
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Пароль должен содержать как минимум 8 символов, одну заглавную букву, одну цифру и один специальный символ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //проверка телефона
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Некорректный формат телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //проверка имени фамилии
            if (!IsValidName(name) || !IsValidName(surname) || !IsValidName(patronymic))
            {
                MessageBox.Show("Имя, фамилия и отчество должны содержать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //проверка на уникальность email
            if (await EmailExistsAsync(email))
            {
                MessageBox.Show("Пользователь с таким email уже зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();
                var user = new Client { Name = name, Surname = surname, Patronymic = patronymic, Email = email, Password = password, Phone = "+7" + phone, Address = address };
                context.Clients.Add(user);
                await context.SaveChangesAsync();
                _userSessionService.UserEmail = email; //сохранение email 
                this.Close();
                var mainPageLoggedIn = _serviceProvider.GetRequiredService<MainPageLoggedIn>();
                mainPageLoggedIn.Show();
            }

            MessageBox.Show("Регистрация успешна", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task<bool> EmailExistsAsync(string email)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();
                return await context.Clients.AnyAsync(client => client.Email == email);
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

        private bool IsValidPassword(string password)
        {
            //пароль не менее 8 символов и хотя бы одна заглавная буква, одна цифра и один специальный символ
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private bool IsValidPhone(string phone)
        {
            //проверка номера телефона (должен состоять из цифр и быть длиной до 10)
            return Regex.IsMatch(phone, @"^\d{10,10}$");
        }

        private bool IsValidName(string name)
        {
            //должно содержать только буквы
            return name.All(char.IsLetter);
        }
    }
}
