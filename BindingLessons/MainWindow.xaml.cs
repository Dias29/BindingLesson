using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BindingLessons
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Ticket> tickets;
        public MainWindow()
        {
            InitializeComponent();
            tickets = new ObservableCollection<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    TrainNumber = "1A",
                    Price = 5000,
                    From = "Astana",
                    To = "Almaty",
                    DepartureDate = DateTime.Now,
                    ArriveDate = DateTime.Now.AddDays(2)
                },

                new Ticket
                {
                    Id = 2,
                    TrainNumber = "1B",
                    Price = 20000,
                    From = "Astana",
                    To = "Moscow",
                    DepartureDate = DateTime.Now,
                    ArriveDate = DateTime.Now.AddDays(7)
                }
            };

            dataConteiner.ItemsSource = tickets;
        }

        private void DataConteinerAddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            tickets[1].Id = 100; 
        }
    }
}
