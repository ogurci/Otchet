﻿using System;
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
using System.Windows.Shapes;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для FileWindow.xaml
    /// </summary>
    public partial class FileWindow : Window
    {
        public string day;
        public FileWindow()
        {
            InitializeComponent();
            string filePath = "log.txt";
            
            
            string fileContent = File.ReadAllText(filePath);

                ast.Text = fileContent;
                ast.IsReadOnly = true;
            

        }
        
    }
}
