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

namespace пр4
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        Entities3 Entities3 = new Entities3();
        public TestWindow()
        {
            InitializeComponent();
            est_li_test();
        }
        private void est_li_test()
        {
            var testCount = Entities3.Test.ToList().Count;
            if (testCount > 0)
            {
                Frame.Content = new goTestPage();
            }
            else
            {
                Frame.Content = new NoTestPage();
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
