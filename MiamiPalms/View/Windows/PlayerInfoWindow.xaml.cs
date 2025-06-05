using MiamiPalms.Model;
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
using System.Windows.Shapes;

namespace MiamiPalms.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для PlayerInfoWindow.xaml
    /// </summary>
    public partial class PlayerInfoWindow : Window
    {
        public PlayerInfoWindow(Player selectedPlayer)
        {
            InitializeComponent();
            PlayerGrid.DataContext = selectedPlayer;
            StatGrid.DataContext = selectedPlayer.Statistics;

        }
    }
}
