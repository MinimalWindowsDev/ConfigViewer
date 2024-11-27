# ConfigViewer

A minimal C# WPF MVVM application demonstrating configuration file selection and visualization flow using XAML and JSON.

## Overview

This application serves as a minimal working example of:

- WPF MVVM architecture implementation
- Configuration file selection dialog
- JSON configuration file loading and visualization
- Proper window management in WPF
- Clean separation of concerns (Models, Views, ViewModels)

## Structure

```
ConfigViewer/
├── Models/
│   └── Config.cs             # Data model for configuration
├── ViewModels/
│   ├── ViewModelBase.cs      # Base class for all ViewModels
│   ├── RelayCommand.cs       # ICommand implementation
│   ├── MainWindowViewModel.cs       # Main window logic
│   └── ConfigSelectionViewModel.cs  # Config selection logic
├── Views/
│   ├── MainWindow.xaml       # Main application window
│   └── ConfigSelectionWindow.xaml   # Configuration selection dialog
└── App.xaml                  # Application entry point
```

## Usage

1. Run the application
2. Select a JSON configuration file using the file selection dialog
3. View the configuration contents in the main window

## Sample Configuration Format

```json
{
  "Name": "Sample Configuration",
  "Version": "1.0.0",
  "Items": ["Item 1", "Item 2", "Item 3"]
}
```

## Requirements

- .NET Framework 4.8
- Visual Studio 2019 or later
- System.Text.Json NuGet package

## Building

1. Clone the repository
2. Open the solution in Visual Studio
3. Restore NuGet packages
4. Build the solution

## License

```
        DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
                    Version 2, December 2004

 Copyright (C) 2004 Sam Hocevar <sam@hocevar.net>

 Everyone is permitted to copy and distribute verbatim or modified
 copies of this license document, and changing it is allowed as long
 as the name is changed.

            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION

  0. You just DO WHAT THE FUCK YOU WANT TO.
```
