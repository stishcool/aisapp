using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Npgsql.EntityFrameworkCore.PostgreSQL;


namespace aisapp
{
    public partial class DatabaseForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public DatabaseForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string database = txtDatabase.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(server) || string.IsNullOrWhiteSpace(database) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = $"Server={server};Database={database};User Id={username};Password={password};";

            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AisAppContext>();
                optionsBuilder.UseNpgsql(connectionString);

                using (var context = new AisAppContext(optionsBuilder.Options))
                {
                    //проверка 
                    if (context.Database.CanConnect())
                    {
                        MessageBox.Show("Соединение установлено успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                    }
                    else
                    {
                        MessageBox.Show("Не удалось установить соединение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при подключении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
