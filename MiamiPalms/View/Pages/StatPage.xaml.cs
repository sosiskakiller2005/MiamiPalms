using System.Linq;
using System.Windows.Controls;
using MiamiPalms.Model;
using System.Collections.Generic;

namespace MiamiPalms.View.Pages
{
    public partial class StatPage : Page
    {
        private List<Position> positions;
        private List<Player> allPlayers;
        private static MiamiPalmsDbEntities _context = App.GetContext();

        public StatPage()
        {
            InitializeComponent();
            LoadPositions();
            LoadPlayers();
        }

        private void LoadPositions()
        {
            positions = _context.Position.ToList();
            positions.Insert(0, new Position { Id = 0, Name = "Все позиции" });
            PositionComboBox.ItemsSource = positions;
            PositionComboBox.SelectedIndex = 0;
        }

        private void LoadPlayers()
        {
            // Используем Include для загрузки связанных сущностей
            allPlayers = _context.Player
                .Include("Position")
                .Include("Statistics")
                .ToList();
            UpdateGrid(allPlayers);
        }


        private void UpdateGrid(IEnumerable<Player> players)
        {
            if (players == null)
            {
                PlayersDataGrid.ItemsSource = null;
                return;
            }

            var data = players.Select(p => new
            {
                p.Number,
                p.Lastname,
                p.Name,
                p.Surname,
                Position = p.Position?.Name,
                PointsPG = p.Statistics.FirstOrDefault()?.PointsPG ?? 0,
                AssistsPG = p.Statistics.FirstOrDefault()?.AssistsPG ?? 0,
                ReboundsPG = p.Statistics.FirstOrDefault()?.ReboundsPG ?? 0
            }).ToList();

            PlayersDataGrid.ItemsSource = data;
        }


        private void PositionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedPosition = PositionComboBox.SelectedItem as Position;
            if (selectedPosition == null || selectedPosition.Id == 0)
            {
                UpdateGrid(allPlayers);
            }
            else
            {
                UpdateGrid(allPlayers.Where(p => p.PositionId == selectedPosition.Id));
            }
        }

        private void BackBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Ваша логика возврата
        }
    }
}
