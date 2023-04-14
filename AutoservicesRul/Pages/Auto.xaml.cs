using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AutoservicesRul.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Page
    {
        private int _countUnsuccessful = 0;
        private Entityes.User user = null;
        public Auto()
        {
            InitializeComponent();
        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client(null)); //Переход на страницу неавторизованного пользователя
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = txtbLogin.Text;
            string passw = pswbPassword.Password;
            var dbConn = Entityes.Autoservice_RulEntities.GetContex();
            if (login.Length > 0 && passw.Length > 0)
            {
                user = dbConn.User.Where(x => x.UserLogin == login && x.UserPassword == passw).FirstOrDefault(); //поиск пользователя в БД по введенному логину и паролю
                if (_countUnsuccessful < 1)
                {
                    if (user != null)
                    {
                        clearForm();
                        LoadPage(user);
                    }
                    else
                    {
                        _countUnsuccessful++;
                        MessageBox.Show("Неверно введены логин или пароль!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                        if (_countUnsuccessful == 1)
                        {
                            txtBlockCaptcha.Visibility = Visibility.Visible;
                            txtboxCaptcha.Visibility = Visibility.Visible;
                            txtBlockCaptcha.Text = Model.Captcha.GeneratedCaptcha();
                            txtBlockCaptcha.TextDecorations = TextDecorations.Strikethrough;

                        }

                    }
                }
                else
                {
                    if (user != null && user.UserLogin == txtbLogin.Text && user.UserPassword == passw && txtboxCaptcha.Text == txtBlockCaptcha.Text)
                    {
                        clearForm();
                        LoadPage(user);
                        
                    }
                    else
                    {
                        MessageBox.Show("Введите данные заного через 10 секунд!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtBlockCaptcha.Text = "";
                        txtboxCaptcha.Clear();
                        txtBlockCaptcha.Visibility = Visibility.Hidden;
                        txtboxCaptcha.Visibility = Visibility.Hidden;
                        txtbLogin.Clear();
                        txtbLogin.IsEnabled = false;
                        pswbPassword.Clear();
                        pswbPassword.IsEnabled = false;
                        btnEnter.IsEnabled = false;
                        txtBlockTimer.Visibility= Visibility.Visible;
                        CountDown(10, TimeSpan.FromSeconds(1), cur => txtBlockTimer.Text = cur.ToString()+" сек.");
                   
                    }

                }
            }
            else
            {
                MessageBox.Show("Не заполнены поля Логин и Пароль!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadPage(Entityes.User findUser)
        {
            switch (findUser.Role.RoleName)
            {
                case "Клиент":
                    NavigationService.Navigate(new Client(findUser)); //Переход на страницу неавторизованного пользователя
                    break;
                case "Менеджер":
                    NavigationService.Navigate(new Client(findUser)); //Переход на страницу неавторизованного пользователя
                    break;
                case "Администратор":
                    NavigationService.Navigate(new Admin(findUser)); //Переход на страницу неавторизованного пользователя
                    break;
            }

        }
        private void enableForm()
        {
            txtbLogin.IsEnabled = true;
            pswbPassword.IsEnabled = true;
            btnEnter.IsEnabled = true;
            txtBlockTimer.Visibility = Visibility.Hidden;
        }
        private void clearForm()
        {
            pswbPassword.Clear();
            txtbLogin.Clear();
            txtboxCaptcha.Clear();
            txtBlockCaptcha.Visibility = Visibility.Hidden;
            txtboxCaptcha.Visibility = Visibility.Hidden;
            txtBlockTimer.Visibility = Visibility.Hidden;
        }
        void CountDown(int count, TimeSpan interval, Action<int> ts)
        {
            var dt = new DispatcherTimer();
            dt.Interval= interval;
            dt.Tick += (_, a) =>
            {
                if (count-- == 0)
                {
                    enableForm();
                    dt.Stop();
                }   
                else
                    ts(count);
            };
            ts(count);
            dt.Start();
        }
    }
}
