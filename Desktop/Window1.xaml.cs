using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public static class InputValidator
        {
            // Регулярное выражение для проверки email
            private static readonly string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            public static bool ValidateEmail(string email)
            {
                return Regex.IsMatch(email, emailPattern);
            }

            public static bool ValidatePassword(string password)
            {
                // Пароль должен быть не менее 6 символов
                return password.Length >= 6;
            }

            public static bool ValidateUsername(string username)
            {
                // Имя должно быть не менее 3 символов
                return username.Length >= 3;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Main_empty main_Empty = new Main_empty();

            main_Empty.Show();

            this.Close();

            string username = usernameTextBox.Text; // Имя пользователя
            string email = emailTextBox.Text; // Email
            string password = passwordTextBox.Text; // Пароль
            string confirmPassword = confirmPasswordTextBox.Text; // Подтверждение пароля

            // Валидация данных
            if (!InputValidator.ValidateUsername(username))
            {
                MessageBox.Show("Имя пользователя должно быть не менее 3 символов.");
                return;
            }

            if (!InputValidator.ValidateEmail(email))
            {
                MessageBox.Show("Введите корректную почту.");
                return;
            }

            if (!InputValidator.ValidatePassword(password))
            {
                MessageBox.Show("Пароль должен быть не менее 6 символов.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            // Данные корректны
            MessageBox.Show("Регистрация успешна!");
        }

       
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика для кнопки "Назад"
            MessageBox.Show("Вернуться назад");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
