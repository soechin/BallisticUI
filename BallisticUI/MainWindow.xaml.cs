using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BallisticUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainModel _model;
        private OverlayWindow _overlay;

        public MainModel Model
        {
            get
            {
                if (_model == null)
                {
                    _model = DataContext as MainModel;
                }

                return _model;
            }
        }

        public OverlayWindow Overlay
        {
            get
            {
                if (_overlay == null)
                {
                    _overlay = new OverlayWindow();
                }

                return _overlay;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Overlay.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Overlay.Close();
        }
    }

    public class MainModel : ViewModelBase
    {
        #region Weapon
        private double _velocity;
        private double _gravity;
        private double _zeroDist;

        public double Velocity
        {
            get => _velocity;
            set => Set(ref _velocity, value);
        }

        public double Gravity
        {
            get => _gravity;
            set => Set(ref _gravity, value);
        }

        public double ZeroDist
        {
            get => _zeroDist;
            set => Set(ref _zeroDist, value);
        }
        #endregion

        #region Sight
        private double _zoomLevel;

        public double ZoomLevel
        {
            get => _zoomLevel;
            set => Set(ref _zoomLevel, value);
        }
        #endregion

        #region Graphics
        private double _screenWidth;
        private double _screenHeight;
        private double _horzFOV;
        private double _vertFOV;

        public double ScreenWidth
        {
            get => _screenWidth;
            set => Set(ref _screenWidth, value);
        }

        public double ScreenHeight
        {
            get => _screenHeight;
            set => Set(ref _screenHeight, value);
        }

        public double HorzFOV
        {
            get => _horzFOV;
            set => Set(ref _horzFOV, value);
        }

        public double VertFOV
        {
            get => _vertFOV;
            set => Set(ref _vertFOV, value);
        }
        #endregion

        private ObservableCollection<Point> _arrow;

        public ObservableCollection<Point> Arrow
        {
            get => _arrow;
            set => Set(ref _arrow, value);
        }
    }
}
