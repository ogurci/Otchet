using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Calendar.xaml
    /// </summary>
    public partial class Calendar : Window
    {
        public Calendar()
        {
            InitializeComponent();
            DataContext = new CalendarViewModel(this);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        // выбор недели и проверка на выбранную неделю 
        public void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            var selectedBeginWeek = calendar.SelectedDate;
            var selectedEndWeek = calendar.SelectedDate;
            var selectedDay2 = calendar.SelectedDate;
            var selectedDay3 = calendar.SelectedDate;
            var selectedDay4 = calendar.SelectedDate;
            var selectedDay5 = calendar.SelectedDate;
            var selectedDay6 = calendar.SelectedDate;
            var isThursday = false;


            bool flag = false;
            while (!isThursday)
            {

                try
                {
                    if (selectedBeginWeek.Value.DayOfWeek == DayOfWeek.Thursday)
                    {
                        isThursday = true;
                        break;
                    }
                    selectedBeginWeek = selectedBeginWeek.Value.AddDays(-1);
                }
                catch 
                {
                    MessageBox.Show("Выберите неделю");
                    flag = true;
                    break;
                }
            }

            if (flag == false)
            {
                selectedEndWeek = selectedBeginWeek.Value.AddDays(6);
                selectedDay2 = selectedBeginWeek.Value.AddDays(1);
                selectedDay3 = selectedBeginWeek.Value.AddDays(2);
                selectedDay4 = selectedBeginWeek.Value.AddDays(3);
                selectedDay5 = selectedBeginWeek.Value.AddDays(4);
                selectedDay6 = selectedBeginWeek.Value.AddDays(5);
                string day1 = selectedBeginWeek.Value.Date.ToShortDateString();
                string day2 = selectedDay2.Value.Date.ToShortDateString();
                string day3 = selectedDay3.Value.Date.ToShortDateString();
                string day4 = selectedDay4.Value.Date.ToShortDateString();
                string day5 = selectedDay5.Value.Date.ToShortDateString();
                string day6 = selectedDay6.Value.Date.ToShortDateString();
                string day7 = selectedEndWeek.Value.Date.ToShortDateString();

                ChoiceDay choiceDay = new ChoiceDay(day1, day2, day3, day4, day5, day6, day7);
                choiceDay.Show();
                this.Close();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FileWindow fileWindow = new FileWindow();
            fileWindow.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }
    }
}
