using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Task1SqlServer.Model;
using Task1SqlServer.View;
using Task1SqlServer.Core;

namespace Task1SqlServer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 1;

        public MainWindow()
        {
            InitializeComponent();
            DbModelContext.DB = new Task1Entities();
        }

        private void TbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Run_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new InfoWindow().Show();
            Close();
        }

        private void BtnCreate_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                DbModelContext.DB.User.Add(new User()
                {
                    UserID = i++,
                    UserName = TbLogin.Text,
                    UserLastName = PbPassword.Text,
                    UserPhone = TbPhone.Text,
                    UserAdress = TbEmail.Text,
                });
                DbModelContext.DB.SaveChanges();
                MessageBox.Show("Данные успешно сохранены",
                               "Системное сообщение",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                               "Системное сообщение",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
            }
        }
    }
}

