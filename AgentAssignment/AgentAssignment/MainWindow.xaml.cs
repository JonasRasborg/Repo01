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
using I4GUI;
using MvvmFoundation.Wpf;

namespace AgentAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Agents aListe = new Agents();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = aListe;
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BlueClick(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Colors.CornflowerBlue);
            this.Resources["myBrush"] = brush;
        }

        private void GreenClick(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Colors.LawnGreen);
            this.Resources["myBrush"] = brush;
        }

        private void StandardClick(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Colors.Aquamarine);
            this.Resources["myBrush"] = brush;
        }
    }
}

