using AutoservicesRul.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoservicesRul.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        List<Product> listProducts = new List<Product>();

        public OrderPage(List<Product> products, User user)
        {
            InitializeComponent();
            DataContext = this;
            listProducts = products;
            LViewOrder.ItemsSource = listProducts;

            cmbPickupPoint.ItemsSource = Entityes.Autoservice_RulEntities.GetContex().PickupPoint.ToList();

            if (user != null)
                txtUser.Text = user.UserSurname + " " + user.UserName + " " + user.UserPatronymic;
        }

        public string Total
        {
            get
            {
                var total = listProducts.Sum(p => Convert.ToDouble(p.ProductCost) - Convert.ToDouble(p.ProductCost) * Convert.ToDouble(p.ProductDiscountAmount / 100.00));
                return total.ToString();
            }
        }

        private void btnDeleteProductFromListProduct_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить этот элемент?", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                var p = LViewOrder.SelectedItem as Product;
                if (p != null)
                {
                    listProducts.Remove(p);
                    LViewOrder.ItemsSource = null;
                    LViewOrder.ItemsSource = listProducts;
                }
                else
                    MessageBox.Show("Вы не выбрали товар!\nДля выбора товара кликнете по ненужному товару ПКМ,\nа затем нажмите кнопку удаления из корзины","Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                
            }
               
        }

        private void btnOrderSave_Click(object sender, RoutedEventArgs e)
        {
            var productArticle = listProducts.Select(p => p.ProductArticleNumber).ToArray();
            Random random= new Random();
            var date = DateTime.Now;
            if (listProducts.Any(p => p.ProductQuantityInStock < 3))
                date = date.AddDays(6);
            else
                date = date.AddDays(3);

            if (cmbPickupPoint.SelectedItem == null)
            {
                MessageBox.Show("Выберите пункт выдачи заказа!","Информация",MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            try
            {
                Order newOrder = new Order()
                {
                    IdOrderStatus = 1,
                    OrderDate = DateTime.Now,
                    PickupPoint = cmbPickupPoint.SelectedItem as PickupPoint,
                    OrderDeliveryDate = date,
                    ReceiptCode = random.Next(100,1000),
                    ClientFullName = txtUser.Text
                };
                Autoservice_RulEntities.GetContex().Order.Add(newOrder);
                for (int i = 0; i < productArticle.Count(); i++)
                {
                    OrderProduct newOrderProduct = new OrderProduct()
                    {
                        OrderID = newOrder.OrderID,
                        ProductArticleNumber = productArticle[i],
                        Count = 1
                    };
                    Autoservice_RulEntities.GetContex().OrderProduct.Add(newOrderProduct);
                   
                }
                Autoservice_RulEntities.GetContex().SaveChanges();
                MessageBox.Show("Заказ оформлен", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new OrderTicketPage(newOrder, listProducts));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
