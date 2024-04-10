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
    /// Логика взаимодействия для RadactorTestWindow.xaml
    /// </summary>
    public partial class RadactorTestWindow : Window
    {
        Entities3 entities = new Entities3();
        public RadactorTestWindow()
        {
            InitializeComponent();
            PageFrame.Content = new rtPage();
        }
        private void est_li_test()
        {
            var testCount = entities.Test.ToList().Count;
            if (testCount > 0)
            {
                PageFrame.Content = new goTestPage();
            }
            else
            {
                PageFrame.Content = new NoTestPage();
            }
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        private void RTText_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new rtPage();
        }

        private void GoTest_Click(object sender, RoutedEventArgs e)
        {
            est_li_test();
        }
    }
}
