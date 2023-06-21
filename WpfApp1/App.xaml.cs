using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.File;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {   
       
        public static readonly ILogger Logger = new LoggerConfiguration()
            .WriteTo.File("log.txt")
            .CreateLogger();
             
      
    }
}
