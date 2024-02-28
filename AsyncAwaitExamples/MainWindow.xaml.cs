using System;
using System.Collections.Generic;
using System.IO;
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

namespace AsyncAwaitExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a = 0;

        async void MethodAsync()
        {
            await Task.Run(() =>
            {
                while (File.Exists(@"C:\Users\Vadim.Nacharov\Desktop\testdoc.txt"))
                {

                }
                MessageBox.Show("File deleted or changed");
            });
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbl1.Content = (a++).ToString();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MethodAsync();
        }
    }
}
