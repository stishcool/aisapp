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
    public partial class CartForm : Form
    {
        private readonly UserSessionService _userSessionService;
        private readonly IServiceProvider _serviceProvider;
        public CartForm(UserSessionService userSessionService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userSessionService = userSessionService;
            _serviceProvider = serviceProvider;

            this.Load += GetCart;

            var userEmail = _userSessionService.UserEmail;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var mainPageLoggedIn = new MainPageLoggedIn(userSessionService, _serviceProvider);
            mainPageLoggedIn.Show();
        }

        private async void GetCart(object sender, EventArgs e)
        {
            try
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();

                    //email пользователя из UserSessionService
                    var userEmail = _userSessionService.UserEmail;

                    //данные о товарах из корзины пользователя
                    var cartItems = await context.CartProducts
                        .Include(cp => cp.Product)
                        .Where(cp => cp.Cart.Client.Email == userEmail)
                        .ToListAsync();

                    if (cartItems.Any()) //проверка наличия элементов в списке
                    {
                        //вычисляем среднее 
                        decimal avgCost = cartItems.Average(cp => cp.Product.Price);

                        lAvg.Text = $"Средняя цена товаров: {avgCost} руб.";

                        //вычисляем сумму
                        decimal totalCost = cartItems.Sum(cp => cp.Product.Price); 

                        lTotalCost.Text = $"Итого: {totalCost} руб.";

                        //привязываем данные к DataGridView
                        dataGridView1.DataSource = cartItems.Select(cp => new
                        {
                            Название = cp.Product.Name,
                            Описание = cp.Product.Description,
                            Цена = cp.Product.Price,
                            Количество = cp.Quantity,
                        }).ToList();
                    }
                    else
                    {
                        //если пусто
                        MessageBox.Show("Ваша корзина пуста", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();

                    //email пользователя из UserSessionService
                    var userEmail = _userSessionService.UserEmail;

                    //данные о товарах из корзины пользователя
                    var cartItems = await context.CartProducts
                        .Include(cp => cp.Product)
                        .Where(cp => cp.Cart.Client.Email == userEmail)
                        .ToListAsync();

                    var filteredData = new List<dynamic>();

                    if (cBoxDescription.Checked == false)
                    {
                        filteredData = cartItems.Select(cp => new
                        {
                            Название = cp.Product.Name,
                            Цена = cp.Product.Price,
                        }).Cast<dynamic>().ToList();
                    }
                    else
                    {
                        filteredData = cartItems.Select(cp => new
                        {
                            Название = cp.Product.Name,
                            Описание = cp.Product.Description,
                            Цена = cp.Product.Price,
                        }).Cast<dynamic>().ToList();
                    }

                    //диалоговое окно сохранени
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //поток для записи в выбранный файл
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            //заголовки столбцов
                            if (cBoxDescription.Checked)
                            {
                                writer.WriteLine("Название продукта\tОписание\tЦена");
                            }
                            else
                            {
                                writer.WriteLine("Название продукта\tЦена");
                            }

                            //отфильтрованные данные в файл
                            foreach (var item in filteredData)
                            {
                                if (cBoxDescription.Checked)
                                {
                                    writer.WriteLine($"{item.Название}\t{item.Описание}\t{item.Цена}");
                                }
                                else
                                {
                                    writer.WriteLine($"{item.Название}\t{item.Цена}");
                                }
                            }
                        }

                        MessageBox.Show("Данные успешно экспортированы в файл", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnClear_Click(object sender, EventArgs e)
{
        using (var scope = _serviceProvider.CreateScope())
        {
        var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();

        var userEmail = _userSessionService.UserEmail;

        //клиент по email
        var client = await context.Clients
            .Include(c => c.Carts)
            .ThenInclude(c => c.CartProducts)
            .FirstOrDefaultAsync(c => c.Email == userEmail);

        if (client != null)
        {
            //корзина клиента
            var cart = client.Carts.FirstOrDefault();

            if (cart != null)
            {
                //удаление из корзины и возвращение в список товаров
                foreach (var cartProduct in cart.CartProducts)
                {
                    var product = await context.Products.FindAsync(cartProduct.ProductId);
                    if (product != null)
                    {
                        //величение кол-ва товаров в списке товаров на кол-во товаров в корзине
                        product.Quantity += cartProduct.Quantity;
                    }

                    // Удаляем товар из корзины
                    context.CartProducts.Remove(cartProduct);
                }

                await context.SaveChangesAsync();

                MessageBox.Show("Корзина успешно очищена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCart(sender, e); //обновление данных в DataGrid
            }
            else
            {
                MessageBox.Show("Корзина пуста", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Клиент не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
        }

    }
}