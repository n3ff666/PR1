using Desktop.Utilities;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Получение данных из текстовых полей
            string username = usernameTextBox.Text; // Имя пользователя
            string email = emailTextBox.Text; // Email
            string password = passwordTextBox.Text; // Пароль
            string confirmPassword = confirmPasswordTextBox.Text; // Подтверждение пароля

            // Валидация данных
            if (!username.ValidateUsername())
            {
                MessageBox.Show("Имя пользователя должно быть не менее 3 символов.");
                return;
            }

            if (!email.ValidateEmail())
            {
                MessageBox.Show("Введите корректную почту.");
                return;
            }

            if (!password.ValidatePassword())
            {
                MessageBox.Show("Пароль должен быть не менее 6 символов.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            // Если все данные корректны, выводим сообщение об успешной регистрации и открываем новое окно
            MessageBox.Show("Вы успешно зарегистрированы!");

            Main_empty main_Empty = new Main_empty();
            main_Empty.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика для кнопки "Назад"
            MessageBox.Show("Вернуться назад");
        }
    }
}
