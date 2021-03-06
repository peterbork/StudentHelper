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

namespace StudentHelper {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        Controller _controller = new Controller();
        public MainWindow() {
            InitializeComponent();
            CurrentWeekNumber.Content = "Week " + _controller.GetWeekNumber();
        }

        private void NextWeek_Click(object sender, RoutedEventArgs e) {
            _controller.NextWeek();
        }

        private void PrevWeek_Click(object sender, RoutedEventArgs e) {
            _controller.PreviousWeek();
        }
    }
}
