using MiamiPalms.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiamiPalms.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для DeskPage.xaml
    /// </summary>
    public partial class DeskPage : Page
    {
    // Толщина маркера
        public DeskPage()
        {
            InitializeComponent();
            SetMarkerMode();
        }

        private void SetMarkerMode()
        {
            DrawCanvas.EditingMode = InkCanvasEditingMode.Ink;
            DrawCanvas.DefaultDrawingAttributes = new System.Windows.Ink.DrawingAttributes
            {
                Color = Colors.Red,
                Width = 4,
                Height = 4,
                FitToCurve = true
            };
        }

        private void SetEraserMode()
        {
            DrawCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
            DrawCanvas.EraserShape = new RectangleStylusShape(20, 20);
        }

        private void PencilIcon_Click(object sender, MouseButtonEventArgs e)
        {
            SetMarkerMode();
        }

        private void EraserIcon_Click(object sender, MouseButtonEventArgs e)
        {
            SetEraserMode();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.selectedFrame.Navigate(new MenuPage());
        }
    }
}
