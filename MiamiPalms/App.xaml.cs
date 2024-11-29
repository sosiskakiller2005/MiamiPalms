using MiamiPalms.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MiamiPalms
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static MiamiPalmsDbEntities _context;
        public static MiamiPalmsDbEntities GetContext()
        {
            if (_context == null)
            {
                _context = new MiamiPalmsDbEntities();
            }
            return _context;
        }
    }
}
