# Minesweeper
C# clone of the classic Minesweeper

*Last updated: 04/02/2022 - 07:34PM (KST)*
## Installation
- Build & run with Microsoft Visual Studio 2019 using .NET Framework 4.7.2 (no additional dependencies)
- Run the program directly at Demo/Minesweeper.exe
## Done
- Generate new game with 3 modes:
  - 9x9 field with 10 mines (Easy) - default mode
  - 16x16 fields with 40 mines (Medium)
  - 16x30 fields with 99 mines (Hard)
- Handle event when click on one cell:
  - Display mine if the clicked cell is a mined cell and every cell will automatically be uncovered
  - Display a positive number which indicates the number of mines diagonally and/or adjacent to it
  - Display a blank cell and all adjacent non-mined cells will automatically be uncovered 
- Ensure the first clicked cell will never be a mined cell
- Finish game:
  - When the mined cell is clicked (all cells will be uncovered) -> "Game over!"
  - When every unmined cell is uncovered (all mined cells will become red) -> "Victory!"
- Add mined cell icon & program icon
- Display timer on hh:mm:ss format
 ## To do
 - Find & fix potential bugs
 - Imrove performance
 - Improve GUI (?)
 - Add high score table
 ## Credit
 Mine icon was downloaded from [pngwing](https://www.pngwing.com/en/free-png-cbukd)


