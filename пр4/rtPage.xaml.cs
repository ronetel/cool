using System;
using System.Collections.Generic;
using System.Data;
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


namespace пр4
{
    /// <summary>
    /// Логика взаимодействия для rtPage.xaml
    /// </summary>
    public partial class rtPage : Page
    {
        private Entities3 m = new Entities3();
        public rtPage()
        {
            InitializeComponent();
            grid_emp.ItemsSource = m.Test.ToList();
            right_an.ItemsSource = m.RightAnswerTable.ToList();
            right_an.DisplayMemberPath = "RightAnswer";

        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (grid_emp.SelectedItem != null)
            {
                var select = grid_emp.SelectedItem as Test;
                select.Name_test = name_test.Text;
                select.Desc_test = deck_test.Text;
                select.FirstAnswer = first_an.Text;
                select.SecondAnswer = second_an.Text;
                select.ThirdAnswer = third_an.Text;
                select.RA_ID = (right_an.SelectedItem as RightAnswerTable).ID_RA;
                m.SaveChanges();
                grid_emp.ItemsSource = m.Test.ToList();
            }
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Test select = new Test();
            select.Name_test = name_test.Text;
            select.Desc_test = deck_test.Text;
            select.FirstAnswer = first_an.Text;
            select.SecondAnswer = second_an.Text;
            select.ThirdAnswer = third_an.Text;
            select.RA_ID = (right_an.SelectedItem as RightAnswerTable).ID_RA;
            m.Test.Add(select);
            m.SaveChanges();
            grid_emp.ItemsSource = m.Test.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (grid_emp.SelectedItem != null)
            {
                m.Test.Remove(grid_emp.SelectedItem as Test);
                m.SaveChanges();
                grid_emp.ItemsSource = m.Test.ToList();
            }
        }
        private void grid_emp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid_emp.SelectedItem != null)
            {
                var selected = grid_emp.SelectedItem as Test;
                name_test.Text = selected.Name_test;
                deck_test.Text = selected.Desc_test;
                first_an.Text = selected.FirstAnswer;
                second_an.Text = selected.SecondAnswer;
                third_an.Text = selected.ThirdAnswer;

                foreach (var item in m.RightAnswerTable.ToList())
                {
                    if ((int)(grid_emp.SelectedItem as Test).RA_ID == item.ID_RA)
                    {
                        right_an.SelectedIndex = m.RightAnswerTable.ToList().IndexOf(item);
                    }
                }
            }

        }
    }
}

