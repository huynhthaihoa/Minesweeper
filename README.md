# Minesweeper
C# clone of the classic Minesweeper

*Last updated: 04/01/2022 - 6:23PM (KST)*
## Installation
Build & run with Microsoft Visual Studio 2019 using .NET Framework 4.7.2
## Done
- Generate new game with 3 modes:
  - 9x9 field with 10 mines (Easy) - default mode
  - 16x16 fields with 40 mines (Medium)
  - 16x30 fields with 99 mines (Hard)
- Handle event when click on one cell:
  - Display -1 if the clicked cell is a mined cell and every cell will automatically be uncovered
  - Display a positive number which indicates the number of mines diagonally and/or adjacent to it
  - Display a blank cell and all adjacent non-mined cells will automatically be uncovered 
 ## To do
 - Set timer and score
 - Add trigger to ensure the first clicked cell will never be a mined cell
 - Improve GUI (?)
 - Add high score table


