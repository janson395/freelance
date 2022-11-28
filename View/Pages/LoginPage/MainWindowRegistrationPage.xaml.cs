using freelance.Core;
using freelance.Model;
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
    /// Логика взаимодействия для MainWindowRegistrationPage.xaml
    /// </summary>
    public partial class MainWindowRegistrationPage : UserControl
    {
        public MainWindowRegistrationPage()
        {
            InitializeComponent();
        }

        private async void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TbFullName.Text) ||
                string.IsNullOrEmpty(TbPhone.Text)   || 
                string.IsNullOrEmpty(TbEmail.Text)   ||
                string.IsNullOrEmpty(TbSkills.Text))
            {
                MessageBox.Show("Все полня должны быть заполнены!",
                    "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            else
            {
                if(FrameNavigate.DB.Users.Count(u => u.FIO == TbFullName.Text) > 0)
                {
                    MessageBox.Show("Пользователь с такими инифиалами уже зарегистрирован!",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    FrameNavigate.DB.Users.Add(new User
                    {
                        FIO = TbFullName.Text,
                        UserPhone = TbPhone.Text,
                        UserMail = TbEmail.Text,
                        UserSkills = TbSkills.Text,
                        RoleID = 2
                    });
                    await FrameNavigate.DB.SaveChangesAsync();
                    MessageBox.Show("Учетная запись создана!",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }
    }
}
