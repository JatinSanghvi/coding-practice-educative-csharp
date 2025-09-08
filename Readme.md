# Coding Interview Patterns in C#

This project contains solutions to the 'Coding Interview Patterns in C#' course available on [Educative.io](https://www.educative.io/courses/grokking-coding-interview-in-csharp).

## Usage

You can run the project and select a coding pattern and problem interactively:

```
dotnet run
```

Alternatively, you can specify the pattern and problem numbers as command-line arguments. For example, the following will run the first problem in the 'Two Pointers' pattern.

```
dotnet run 2 1
```

## Project Information

- The Educative course is composed of various chapters grouped by coding patterns.

- The source files in this project are organized to resemble the course:
    - Each folder (e.g., `N02_TwoPointers`) corresponds to a 'coding pattern' chapter.
    - Each file (e.g., `P01_ValidPalindrome.cs`) corresponds to a 'coding problem' within the chapter.

- The namespaces and class names are specifically chosen to make it easier to submit the solutions with minimal changes.

- Each source file contains
    - The problem statement as top-level comment.
    - Time and space complexity numbers as method comments.
    - `Tests` class that runs basic tests on the solution.
    - Custom data structures used for problem inputs and outputs.
    - Methods to compose and decompose values into custom data structures.

- Space complexity calculations do not include the space required for storing input and output data.
- `Utilities.cs` contains methods, such as printing values, that are commonly required for all tests.
- Test results are color-coded: yellow for run output, green for success, and red for failure.
- Skipped solutions will throw `NotImplementedException`.

## Requirements

- .NET 9.0 SDK or later

## License

MIT
