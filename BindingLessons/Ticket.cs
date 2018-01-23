using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingLessons
{
    public class Ticket: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int id;
        //и остальные поля по свойствам

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
                //тоже самое для остальных свойств
            }
        }
        //public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string TrainNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArriveDate { get; set; }
        public double Price { get; set; }

        private void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
            if (PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
