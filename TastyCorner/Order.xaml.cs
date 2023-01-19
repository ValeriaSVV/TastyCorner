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
using System.Windows.Shapes;

namespace TastyCorner
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {

        MainWindow mainWindow = new MainWindow();

        public Order()
        {
            InitializeComponent();
            
        }


            private void Window_Loaded(object sender, RoutedEventArgs e)
            {

                if (MainWindow.user == true)
                {
                    btnOrder.Visibility = Visibility.Hidden;
                    chkMash.IsEnabled = false;
                    chkTiramisu.IsEnabled = false;
                    chkSoup.IsEnabled = false;
                    lblUser.Content = "Администратор";
                }
                else
                {
                    txtMash.IsEnabled = false;
                    txtTiramisu.IsEnabled = false;
                    txtSoup.IsEnabled = false;
                    lblUser.Content = "Клиент";
                }
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

   
    }
    }

