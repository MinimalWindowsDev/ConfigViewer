using System.Windows;

namespace ConfigViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Set shutdown mode before showing any windows
            ShutdownMode = ShutdownMode.OnExplicitShutdown;

            // Show config selection window
            var configWindow = new Views.ConfigSelectionWindow();
            var result = configWindow.ShowDialog();

            if (result == true)
            {
                var vm = (ViewModels.ConfigSelectionViewModel)configWindow.DataContext;
                var configPath = vm.SelectedConfigPath;

                if (!string.IsNullOrEmpty(configPath))
                {
                    var mainWindow = new Views.MainWindow(configPath);
                    // Set as main window before showing
                    Current.MainWindow = mainWindow;
                    // Change shutdown mode to normal behavior
                    ShutdownMode = ShutdownMode.OnMainWindowClose;
                    mainWindow.Show();
                }
            }
            else
            {
                Shutdown();
            }
        }
    }
}