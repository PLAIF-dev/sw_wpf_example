# SW WPF Example

## Overview

SW WPF Example is a simple Windows Presentation Foundation (WPF) application developed with .NET 7. It showcases basic
WPF capabilities including data binding, command handling, and the MVVM (Model-View-ViewModel) architectural pattern.

## Features

- Image Display: Provides a user interface to display images, specifically tailored for `.png` formats.
- MVVM Architecture: Utilizes the MVVM pattern for separation of concerns and enhanced maintainability.
- Extendable: Designed to be easily extendable with additional features and functionalities.

## Project Structure

- `App.xaml`/`App.xaml.cs`: Define the startup logic and resources for the application.
- `AssemblyInfo.cs`: Contains assembly metadata.
- `Image`: Houses image resources used within the application, such as `plaif.png`.
- `Model`: Contains data models used to represent application data. Includes `MainModel.cs`.
- `View`: Comprises the user interfaces, including `MainWindow.xaml` and its code-behind `MainWindow.xaml.cs`.
- `ViewModel`: Contains `MainVM.cs` for main window logic and `ViewModelBase.cs` for base ViewModel functionality.
- `WpfAppExample.csproj`: MSBuild project file that defines how to build the code.
- `WpfAppExample.sln`: Solution file used to build and manage multiple related projects.

## Setup and Installation

1. Prerequisites:
    - Visual Studio 2022 with the .NET desktop development workload installed.
    - .NET 7 SDK and runtime.
2. Build and Run:
    - Open `WpfAppExample.sln` in Visual Studio.
    - Build the solution by right-clicking on the solution file and selecting "Build".
    - Run the application by pressing F5 or selecting "Start Debugging".

## Usage

Upon running the application, the main window will display. The application is currently set up to display an image
named "PLAIF". Additional functionality and UI elements can be added by modifying the `View`, `ViewModel`, and `Model`
components following the established MVVM pattern.

## Extending the Application

- Add new `Model` classes in the `Model` directory to represent additional data structures.
- Enhance the `MainVM.cs` with more commands and methods to add further interactivity to the application.
- Create new XAML files in the `View` directory to expand the user interface.
- Leverage `App.xaml` to define new styles and resources for the application.