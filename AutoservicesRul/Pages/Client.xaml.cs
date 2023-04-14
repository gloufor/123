﻿using AutoservicesRul.Entityes;
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
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Page
    {
        private Entityes.User _user;
        public Client(Entityes.User user)
        {
            InitializeComponent();
            DataContext = this;
            txtBlockFullNameUser.Visibility= Visibility.Hidden;
            if (user != null)
            {
                txtBlockFullNameUser.Visibility = Visibility.Visible;
                _user = user;
                txtBlockFullNameUser.Text = _user.UserSurname + " " + _user.UserName + " " + _user.UserPatronymic;
            }
            else
                txtBlockFullNameUser.Text = "Гость";


            var dbCon = Entityes.Autoservice_RulEntities.GetContex();
            var listProduct = dbCon.Product.Where(p => p.Deleted != true).ToList();
            LViewProduct.ItemsSource = listProduct;
            txtBlockResultAmountMax.Text = listProduct.Count.ToString();
            txtBlockResultAmount.Text = listProduct.Count.ToString();
        }

        public string[] SortingList { get; set; } =
        {
            "Без сортировки",
            "Стоимость по возрастанию",
            "Стоимость по убыванию"
        };

        public string[] FilterList { get; set; } =
        {
            "Все диапазоны",
            "0%-9,99%",
            "10%-14,99%",
            "15% и более"
        };

        private void UpdateData()
        {
            var resultListProduct = Autoservice_RulEntities.GetContex().Product.Where(p => p.Deleted != true).ToList();
            if (cmbBoxSorting.SelectedIndex == 1)
                resultListProduct = resultListProduct.OrderBy(p => p.ProductCost).ToList();
            if (cmbBoxSorting.SelectedIndex == 2)
                resultListProduct = resultListProduct.OrderByDescending(p => p.ProductCost).ToList();

            if (cmbBoxFilter.SelectedIndex == 1)
                resultListProduct = resultListProduct.Where(p => p.ProductDiscountAmount >= 0 && p.ProductDiscountAmount < 10).ToList();
            if (cmbBoxFilter.SelectedIndex == 2)
                resultListProduct = resultListProduct.Where(p => p.ProductDiscountAmount >= 10 && p.ProductDiscountAmount < 15).ToList();
            if (cmbBoxFilter.SelectedIndex == 3)
                resultListProduct = resultListProduct.Where(p => p.ProductDiscountAmount >= 15).ToList();

            resultListProduct = resultListProduct.Where(p => p.ProductName.ToLower().Contains(txtBoxSearch.Text.ToLower())).ToList();
            LViewProduct.ItemsSource = resultListProduct; // передаем результат поиска в ListView

            txtBlockResultAmount.Text = resultListProduct.Count.ToString();
        }

        private void txtBoxSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
           UpdateData(); //Вызов метода поиска
        }

        private void cmbBoxSorting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           UpdateData(); //Вызов метода поиска
        }

        private void cmbBoxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData(); //Вызов метода поиска
        }

        List<Product> orderProducts = new List<Product>();

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            orderProducts.Add(LViewProduct.SelectedItem as Product);
            if ( orderProducts.Count > 0)
            {
                btnOrder.Visibility= Visibility.Visible;
            }
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            Windows.OrderWindow orderWindow = new Windows.OrderWindow(orderProducts, _user);
            orderWindow.ShowDialog();
        }
    }
}
