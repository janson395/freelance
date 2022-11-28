﻿using freelance.Core;
using freelance.Model;
using freelance.View.Pages.AdministratorPage;
using freelance.View.Pages.EmployerPage;
using freelance.View.Pages.UserPage;
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

namespace freelance.View.Pages.LoginPage
{
    /// <summary>
    /// Логика взаимодействия для MainWindowLoginPage.xaml
    /// </summary>
    public partial class MainWindowLoginPage : UserControl
    {
        public MainWindowLoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User userModel = FrameNavigate.DB.Users.FirstOrDefault(u =>
                u.UserMail == TbLogin.Text && u.UserPhone == TsbPassword.Text);

                if(userModel == null)
                {
                    MessageBox.Show("Ошибка данных", 
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    switch (userModel.RoleID)
                    {
                        case 1:
                            FrameNavigate.FrameObject.Navigate(new MainAdministratorPage());
                            break;
                        case 2:
                            FrameNavigate.FrameObject.Navigate(new MainUserPage());
                            break;
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системная ошибка",
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error); ;
            }
        }

        private void BtnWork_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainEmployerPage());
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowRegistrationPage());
        }
    }
}
