using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public class CalendarViewModel : INotifyPropertyChanged
    {
        private DateTime _selectedDate;
        private SelectedDatesCollection _dateCollection;
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                _selectedDate = value;
                var valueDate = _selectedDate;
                var isThursday = false;
                while (!isThursday)
                {
                    if (valueDate.DayOfWeek == DayOfWeek.Thursday)
                    {
                        isThursday = true;
                        break;
                    }
                    valueDate = valueDate.AddDays(-1);
                }
                Owner.calendar.SelectedDates.Add(valueDate);
                for (int i = 0; i < 6; ++i)
                {
                    valueDate = valueDate.AddDays(1);
                    Owner.calendar.SelectedDates.Add(valueDate);
                }
                //Owner.calendar.SelectedDates.Add(valueDate);

                OnPropertyChanged();
            }
        }

        public Calendar Owner { get; set; }

        public CalendarViewModel(Calendar owner) => Owner = owner;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
