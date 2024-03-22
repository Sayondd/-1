using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Недвижимость
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static readonly bd.Krasnoperov_YP_day1Entities entities = new bd.Krasnoperov_YP_day1Entities();
    }
}
