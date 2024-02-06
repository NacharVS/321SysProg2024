using Strategy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace Strategy.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        User contextUser;
        public RegistrationPage(User user)
        {
            InitializeComponent();
            contextUser = user;
            DataContext = contextUser;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.MainWindowInstance.BBack.Visibility = Visibility.Visible;
        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {
            var error = string.Empty;
            var validationContext = new ValidationContext(contextUser);
            var users = DBConnection.Get<User>("Strategy", "UsersCollection");
            var userExist = users.FirstOrDefault(x => x.Login == contextUser.Login);
            if (userExist != null)
                error += "Такой логин уже существует\n";
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            if(!Validator.TryValidateObject(contextUser, validationContext, results, true))
            {
                foreach(var result in results)
                {
                    error += $"{result}\n";
                }
            }
            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show(error);
                return;
            }
            DBConnection.Post<User>("Strategy", "UsersCollection", contextUser);
            NavigationService.GoBack();
        }
    }
}
