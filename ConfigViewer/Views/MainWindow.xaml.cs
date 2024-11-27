using System;
using System.Windows;
using System.Text.Json;

namespace ConfigViewer.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow(string configPath)
        {
            InitializeComponent();
            DataContext = new ViewModels.MainWindowViewModel(configPath);
        }
    }
}