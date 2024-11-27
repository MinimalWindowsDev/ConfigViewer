using System;
using System.Windows.Input;
using Microsoft.Win32;

namespace ConfigViewer.ViewModels
{
    public class ConfigSelectionViewModel : ViewModelBase
    {
        private string _selectedConfigPath;
        public string SelectedConfigPath
        {
            get => _selectedConfigPath;
            private set => SetProperty(ref _selectedConfigPath, value);
        }

        public ICommand BrowseCommand { get; }
        public ICommand ConfirmCommand { get; }

        public ConfigSelectionViewModel()
        {
            BrowseCommand = new RelayCommand(BrowseForConfig);
            ConfirmCommand = new RelayCommand(
                execute: () => { /* Confirmation happens in the view */ },
                canExecute: () => !string.IsNullOrEmpty(SelectedConfigPath)
            );
        }

        private void BrowseForConfig()
        {
            var dialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Select Configuration File"
            };

            if (dialog.ShowDialog() == true)
            {
                SelectedConfigPath = dialog.FileName;
            }
        }
    }
}