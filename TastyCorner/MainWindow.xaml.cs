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

namespace TastyCorner
{
   
        /// <summary>
        /// Interaction logic for LoginWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
        {
            public static bool user;

            public MainWindow()
            {
                InitializeComponent();
            }

          

            private void CheckBox_Click(object sender, RoutedEventArgs e)
            {
                if (chkShow.IsChecked.Value)
                {
                    txtPassword.Text = pswPassword.Password;
                    txtPassword.Visibility = Visibility.Visible;
                    pswPassword.Visibility = Visibility.Hidden;
                }
                else
                {
                    pswPassword.Password = txtPassword.Text;
                    pswPassword.Visibility = Visibility.Visible;
                    txtPassword.Visibility = Visibility.Hidden;
                }
            }

            private void btnExit_Click(object sender, RoutedEventArgs e)
            {
                Application.Current.Shutdown();
            }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
          
                Order order = new Order();
            order.Show();
            Close();

                if (txtLogin.Text == "" || pswPassword.Password == "")
                    MessageBox.Show("Не хватает данных");
                else
                {
                    if (txtLogin.Text == "admin" && pswPassword.Password == "admin")
                    {
                        user = true;
                        order.Show();
                        Close();
                    }
                    else
                    {
                        if (txtLogin.Text == "client" && pswPassword.Password == "client")
                        {
                            user = false;
                            order.Show();
                            Close();
                        }
                        else
                            MessageBox.Show("Проверьте логин или пароль");
                    }
                }
            }
        }
    }
    
