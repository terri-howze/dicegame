# Dice Game

Welcome to the Dice Game! This is a simple console application built with C# that allows you to play a dice-rolling game against an AI opponent. The game is designed to be interactive and fun, and it will challenge your luck as you try to beat the AI in a series of dice rolls.

## Overview

In this game, you and an AI opponent will roll a dice for a specified number of rounds. The player with the highest dice roll in each round scores a point. The game continues until all rounds are played, and the player with the most points at the end wins.

## Features

- Play against an AI opponent.
- Customizable number of rounds (must be an odd number).
- Keeps track of the score for both the player and the AI.
- Interactive console prompts to roll the dice.

## Getting Started

### Prerequisites

- .NET Core or .NET Framework (any version compatible with C#)

### How to Run

1. **Clone the Repository**: Clone this repository to your local machine.
    ```bash
    git clone https://github.com/yourusername/dicegame.git
    ```

2. **Navigate to the Project Directory**:
    ```bash
    cd dicegame
    ```

3. **Build and Run the Project**:
    - Open the project in Visual Studio or your preferred C# IDE.
    - Build and run the project. If you're using the command line, you can use the following commands:
      ```bash
      dotnet build
      dotnet run
      ```

4. **Play the Game**:
    - The console will prompt you to enter the number of rounds you want to play (must be an odd number).
    - Follow the prompts to roll the dice and see the results.
    - The game will announce the winner at the end.

## Code Overview

- **`Program.cs`**: Contains the main game logic, including:
  - Initialization of game variables.
  - User input for the number of rounds.
  - Dice rolling and score calculation.
  - Display of game results.

## Example Usage

