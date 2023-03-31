'Snake' by Adam Sears for Code Louisville SD1

'Snake' is a console-based implementation of the classic Snake game in C#. The game features a snake that moves around the console screen and eats food. 
The snake grows in length as it eats food, and the game speeds up, increasing the difficulty. 
The game ends when the snake hits the console borders or itself. High scores are stored in a local file with the user's initials.

Code Louisville Requirements
Feature 1:
Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program
	This is accomplished through the closed loop in the main game logic, where the user can control the snake, restart the game, or quit.

Feature 2:
Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program
	The snake's body parts are managed by two lists for the X and Y coordinates, which are initialized and updated throughout the game.

Feature 3:
Read data from an external file, such as text, JSON, CSV, etc and use that data in your application
	High scores are saved to and read from an external file, allowing the user to input their initials and see the high scores from previous plays.

Feature 4:
Use a LINQ query to retrieve information from a data structure (such as a list or array) or file
	The high scores list is sorted in descending order using a LINQ query, which ensures that the highest scores are displayed at the top.


-Getting Started -
Clone the repository or download the source code.
Open the solution file in Visual Studio.
Build and run the project.
* requires .NET 6.0 or later
Press 'Enter' to start the game.
Use arrow keys to control the snake.
Eat the red '+' food to increase the score.
Avoid hitting the walls or the snake's own body.
When the game ends, enter your initials to save your high score.
Press 'R' to restart or 'Q' to quit.
*On Mac, there is a bug that requires the removal of the line: console.SetWindowSize for mac

Features:
 Console-based snake game with a growing snake and increasing difficulty
 Arrow key controls for the snake
 Collision detection with walls and the snake's own body
 High scores stored in a local text file with user initials
 Restart or quit the game after viewing high scores
 Colorful game elements using console colors

- Todo -
 Add a main menu for starting the game and viewing high scores
 Improve the high score display with better formatting
 Implement additional features, such as different game modes or challenges