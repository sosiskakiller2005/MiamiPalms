using MiamiPalms.Model;
using MiamiPalms.View.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiamiPalms.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PlayersPage.xaml
    /// </summary>
    public partial class PlayersPage : Page
    {
        private static MiamiPalmsDbEntities _context = App.GetContext();
        public PlayersPage()
        {
            InitializeComponent();
            PlayersLb.ItemsSource = _context.Player.ToList();
        }

        private void PlayersLb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PlayerInfoWindow playerInfoWindow = new PlayerInfoWindow(PlayersLb.SelectedItem as Player);
            playerInfoWindow.ShowDialog();
        }
    }
}
