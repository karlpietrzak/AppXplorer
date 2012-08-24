﻿using System.Windows;
using AppXplorer.ViewModel;

namespace AppXplorer.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainViewModel();
            InitializeComponent();
        }

    }
}
