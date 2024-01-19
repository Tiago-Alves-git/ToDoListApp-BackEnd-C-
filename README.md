# ToDoList App - Backend

This is the backend for a ToDoList App written in C#. It provides functionalities to manage tasks, including creating, editing, and deleting tasks.

## Features

- **Create Task:** Add a new task to the ToDoList.
- **Edit Task:** Modify the details of an existing task.
- **Delete Task:** Remove a task from the ToDoList.

## Technologies Used

- C# (Programming Language)
- ASP.NET Core (Web Framework)

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) must be installed on your machine.

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/Tiago-Alves-git/ToDoListApp-BackEnd-C-
    ```

2. Navigate to the project directory:

    ```bash
    cd ToDoListApp-BackEnd-C-
    ```

3. Restore dependencies:

    ```bash
    dotnet restore
    ```

4. Run the application:

    ```bash
    dotnet run
    ```

    The application will be accessible at `http://localhost:5293`.

## API Endpoints

- **Create Task:**
  - Endpoint: `POST /api/tasks`
  - Request Body:
    ```json
    {
      "title": "Task Title",
      "description": "Task Description"
    }
    ```

- **Edit Task:**
  - Endpoint: `PUT /api/tasks/`
  - Request Body:
    ```json
    {
      "TaskId": 1,
      "Title": "Updated Task Title",
      "Description": "Updated Task Description",
      "IsCompleted": true
    }
    ```

- **Delete Task:**
  - Endpoint: `DELETE /api/tasks/{taskId}`

## Contributing

If you would like to contribute to this project, please follow the [Contributing Guidelines](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE).
