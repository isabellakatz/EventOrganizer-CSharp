# Event Organizer

A small Windows desktop application for creating an event, managing its participants, and calculating basic event finances. 
Built with **C#**, **.NET 8**, and **Windows Forms**.

This project demonstrates object-oriented programming, separation of UI and application logic, collection management, and input validation in a desktop application.

## Features

- Create an event with a title, cost per participant, and participation fee.
- Add participants with a name and postal address, including a country selected from a dropdown.
- View all registered participants in a list.
- Select a participant to load their details, then edit or delete the participant.
- Automatically update a financial summary showing:
  - Number of participants
  - Total costs
  - Total participation fees
  - Surplus or deficit

Only **one event is managed at a time**. Creating a new event replaces the current event and its participant list.

## Tech stack

| Technology | Usage |
| --- | --- |
| C# | Application and business logic |
| .NET 8 (`net8.0-windows`) | Target framework |
| Windows Forms (WinForms) | Desktop user interface |
| Visual Studio 2022 | Solution and Windows Forms designer |

The project does not declare any third-party NuGet package dependencies.

## Getting started

### Requirements

- **Windows** (Windows Forms is Windows-specific)
- **Visual Studio 2022** with the **.NET desktop development** workload and support for .NET 8
- **.NET 8 SDK** (for building or running from the command line)

### Run with Visual Studio

1. Clone or download this repository.
2. Open `EventOrganizerV2.sln` in Visual Studio 2022.
3. If prompted, install the required .NET 8 development components.
4. Build the solution and press **F5** (or select **Start**) to launch the application.

### Run from the command line

On Windows, open a terminal in the folder containing `EventOrganizerV2.csproj` and run:

```powershell
dotnet restore
dotnet run --project EventOrganizerV2.csproj
```

No database, environment variables, or external services are required.

## How to use

1. Enter an **event title** and optionally specify the **cost** and **fee** per participant. Click **Create Event**.
2. Enter a participant's first name, last name, street, postal code, city, and country. Click **Add**.
3. Repeat to register more participants. The financial summary is recalculated as participants are added or removed.
4. To update a participant, select them in the list, edit the populated fields, and click **Change**.
5. To remove a participant, select them in the list and click **Delete**.

The event title is required. Participant details must be filled in. Blank or invalid cost/fee input currently defaults to zero; negative amounts are rejected.

## Project structure

```text
EventOrganizerV2/
├── EventOrganizerV2.sln         # Visual Studio solution
├── EventOrganizerV2.csproj      # Project configuration (.NET 8, WinForms)
├── Program.cs                   # Application entry point
├── MainForm.cs                  # UI event handlers and input/display logic
├── MainForm.Designer.cs         # Windows Forms-generated UI layout
├── MainForm.resx                # Form resources
├── EventManager.cs              # Event information and financial calculations
├── ParticipantManager.cs        # In-memory participant collection and operations
├── Participant.cs               # Participant model
├── Address.cs                   # Address model
├── Country.cs                   # Country enumeration
├── README.md
└── .gitignore
```

### Design overview

`MainForm` receives user input and updates the Windows Forms interface. It creates and uses an `EventManager`, which stores event-level information and owns a `ParticipantManager`. The participant manager maintains a `List<Participant>` and provides methods to add, retrieve, edit, and remove participants. Each `Participant` contains an `Address`.

The financial summary is calculated from the participant count:

```text
Total cost       = Number of participants × Cost per participant
Total fees       = Number of participants × Fee per participant
Surplus / deficit = Total fees − Total cost
```

## Current limitations

This is a learning/portfolio project rather than a production-ready event management system.

- **In-memory storage only:** events and participants are not saved when the application closes.
- **Single active event:** there is no event history or support for managing several events at once.
- **Windows desktop only:** there is no web frontend, backend API, or database.
- **Basic validation:** numeric input handling could be made clearer, and the country selector currently starts with a preselected country.
- **No automated test project** is included.

Possible next steps include improving validation, introducing unit tests for the manager classes, and adding persistent storage.

## Author

**Isabella Katz**
>