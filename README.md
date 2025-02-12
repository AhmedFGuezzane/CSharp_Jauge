# Power Gauge Application (C#)

## Overview
This project is a C# application that features a graphical power gauge with real-time updates, customizable themes, and data persistence. The application follows a layered architecture, utilizing Models, Services, Data Access Objects (DAOs), and a graphical component.

## Features
- 🖥 **Graphical Power Gauge**: Displays dynamic values with real-time updates.
- 💾 **Data Persistence**: Save and load gauge data from memory.
- 🎨 **Customizable Themes**: Choose from multiple pre-defined themes.
- 🔄 **Reset & Update**: Easily reset and modify gauge values.
- 📂 **MVC Architecture**: Organized with Models, DAL, Services, and UI.
- 🏗 **Dependency Injection**: Ensures flexibility and maintainability.

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/power-gauge-csharp.git
   cd power-gauge-csharp
   ```
2. Open the solution in Visual Studio.
3. Build and run the project.

## Usage
- **Display Values**: Enter values and click 'Afficher' to update the gauge.
- **Reset Data**: Click 'Réinitialiser' to clear inputs.
- **Save Gauge Data**: Click 'Sauvegarder' to store data.
- **Load Data**: Select a saved entry and click 'Charger'.
- **Change Theme**: Select a theme from the dropdown.

## Project Structure
```
📂 PowerGaugeApp
├── 📁 Model          # Data models for themes and gauge data
├── 📁 Persistence    # In-memory storage implementation
├── 📁 DAL           # Data Access Layer (DAO interfaces & implementations)
├── 📁 Service       # Business logic for data and theme management
├── 📁 UI            # Windows Forms interface and graphical gauge component
├── PowerGauge.sln   # Solution file
```

## Future Improvements
- 🛠 Add exception handling with `try-catch` for robustness.
- 🚀 Implement animation support for a more interactive UI.
- 🖥 Extend data persistence to external databases.

## License
Ce projet est sous licence MIT.

---
Feel free to contribute, suggest improvements, or report issues! 🚀

