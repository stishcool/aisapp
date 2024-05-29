using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aisapp
{
    public partial class AdminPanelForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Dictionary<string, int> categoryIds, productIds;

        public AdminPanelForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            categoryIds = new Dictionary<string, int>
            {
                { "Телевизоры", 1 },
                { "Смартфоны", 2 },
                { "Компьютеры", 3 },
                { "Ноутбуки", 4 }
            };

            productIds = new Dictionary<string, int>
            {
                { "Samsung", 5 },
                { "LG", 6 },
                { "Sony", 7 },
                { "Panasonic", 8 }
            };

            cmBoxCategoryAdd.Items.AddRange(categoryIds.Keys.ToArray());
            cmBoxProductAdd.Items.AddRange(productIds.Keys.ToArray());
            cmBoxCategoryDelete.Items.AddRange(categoryIds.Keys.ToArray());
            cmBoxProductDelete.Items.AddRange(productIds.Keys.ToArray());
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmBoxProductAdd.SelectedItem != null && numUDAdd.Value > 0)
            {
                int productId = productIds[cmBoxProductAdd.SelectedItem.ToString()];
                int quantityToAdd = (int)numUDAdd.Value;

                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();

                    var product = await context.Products.FindAsync(productId);

                    if (product != null)
                    {
                        product.Quantity += quantityToAdd;
                        await context.SaveChangesAsync();
                        MessageBox.Show($"Добавлено {quantityToAdd} единиц товара '{product.Name}'", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Выбранный товар не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите товар и укажите количество для добавления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmBoxProductDelete.SelectedItem != null && numUDDelete.Value > 0)
            {
                int productId = productIds[cmBoxProductDelete.SelectedItem.ToString()];
                int quantityToDelete = (int)numUDDelete.Value;

                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();

                    var product = await context.Products.FindAsync(productId);

                    if (product != null)
                    {
                        if (product.Quantity >= quantityToDelete)
                        {
                            product.Quantity -= quantityToDelete;
                            await context.SaveChangesAsync();
                            MessageBox.Show($"Удалено {quantityToDelete} единиц товара '{product.Name}'", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Недостаточно товара '{product.Name}' для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выбранный товар не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите товар и укажите количество для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();
                var query = context.Clients.AsQueryable();

                if (checkBoxName.Checked && !string.IsNullOrEmpty(txtSearchName.Text))
                {
                    query = query.Where(u => u.Name.Contains(txtSearchName.Text));
                }

                if (checkBoxSurname.Checked && !string.IsNullOrEmpty(txtSearchSurmane.Text))
                {
                    query = query.Where(u => u.Surname.Contains(txtSearchSurmane.Text));
                }

                var clients = await query.ToListAsync();
                dataGridViewSearch.DataSource = clients.Select(u => new
                {
                    ID = u.Id,
                    Имя = u.Name,
                    Фамилия = u.Surname,
                    Email = u.Email
                }).ToList();
            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDeleteUser.Text, out int userId))
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();

                    var client = await context.Clients.FindAsync(userId);
                    if (client != null)
                    {
                        context.Clients.Remove(client);
                        await context.SaveChangesAsync();
                        MessageBox.Show($"Пользователь с ID {userId} удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtShow.Text, out int userId))
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();

                    var client = await context.Clients.FindAsync(userId);
                    if (client != null)
                    {
                        richTextBoxUserShow.Text = $"ID: {client.Id}\nИмя: {client.Name}\nФамилия: {client.Surname}\nОтчество: {client.Patronymic}\nEmail: {client.Email}\nТелефон: {client.Phone}\nАдрес: {client.Address}";
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetCart(object sender, EventArgs e)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();
                var products = await context.Products
                                            .Where(p => productIds.Values.Contains(p.Id))
                                            .Select(p => new
                                            {
                                                p.Name,
                                                p.Description,
                                                p.Price,
                                                p.Quantity
                                            })
                                            .ToListAsync();

                dataGridViewSearch.DataSource = products;
            }
        }
    }
}