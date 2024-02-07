using MongoDB.Bson;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
    /// Логика взаимодействия для ViewUnitPage.xaml
    /// </summary>
    public partial class ViewUnitPage : Page
    {
        User contextUser { get; set; }
        string selectedUnit;
        public ViewUnitPage(User user)
        {
            InitializeComponent();
            contextUser = user;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.MainWindowInstance.BBack.Visibility = Visibility.Visible;
        }


        private void CBUnit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedUnit = ((TextBlock)CBUnit.SelectedItem).Text;
            if (selectedUnit == "Warrior")
            {
                Unit warrior = new Warrior(30, 250, 15, 80, 10, 50, 25, 100);
                contextUser.Unit = warrior;
            }
            else if (selectedUnit == "Rogue")
            {
                Unit rogue = new Rogue(20, 65, 30, 250, 15, 70, 20, 80);
                contextUser.Unit = rogue;

            }
            else if (selectedUnit == "Wizard")
            {
                Unit wizard = new Wizard(15, 45, 20, 80, 35, 250, 15, 70);
                contextUser.Unit = wizard;
            }
            DBConnection.Put("Strategy", "UsersCollection", contextUser._id, contextUser);
            DataContext = contextUser.Unit;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var contextUnit = DataContext as Unit;
            try
            {
                if (int.Parse(TBStrength.Text) > contextUser.Unit.MaxStrength && !string.IsNullOrWhiteSpace(TBStrength.Text))
                {
                    TBStrength.Text = contextUser.Unit.MaxStrength.ToString();
                }
                if (int.Parse(TBInteligence.Text) > contextUser.Unit.MaxInteligence && !string.IsNullOrWhiteSpace(TBInteligence.Text))
                {
                    TBInteligence.Text = contextUser.Unit.MaxInteligence.ToString();
                }
                if (int.Parse(TBDexterity.Text) > contextUser.Unit.MaxDexterity && !string.IsNullOrWhiteSpace(TBDexterity.Text))
                {
                    TBDexterity.Text = contextUser.Unit.MaxDexterity.ToString();
                }
                if (int.Parse(TBVitality.Text) > contextUser.Unit.MaxVitality && !string.IsNullOrWhiteSpace(TBVitality.Text))
                {
                    TBVitality.Text = contextUser.Unit.MaxVitality.ToString();
                }
            }
            catch
            {

            }
            if (selectedUnit == "Warrior")
            {
                Unit warrior = new Warrior(contextUnit.CurrentStrength, contextUnit.MaxStrength, contextUnit.CurrentDexterity, contextUnit.MaxDexterity, contextUnit.CurrentInteligence, contextUnit.MaxInteligence, contextUnit.CurrentVitality, contextUnit.MaxVitality);
                contextUser.Unit = warrior;
            }
            else if (selectedUnit == "Rogue")
            {
                Unit rogue = new Rogue(contextUnit.CurrentStrength, contextUnit.MaxStrength, contextUnit.CurrentDexterity, contextUnit.MaxDexterity, contextUnit.CurrentInteligence, contextUnit.MaxInteligence, contextUnit.CurrentVitality, contextUnit.MaxVitality);
                contextUser.Unit = rogue;

            }
            else if (selectedUnit == "Wizard")
            {
                Unit wizard = new Wizard(contextUnit.CurrentStrength, contextUnit.MaxStrength, contextUnit.CurrentDexterity, contextUnit.MaxDexterity, contextUnit.CurrentInteligence, contextUnit.MaxInteligence, contextUnit.CurrentVitality, contextUnit.MaxVitality);
                contextUser.Unit = wizard;
            }
            DBConnection.Put("Strategy", "UsersCollection", contextUser._id, contextUser);
            DataContext = contextUser.Unit;
        }

        private void TBStrength_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
