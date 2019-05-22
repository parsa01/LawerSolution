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
using LawerGUI.Models;
using LawerGUI.UserControls;
using MahApps.Metro.Controls;

namespace LawerGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            QuizLists quizLists = new QuizLists();
            quizLists.Header1 = "Education point";
            quizLists.Header2 = "Maximum 25";
            quizLists.QuizeList = new List<Quizs>();
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "salam chetori",
                Description = "khobam"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "salam chetori1111",
                Description = "khobam"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "salam chetori2222",
                Description = "khobam"
            });

            QuizList list = new QuizList(quizLists,Column1.ActualWidth);
            QuizView.Children.Add(list);
        }
    }
}
