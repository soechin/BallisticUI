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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BallisticUI
{
    /// <summary>
    /// Interaction logic for OverlayWindow.xaml
    /// </summary>
    public partial class OverlayWindow : Window
    {
        public OverlayWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // make window click-through
            Window_ClickThrough();
        }

        private void Window_ClickThrough()
        {
            IntPtr hwnd;
            int index;
            long style;

            hwnd = new WindowInteropHelper(this).Handle;
            index = -20/*GWL_EXSTYLE*/;
            style = 0x00000020/*WS_EX_TRANSPARENT*/;

            if (IntPtr.Size == 4) // x86
            {
                style |= (uint)User32.GetWindowLong(hwnd, index);
                User32.SetWindowLong(hwnd, index, (int)style);
            }
            else if (IntPtr.Size == 8) // x64
            {
                style |= User32.GetWindowLongPtr(hwnd, index);
                User32.SetWindowLongPtr(hwnd, index, style);
            }
        }
    }
}
