using LawerGUI.Models;
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

namespace LawerGUI.UserControls
{
    /// <summary>
    /// Interaction logic for QuizList.xaml
    /// </summary>
    public partial class QuizList : UserControl
    {
        private string _headerPoint;
        public QuizList(QuizLists quizLists,double width)
        {
            InitializeComponent();
            //HeaderCol1.Width = width;
            //HeaderCol1.Content = quizLists.Header1;
            //HeaderCol3.Content = quizLists.Header2;

            HeaderPoint.Content = _headerPoint = quizLists.Header2;
            Header.Content = quizLists.Header1;

            QuizListView.ItemsSource = quizLists.QuizeList;

            
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if ((bool)checkBox.IsChecked)
            {
                var data = (checkBox.DataContext as Quizs);
                HeaderPoint.Content = "Score: " + data.Description;
                var bufferQuizs = QuizListView.ItemsSource as List<Quizs>;
                bufferQuizs[bufferQuizs.FindIndex(x => x.Quiz.Equals(data.Quiz))].Check = true;
                if ((string)NameBuffer.Content != "")
                    bufferQuizs[bufferQuizs.FindIndex(x => x.Quiz.Equals(NameBuffer.Content as string))].Check = false;
                NameBuffer.Content = data.Quiz;
                QuizListView.ItemsSource = null;
                QuizListView.ItemsSource = bufferQuizs;
            }
            else
            {
                HeaderPoint.Content = _headerPoint;
                NameBuffer.Content = "";
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
