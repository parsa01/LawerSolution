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

        public QuizList(QuizLists quizLists,double width)
        {
            InitializeComponent();
            //HeaderCol1.Width = width;
            //HeaderCol1.Content = quizLists.Header1;
            //HeaderCol3.Content = quizLists.Header2;

            HeaderPoint.Content = quizLists.Header2;
            Header.Content = quizLists.Header1;

            QuizListView.ItemsSource = quizLists.QuizeList;

            
        }
    }
}
