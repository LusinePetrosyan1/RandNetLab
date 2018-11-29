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

namespace RandNetLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (Start.Content.ToString() == "Start")
            {
                Start.Content = "Stop";
                ProgressStatus.Visibility = Visibility.Visible;
            }
            else
            {
                Start.Content = "Start";
                ProgressStatus.Visibility = Visibility.Hidden;
            }

            //to do

            ProgressStatus.Visibility = Visibility.Hidden;
            Initial.Visibility = Visibility.Visible;
            Final.Visibility = Visibility.Visible;
            Next.Visibility = Visibility.Visible;
            Previous.Visibility = Visibility.Visible;

            mainCanvas.Visibility = Visibility.Visible;
            Start.IsEnabled = false;
        }

        private void Basic_Click(object sender, RoutedEventArgs e)
        {
            ShowCreateResearchDialog("Basic");
        }

        private void Evolution_Click(object sender, RoutedEventArgs e)
        {
            ShowCreateResearchDialog("Evolution");
        }

        private void Collection_Click(object sender, RoutedEventArgs e)
        {
            ShowCreateResearchDialog("Collection");
        }

        private void Structural_Click(object sender, RoutedEventArgs e)
        {
            ShowCreateResearchDialog("Structural");
        }

        private void Activation_Click(object sender, RoutedEventArgs e)
        {
            ShowCreateResearchDialog("Activation");
        }

        private void Research_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
        #region functions
        private void ShowCreateResearchDialog(string researchType)
        {
            CreateResearch createResearch = new CreateResearch();
            createResearch.Owner = this;
            createResearch.ShowInTaskbar = false;
            createResearch.Show();

            Initial.Visibility = Visibility.Hidden;
            Final.Visibility = Visibility.Hidden;
            Next.Visibility = Visibility.Hidden;
            Previous.Visibility = Visibility.Hidden;
            Start.IsEnabled = true;
        }
        #endregion

       
    }

}