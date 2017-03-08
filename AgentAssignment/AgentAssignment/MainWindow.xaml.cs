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
using System.ComponentModel;

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

            ICollectionView view = CollectionViewSource.GetDefaultView(ListView1.ItemsSource);

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

        private void AddClick(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();

            if (addWindow.ShowDialog() != null && addWindow.newAgent != null)
            {
                Agent newAgent = addWindow.newAgent;
                aListe.Add(newAgent);
            }


        }

        private void ComboSortChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = e.AddedItems[0] as ComboBoxItem;
            string newSortOrder;
            if (cbi != null)
            {
                if (cbi.Tag == null)
                    newSortOrder = "None";
                else
                    newSortOrder = cbi.Tag.ToString();

                SortDescription sortDesc = new SortDescription(newSortOrder, ListSortDirection.Ascending);
                ICollectionView cv = CollectionViewSource.GetDefaultView(DataContext);
                if (cv != null)
                {
                    cv.SortDescriptions.Clear();
                    if (newSortOrder != "None")
                        cv.SortDescriptions.Add(sortDesc);
                }
            }
        }
    }
}

