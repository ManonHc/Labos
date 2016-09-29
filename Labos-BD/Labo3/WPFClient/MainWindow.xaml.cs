
using labo3;
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

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CompanyContext _context = new CompanyContext();
        private Customer _customer;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Formulaire.DataContext = _customer;
            _context.Database.Initialize(true);
            _customer = new Customer()
            {
                Name = "Manon Libert",
                AddressLine1 = "Rue de forêt 47",
                City = "Namur",
                EMail = "manon@wallontours.be",
                Id = 2,
                Remark = "Apporter des fleurs",
                PostCode = "5000"
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
