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

        //public static readonly DependencyProperty GridWidth = DependencyProperty.Register(
        //    "GridWidth", typeof(double), typeof(Grid), new PropertyMetadata(default(double)));

        //public double GridWidthProperty
        //{
        //    get { return (double)GetValue(GridWidth); }
        //    set { SetValue(GridWidth, value); }
        //}

        public QuizList(QuizLists quizLists,double width)
        {
            InitializeComponent();
            QuizHeader.Columns[0].Header = quizLists.Header1;
            QuizHeader.Columns[2].Header = quizLists.Header2;
            var buffer = quizLists.QuizeList;
            QuizListView.ItemsSource = buffer;

            HeaderCol1.Width = width;
        }
    }
}
