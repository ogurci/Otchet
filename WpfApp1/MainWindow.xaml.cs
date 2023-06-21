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
using System.Windows.Navigation;                             
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using Serilog;
using WpfApp1.module;
using AutoUpdaterDotNET;
using Serilog.Events;
using Serilog.Sinks.File;


namespace WpfApp1
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
       
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();
        }
        // вывод логов
        public string day;
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FileWindow window = new FileWindow();
            window.Show();
        }


        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }

       
    }
}
