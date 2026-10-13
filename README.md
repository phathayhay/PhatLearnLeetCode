# LeetCode Solutions in C#

A repository for storing and organizing solutions to LeetCode algorithmic problems implemented in C#.

## Environment & Tech Stack

- **Language:** C#
- **Target Framework:** .NET 10.0
- **Development Environment:** Visual Studio / Visual Studio Code / .NET CLI

## Project Structure

Solutions are organized into dedicated directories for each LeetCode problem:

```text
D:\LeetCode\
├── .gitignore
├── README.md
└── TwoSum\
    ├── Program.cs
    ├── Solution.cs
    ├── TWOSUM.csproj
    └── TWOSUM.slnx
```

Each problem directory is self-contained with its own project configuration, runnable console driver, and solution implementation.

## Problems List

| # | Problem | Directory | Description | Status |
|---|---|---|---|---|
| 1 | Two Sum | [TwoSum](./TwoSum/) | Find two numbers in an array that sum to a specific target and return their indices. | Completed |

## How to Build and Run

### Using the .NET CLI

You can build and run individual problem solutions directly from the command line:

1. **Navigate to the problem folder:**
   ```bash
   cd TwoSum
   dotnet build
   dotnet run
   ```

2. **Run directly from the repository root:**
   ```bash
   dotnet run --project TwoSum/TWOSUM.csproj
   ```

### Using Visual Studio

1. Open Visual Studio.
2. Open the solution file `TwoSum/TWOSUM.slnx` or the project file `TwoSum/TWOSUM.csproj`.
3. Set the project as the startup project and run with `Ctrl + F5` (Start Without Debugging) or `F5` (Start Debugging).

## Adding a New Problem

To add a new LeetCode problem to this repository:
1. Create a new directory named after the problem (e.g., `ValidParentheses/`).
2. Add the C# source files (`Solution.cs`, `Program.cs`) and project file (`.csproj`).
3. Commit and push changes from the repository root:
   ```bash
   git add .
   git commit -m "Add <ProblemName> solution"
   git push
   ```
