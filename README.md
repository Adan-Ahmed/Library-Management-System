# Library Management System

## About the Project

The Library Management System is a console-based application developed using C#. It helps manage books and library members through a simple menu-driven interface.

The project uses object-oriented programming (OOP) concepts and JSON files to store data permanently, so the information can be loaded again when the application restarts.

## Features

- Add new books.
- Add new library members.
- View all books and members.
- Search for books.
- Borrow available books.
- Track book availability.
- Load saved data when the application starts.
- Save books and member data in JSON files.

## Technologies Used

- **Language:** C#
- **Platform:** .NET Console Application
- **Data Storage:** JSON files
- **Concepts:** OOP, Classes, Objects, Constructors, Properties, Lists, Methods, File Handling, and JSON Serialization/Deserialization

## Project Structure

```text
LibraryManagementSystem/
│
├── Program.cs
├── Book.cs
├── Member.cs
├── Library.cs
├── books.json
├── Member.json
└── README.md
```

*Note: The exact file names and structure may differ depending on your project.*

## Data Storage

The application stores its data in JSON files.

- `books.json` — stores book information.
- `Member.json` — stores library member information.

JSON allows the application to save structured data in a readable text format.

### Example: books.json

```json
[
  {
    "ID": 1,
    "Title": "C# Fundamentals",
    "Author": "John Smith",
    "Category": "Programming",
    "IsAvailable": true
  }
]
```

*The JSON property names and fields depend on the properties defined in your `Book` class.*

## How to Run the Project

1. Install the .NET SDK.
2. Open the project in Visual Studio or VS Code.
3. Open a terminal in the project directory.
4. Run the following command:

```bash
dotnet run
```

5. Follow the console menu to manage books and members.

## What I Learned

Through this project, I practised:

- Creating classes and objects in C#.
- Using constructors and properties.
- Managing collections with `List<T>`.
- Separating application logic into multiple classes and files.
- Implementing search and book-borrowing logic.
- Reading and writing JSON files.
- Using serialization and deserialization for persistent storage.

## Future Improvements

- Add book-return functionality.
- Prevent duplicate book and member IDs.
- Add input validation and exception handling.
- Track which member has borrowed each book.
- Migrate from JSON file storage to SQL Server.
- Build an ASP.NET Core Web API version of the system.

## Author

Adan Ahmed

