using AutoservicesRul.Entityes;
using Microsoft.Win32;
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
    /// Логика взаимодействия для AddEditProductPage.xaml
    /// </summary>
    public partial class AddEditProductPage : Page
    {
        private Product product = new Product();
        private int _whatCanDo;
        public AddEditProductPage(Product curentProduct, int whatCanDo)
        {
            InitializeComponent();
            _whatCanDo = whatCanDo;
            if (curentProduct != null)
            {
                product = curentProduct;
                BtnDeleteProduct.Visibility = Visibility.Visible;
                txtbArticle.IsEnabled = false;
            }

            DataContext = product;

            cmbCategory.ItemsSource = CategoryList;
            cmbSupplier.ItemsSource = SupplierList;

            if (curentProduct != null)
            {
                cmbCategory.SelectedIndex = product.Category.IdCategory - 1;
                cmbSupplier.SelectedIndex = product.Supplier1.IdSupplier - 1;
            }


        }

        public string[] CategoryList =
        {
            "Автозапчасти",
            "Автосервис",
            "Аксессуары",
            "Зарядные устройства",
            "Ручные инструменты",
            "Съемники подшипников"
        };

        public string[] SupplierList =
        {
            "220-volt",
            "Максидом"
        };

        private void BtnEnterProductImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog GetImageDialog = new OpenFileDialog();
            GetImageDialog.Filter = "Файл изображений: (*.png, *.jpg, *.jpeg)| *.png; *.jpg; *.jpeg ";
            GetImageDialog.InitialDirectory = "C:\\Users\\student\\Desktop\\Задание на стажировку\\AutoservicesRul\\AutoservicesRul\\Resources";
            if (GetImageDialog.ShowDialog() == true)
            {
                product.ProductImage = GetImageDialog.SafeFileName;
            }
        }

        private void BtnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите удалить {product.ProductName}?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {

                try
                {
                    product.Deleted = true;
                    Autoservice_RulEntities.GetContex().Entry(product).State = System.Data.Entity.EntityState.Modified;
                    Autoservice_RulEntities.GetContex().SaveChanges();
                    MessageBox.Show("Запись удалена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }
        Random random= new Random();
        private void BtnSaveProduct_Click(object sender, RoutedEventArgs e)
        {
           
            StringBuilder errors = new StringBuilder();
            try
            {
                if (txtbArticle.Text.Trim().Length == 0)
                    errors.AppendLine("Поле с артиклем не должно быть пустым!");

                if (txtbTitle.Text.Trim().Length == 0)
                    errors.AppendLine("Поле с наименованием продукта не должно быть пустым!");

                if (txtvDescription.Text.Trim().Length == 0)
                    errors.AppendLine("Поле с описанием не должно быть пустым!");

                if (Convert.ToDecimal(txtbCost.Text.Trim()) < 0)
                    errors.AppendLine("Стоимость не может быть отрицательной!");

                if (Convert.ToInt32(txtbMinCount.Text.Trim()) < 0)
                    errors.AppendLine("Минимальное количество не может быть отрицательной!");

                if (Convert.ToByte(txtbProductDiscountAmount.Text.Trim()) < 0 && Convert.ToInt16(txtbProductDiscountAmount.Text.Trim()) > Convert.ToInt32(txtbCountInStock.Text.Trim()))
                    errors.AppendLine("Действующа скидка не может быть отрицательной!");

                if (Convert.ToByte(txtbMaxDiscount.Text.Trim()) < 0)
                    errors.AppendLine("Действующа скидка не может быть отрицательной!");

                if (Convert.ToInt32(txtbCountInStock.Text.Trim()) < 0 && txtbCountInStock.Text.Trim().Length == 0)
                    errors.AppendLine("Количество на складе не может быть отрицательным и не заполненным!");

                if (txtbUnit.Text.Trim().Length == 0)
                    errors.AppendLine("Поле с единицами измерения не должно быть пустым!");
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            product.ProductArticleNumber = txtbArticle.Text;
            product.ProductName = txtbTitle.Text;
            product.ProductDescription = txtvDescription.Text;

            int idCat = random.Next(1, 6);
            int idSupp = random.Next(1, 2);
            product.Category = Autoservice_RulEntities.GetContex().Category.Where(c => c.IdCategory == idCat).FirstOrDefault();
            product.Supplier1 = Autoservice_RulEntities.GetContex().Supplier.Where(s => s.IdSupplier == idSupp).FirstOrDefault();


            product.IdManufacturer = random.Next(8,22);
            product.ProductCost = Convert.ToDecimal(txtbCost.Text.Trim());
            product.ProductDiscountAmount = Convert.ToByte(txtbProductDiscountAmount.Text.Trim());
            product.MaxDiscountAmount = Convert.ToByte(txtbMaxDiscount.Text.Trim());
            product.ProductQuantityInStock = Convert.ToInt32(txtbCountInStock.Text.Trim());
            product.Unit = txtbUnit.Text;
            product.Deleted = false;



            switch (_whatCanDo)
            {
                case 1:
                    Autoservice_RulEntities.GetContex().Product.Add(product);
                    Autoservice_RulEntities.GetContex().SaveChanges();
                    MessageBox.Show("Запись успешно добавлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 2:
                    Autoservice_RulEntities.GetContex().Entry(product).State = System.Data.Entity.EntityState.Modified;
                    Autoservice_RulEntities.GetContex().SaveChanges();
                    MessageBox.Show("Запись успешно обновлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
        }
    }
}
