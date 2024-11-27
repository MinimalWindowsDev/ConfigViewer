using System.Windows;

namespace ConfigViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Show config selection window first
            var configWindow = new Views.ConfigSelectionWindow();
            var result = configWindow.ShowDialog();

            if (result == true)
            {
                // Get selected config path from the viewmodel
                var vm = (ViewModels.ConfigSelectionViewModel)configWindow.DataContext;
                var configPath = vm.SelectedConfigPath;

                if (!string.IsNullOrEmpty(configPath))
                {
                    // Create and show main window with selected config
                    var mainWindow = new Views.MainWindow(configPath);
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("No configuration selected.", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    Shutdown();
                }
            }
            else
            {
                Shutdown();
            }
        }
    }
}