# WordFinder

WordFinder is a .NET 8 console application that searches for words in a character matrix. The application finds words both horizontally and vertically in the matrix and returns the top 10 most repeated words from a given word stream.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Running Tests](#running-tests)
- [Project Structure](#project-structure)
- [License](#license)

## Installation

1. **Clone the repository**

    ```bash
    git clone https://github.com/your-username/wordfinder.git
    cd wordfinder
    ```

2. **Install .NET SDK**

    Ensure you have the .NET SDK installed. You can download it from [here](https://dotnet.microsoft.com/download).

3. **Restore dependencies**

    ```bash
    dotnet restore
    ```

## Usage

1. **Navigate to the application directory**

    ```bash
    cd WordFinder.App
    ```

2. **Build the application**

    ```bash
    dotnet build
    ```

3. **Run the application**

    ```bash
    dotnet run
    ```

    This will execute the `Main` method in the `Program.cs` file, which contains sample code to test the `WordFinder` class.

## Running Tests

1. **Navigate to the test project directory**

    ```bash
    cd WordFinder.Test
    ```

2. **Run the tests**

    ```bash
    dotnet test
    ```

    This will execute all the unit tests in the `WordFinder.Test` project. The test results will be displayed in the terminal.

## Project Structure

