using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aisapp
{
    public partial class CategoryTelevisors : Form
    {
        private readonly UserSessionService _userSessionService;
        private readonly IServiceProvider _serviceProvider;
        Label[][] productLabels;
        bool logged;

        public CategoryTelevisors(IServiceProvider serviceProvider, UserSessionService userSessionService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userSessionService = userSessionService;

            productLabels = new Label[][]
            {
            new Label[] { lDescriptionT1, lCostT1, lQuantityT1 },
            new Label[] { lDescriptionT2, lCostT2, lQuantityT2 },
            new Label[] { lDescriptionT3, lCostT3, lQuantityT3 },
            new Label[] { lDescriptionT4, lCostT4, lQuantityT4 }
            };

            this.Load += CategoryTelevisors_Load;

            if (_userSessionService != null && _userSessionService.IsUserLoggedIn)
            {
                //для авторизованного пользователя
                var userEmail = _userSessionService.UserEmail;
                logged = true;
            }
            else
            {
                //для неавторизованного пользователя    
                btnAccount.Visible = false;
                btnCart.Visible = false;
                logged = false;
            }

        }

        private async void pBoxAddToCartT1_Click(object sender, EventArgs e)
        {
            await AddProductToCart(5); 
        }

        private async void pBoxAddToCartT2_Click(object sender, EventArgs e)
        {
            await AddProductToCart(6);
        }
        private async void pBoxAddToCartT3_Click(object sender, EventArgs e)
        {
            await AddProductToCart(7);
        }

        private async void pBoxAddToCartT4_Click(object sender, EventArgs e)
        {
            await AddProductToCart(8);
        }

        private async Task AddProductToCart(int productId)
        {
            if (_userSessionService != null && _userSessionService.IsUserLoggedIn)
            {
                try
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();
                        var userEmail = _userSessionService.UserEmail;

                        //находим клиента по email
                        var client = await context.Clients
                            .Include(c => c.Carts)
                            .ThenInclude(c => c.CartProducts)
                            .FirstOrDefaultAsync(c => c.Email == userEmail);

                        if (client == null)
                        {
                            MessageBox.Show("Клиент не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var product = await context.Products.FindAsync(productId);
                        if (product == null)
                        {
                            MessageBox.Show("Продукт не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //находим корзину клиента или создадим новую
                        var cart = client.Carts.FirstOrDefault();
                        if (cart == null)
                        {
                            cart = new Cart { Name = "Корзина по умолчанию", CartProducts = new List<CartProduct>() };
                            client.Carts.Add(cart);
                            context.Carts.Add(cart);
                        }

                        //есть ли уже такой товар товар 
                        var existingCartProduct = cart.CartProducts.FirstOrDefault(cp => cp.ProductId == productId);
                        if (existingCartProduct != null)
                        {
                            //увеличиваем кол-во
                            existingCartProduct.Quantity++;
                        }
                        else
                        {
                            //создаем новый CartProduct и добавляем корзину
                            var cartProduct = new CartProduct
                            {
                                Cart = cart,
                                Product = product,
                                Quantity = 1 
                            };

                            cart.CartProducts.Add(cartProduct);
                        }

                        //уменьшаем кол-во товаров на складе
                        product.Quantity--;

                        await context.SaveChangesAsync();

                        int productCount = cart.CartProducts.Sum(cp => cp.Quantity);

                        MessageBox.Show($"Продукт добавлен в корзину. Всего товаров в корзине: {productCount}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await LoadProductData(new int[] { 5, 6, 7, 8 }, productLabels);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Для добавления товара в корзину необходимо войти в систему", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void CategoryTelevisors_Load(object sender, EventArgs e)
        {
            //загрузка данных о продуктах 
            await LoadProductData(new int[] { 5, 6, 7, 8 }, productLabels);
        }

        private async Task LoadProductData(int[] productIds, Label[][] productLabels)
        {
            try
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AisAppContext>();

                    for (int i = 0; i < productIds.Length; i++)
                    {
                        int productId = productIds[i];

                        // Находим продукт по его идентификатору
                        var product = await context.Products.FindAsync(productId);

                        if (product != null)
                        {
                            // Устанавливаем значения Label на основе данных о продукте
                            productLabels[i][0].Text = $"Описание: {product.Description}";
                            productLabels[i][1].Text = $"Цена: {product.Price} руб.";
                            productLabels[i][2].Text = $"Количество: {product.Quantity}";
                        }
                        else
                        {
                            MessageBox.Show($"Продукт с идентификатором {productId} не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Close();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var cartForm = new CartForm(userSessionService, _serviceProvider);
            cartForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            var userSessionService = _serviceProvider.GetService<UserSessionService>();
            var accountForm = new AccountForm(userSessionService, _serviceProvider);
            accountForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (logged == true)
            {
                this.Close();
                var userSessionService = _serviceProvider.GetService<UserSessionService>();
                var mainPageLoggedIn = new MainPageLoggedIn(userSessionService, _serviceProvider);
                mainPageLoggedIn.Show();        
            }
            else
            {
                this.Close();
                var mainPage = new MainPage(_serviceProvider);
                mainPage.Show();
            } 
        }
    }
}
