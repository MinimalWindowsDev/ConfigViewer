using System;
using System.IO;
using System.Windows;
using System.Text.Json;

namespace ConfigViewer.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Models.Config _config;
        private string _name;
        private string _version;
        private string[] _items;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Version
        {
            get => _version;
            set => SetProperty(ref _version, value);
        }

        public string[] Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public MainWindowViewModel(string configPath)
        {
            LoadConfiguration(configPath);
        }

        private void LoadConfiguration(string path)
        {
            try
            {
                var jsonString = File.ReadAllText(path);
                _config = JsonSerializer.Deserialize<Models.Config>(jsonString);

                Name = _config.Name;
                Version = _config.Version;
                Items = _config.Items;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading configuration: {ex.Message}");
            }
        }
    }
}