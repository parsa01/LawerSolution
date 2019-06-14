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
using LawerGUI.AppDialog;
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
                Quiz = "Doctorate/PhD",
                Description = "25"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Master’s degree",
                Description = "23",
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Entry to practice professional degree for year occupation of NOC for which licensing by a provincial regulatory body is required",
                Description = "23"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Two or more post-secondary program credentials (one credential of three years or longer)",
                Description = "22",
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Post-secondary credential of three years or more",
                Description = "21"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Two year post-secondary credential",
                Description = "19"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "One year post-secondary credential",
                Description = "15"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Secondary school credential",
                Description = "5"
            });

            QuizList list = new QuizList(quizLists,Column1.ActualWidth);
            QuizView.Children.Add(list);
            QuizList list1 = new QuizList(quizLists, Column1.ActualWidth);
            QuizView1.Children.Add(list1);

            quizLists = new QuizLists();
            quizLists.Header1 = "Experience";
            quizLists.Header2 = "Maximum 15";
            quizLists.QuizeList = new List<Quizs>();
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "1 year",
                Description = "9"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "2 & 3 years",
                Description = "11"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "4 & 5 years",
                Description = "13"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "6 years or more",
                Description = "15"
            });

            list = new QuizList(quizLists, Column1.ActualWidth);
            QuizView.Children.Add(list);
            list1 = new QuizList(quizLists, Column1.ActualWidth);
            QuizView1.Children.Add(list1);

            quizLists = new QuizLists();
            quizLists.Header1 = "Age";
            quizLists.Header2 = "Maximum 12";
            quizLists.QuizeList = new List<Quizs>();
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Less than 18 years",
                Description = "0"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "18-35",
                Description = "12"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "36",
                Description = "11"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "37",
                Description = "10"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "38",
                Description = "9"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "39",
                Description = "8"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "40",
                Description = "7"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "41",
                Description = "6"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "42",
                Description = "5"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "43",
                Description = "4"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "44",
                Description = "3"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "45",
                Description = "2"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "46",
                Description = "1"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "47 or more",
                Description = "0"
            });

            list = new QuizList(quizLists, Column1.ActualWidth);
            QuizView.Children.Add(list);
            list1 = new QuizList(quizLists, Column1.ActualWidth);
            QuizView1.Children.Add(list1);

            quizLists = new QuizLists();
            quizLists.Header1 = "Arranged employment ";
            quizLists.Header2 = "Maximum 10";
            quizLists.QuizeList = new List<Quizs>();
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Current work with valid work permit and at the time of permanent residence, folling LMIA",
                Description = "10"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Current work with valid work permit and at time permanent residence, exempted from LMIA due to international or provincial - federal agreement",
                Description = "10"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Current work, permanent job offer in Canada with other employer and favorable LMIA",
                Description = "10"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Current work, exempted from LIMIA by other cause than agreement and offer by other employer  with favorable LIMIA",
                Description = "10"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "No work, permit and no intention to work in Canada until permanet residence and offer by employer with favorable LIMIA ",
                Description = "10"
            });

            list = new QuizList(quizLists, Column1.ActualWidth);
            QuizView.Children.Add(list);
            list1 = new QuizList(quizLists, Column1.ActualWidth);
            QuizView1.Children.Add(list1);

            quizLists = new QuizLists();
            quizLists.Header1 = "Adaptability";
            quizLists.Header2 = "Maximum 10";
            quizLists.QuizeList = new List<Quizs>();
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Language skills spouse",
                Description = "5"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Previous studies in Canada",
                Description = "5"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Previous studies in Canada by spouse",
                Description = "5"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Previous work in Canada",
                Description = "10"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Previous work in Canada by spouse",
                Description = "5"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Reserved job offer in Canada",
                Description = "5"
            });
            quizLists.QuizeList.Add(new Quizs()
            {
                Quiz = "Relatives in Cyearada",
                Description = "5"
            });

            list = new QuizList(quizLists, Column1.ActualWidth);
            QuizView.Children.Add(list);
            list1 = new QuizList(quizLists, Column1.ActualWidth);
            QuizView1.Children.Add(list1);
        }

        private void Score_Click(object sender, RoutedEventArgs e)
        {
            int score = 0;
            foreach(QuizList child in QuizView.Children)
            {
                if ((child.HeaderPoint.Content as string).Contains("Score:"))
                    score += int.Parse((child.HeaderPoint.Content as string).Replace("Score:", ""));
            }
            AlartDialog alartDialog = new AlartDialog(Username.Text,score);
            alartDialog.Owner = this;
            alartDialog.ShowDialog();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Panel.SetZIndex(OverView, 0);
        }
    }
}
