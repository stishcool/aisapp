using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aisapp
{
    public partial class AccountForm : Form
    {
        private readonly UserSessionService _userSessionService;
        private readonly IServiceProvider _serviceProvider;
        public AccountForm(UserSessionService userSessionService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userSessionService = userSessionService;
            _serviceProvider = serviceProvider;

            var userEmail = _userSessionService.UserEmail;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var mainPageLoggedIn = new MainPageLoggedIn(userSessionService, _serviceProvider);
            mainPageLoggedIn.Show();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //email из UserSessionService
                var userEmail = _userSessionService.UserEmail;

                //данные из заполненных лейблов
                string password = !string.IsNullOrWhiteSpace(txtPassword.Text) ? txtPassword.Text : null;
                string name = !string.IsNullOrWhiteSpace(txtName.Text) ? txtName.Text : null;
                string surname = !string.IsNullOrWhiteSpace(txtSurname.Text) ? txtSurname.Text : null;
                string patronymic = !string.IsNullOrWhiteSpace(txtPatronymic.Text) ? txtPatronymic.Text : null;
                string phone = !string.IsNullOrWhiteSpace(txtPhone.Text) ? txtPhone.Text : null;
                string address = !string.IsNullOrWhiteSpace(txtAddress.Text) ? txtAddress.Text : null;

                //поиск пользователя по email в бд
                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();

                    var user = await context.Clients.FirstOrDefaultAsync(u => u.Email == userEmail);

                    if (user != null)
                    {
                        //обновляем только введенные данные  
                        if (password != null)
                            //проверка  пароля
                            if (!IsValidPassword(password))
                            {
                                MessageBox.Show("Пароль должен содержать как минимум 8 символов, одну заглавную букву, одну цифру и один специальный символ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        user.Password = password;

                        if (name != null)
                            //проверка имени
                            if (!IsValidName(name))
                            {
                                MessageBox.Show("Имя, фамилия и отчество должны содержать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        user.Name = name;

                        if (surname != null)
                            //проверка фамилии
                            if (!IsValidName(surname))
                            {
                                MessageBox.Show("Имя, фамилия и отчество должны содержать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        user.Surname = surname;

                        if (patronymic != null)
                            //проверка отчества
                            if (!IsValidName(patronymic))
                            {
                                MessageBox.Show("Имя, фамилия и отчество должны содержать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        user.Patronymic = patronymic;

                        if (phone != null)
                            //проверка телефона
                            if (!IsValidPhone(phone))
                            {
                                MessageBox.Show("Некорректный формат телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        user.Phone = "+7" + phone;

                        if (address != null)
                            user.Address = address;

                        //сохранение бд
                        await context.SaveChangesAsync();

                        MessageBox.Show("Данные пользователя успешно обновлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с указанным email не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
