# Coding Interview Patterns in C#

This project contains solutions to the 'Coding Interview Patterns in C#' course available on [Educative.io](https://www.educative.io/courses/grokking-coding-interview-in-csharp).

## Usage

You can run the project and select a coding pattern and problem interactively:

```
dotnet run
```

Alternatively, you can specify the pattern and problem numbers as command-line arguments:

```
dotnet run <PatternNumber> <ProblemNumber>
```

Example:

```
dotnet run 2 1
```

This will run the first problem in the Two Pointers pattern.

## Project Structure

- The course is composed of various chapters, each signifying a coding pattern.

- The project is structured to resemble the course:
    - Each folder (e.g., `N02_TwoPointers`) corresponds to a 'coding pattern' chapter.
    - Each file (e.g., `P01_ValidPalindrome.cs`) corresponds to a 'coding problem'.

- Namespaces and class names are chosen to make it easier to submit the solution with minimal changes.
- Each file contains the problem statement added as a comment.
- Each file contains a `Tests` class that runs tests on the solution.
- The files are self-sufficient; all required data structures and methods to compose and decompose them are included in the same files.
- The `Utilities.cs` file contains methods, such as printing values, that are commonly required for all tests.
- Test results are color-coded: yellow for running, green for success, and red for failure.

## Requirements

- .NET 9.0 SDK or later

## License

MIT
