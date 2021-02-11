using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using UniversityStudents.DatabaseEntities;

namespace UniversityStudents
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool error = false;
            if (Login.Text.Length == 0)
            {
                Login.Background = new SolidColorBrush
                    (Color.FromRgb(247, 91, 96));
                error = true;
            }

            if (Password.Password.Length == 0)
            {
                Password.Background = new SolidColorBrush
                    (Color.FromRgb(247, 91, 96));
                error = true;
            }

            if (!error)
            {
                AppDBContext context = new AppDBContext();
                foreach (User user in context.Users)
                {
                    if (user.Login == Login.Text &&
                        user.Password == Password.Password)
                    {
                        Settings.CurrentUser = user;
                        if (user.Role.Name == "Секретарь")
                        {
                            MessageBox.Show("Здравствуйте, секретарь");
                        } 
                        else
                        {
                            MessageBox.Show("Здравствуйте, студент");
                        }
                    }
                }
                if (Settings.CurrentUser == null)
                {
                    MessageBox.Show("Неверный логин или пароль", "Вы не вошли");
                }
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            Login.Background = new SolidColorBrush
                (Color.FromRgb(255, 255, 255));
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            Password.Background = new SolidColorBrush
                (Color.FromRgb(255, 255, 255));
        }

        private void Login_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Password_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}
