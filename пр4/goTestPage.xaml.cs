using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для goTestPage.xaml
    /// </summary>
    public partial class goTestPage : Page
    {
        private Entities3 s = new Entities3();
        private List<Test> testQuestions; 
        private int q_index = 0;
        private int right_answer = 0;
        public goTestPage()
        {
            InitializeComponent();
            testQuestions = s.Test.ToList();
            Test();
        }

        private void Test()
        {
            if (q_index < testQuestions.Count)
            {
                var currentTest = testQuestions[q_index];

                name.Text = currentTest.Name_test;
                desc.Text = currentTest.Desc_test;
                f_an.Content = currentTest.FirstAnswer;
                s_an.Content = currentTest.SecondAnswer;
                t_an.Content = currentTest.ThirdAnswer;
            }
            else MessageBox.Show($"Тест завершен, вы ответили правильно на {right_answer} вопросов из {testQuestions.Count}");
        }


        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            var currentTest = testQuestions[q_index];

            string rignt_an= ""; 
            switch (currentTest.RightAnswerTable.RightAnswer)
            {
                case "Первый":
                    rignt_an = currentTest.FirstAnswer;
                    break;
                case "Второй":
                    rignt_an = currentTest.SecondAnswer;
                    break;
                case "Третий":
                    rignt_an = currentTest.ThirdAnswer;
                    break;
            }

            if (b.Content.ToString() == rignt_an)
            {
                right_answer++; 
            }
            q_index++;
            Test();
        }
    }
}