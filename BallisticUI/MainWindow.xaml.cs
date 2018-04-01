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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BallisticUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    class MainModel : ViewModelBase
    {
        private double _velocity;
        private double _gravity;

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
    }
}
