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
using Microsoft.Win32;
using System.IO;
using basic_report.Models;
using LiveCharts;
using LiveCharts.Wpf;

namespace basic_report
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainModel mm;
        public MainWindow()
        {
            InitializeComponent();
            addItemsCb();
            mm = new MainModel();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Choose file";
            if (openFileDialog.ShowDialog(this) == true)
            {
                mm.addMunicipio(File.ReadAllLines(openFileDialog.FileName));
                showMunicipios();
                barChart();
            }
        }

        private void showMunicipios()
        {
            gpMunicipio.DataContext = mm.municipioList;
        }

        private void SelectionType(object sender, SelectionChangedEventArgs e)
        {
            if(!(mm.municipioList.Count == 0))
            {
                var typeSelected = cbFilter.SelectedItem.ToString();
                gpMunicipio.DataContext = mm.filterMunicipality(typeSelected + "");
            } else
            {
                MessageBox.Show("Data Base empty");
            }
        }

        private void addItemsCb()
        {
            cbFilter.Items.Add("Municipio");
            cbFilter.Items.Add("Isla");
            cbFilter.Items.Add("Área no municipalizada");
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public void barChart()
        {
            SeriesCollection = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Numero de municipios",
                    //Values = new ChartValues{mm.countM().ToArray()},
                }
            };
            Labels = mm.getDepartment().ToArray();
            Formatter = value => value.ToString("N");

            DataContext = this;
        }
    }
}
