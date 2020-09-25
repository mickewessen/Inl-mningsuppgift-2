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
using WpfApplication.Models;
using WpfApplication.Views;

namespace WpfApplication
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

        private void messageViewButtton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MessageViewModel();
        }

        private void contactViewButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void calenderViewButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tasksViewButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void settingsViewButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
