# TicTacToe

## Tic-Tac-Toe I 

Implement the well-known Tic-Tac-Toe game.

In this first version we will have to implement:

- The nine squares created at run time and forming a 3x3

- Menu that allows you to exit the game, start a new one and have a help.

- We will play 2 humans, so each click will put a different image in an empty box.

- The system will randomly choose which player (1 or 2) is the first to play and will indicate who has won or if it has ended in a draw, giving the possibility to replay or exit.


## Tic-Tac-Toe II 

We will make the following modifications to our game.

Before you start playing, and using a menu option for this purpose, we will open a form where:

* You can indicate the name of the 2 players and you can indicate the image that will be displayed for each player. That is, each player can choose which image they want to appear when clicking. You can use an OpenFileDialog and monitor its FileName property and put the result in a PictureBox. We can use a Checkbox that allows you to put the default image (X or O)

* We will be able to indicate whether player 2 will be human or the computer (even if we do not implement the functionality of the computer, in this second version)

* You can select, using RadioButtons, 2 game types: 3 in line (version that we have implemented so far) and 4 in stripe (new version with 4x4 grids). 


## Tic-Tac-Toe III 

The last improvement is that if we select the Computer box in our preferences, we will play against the CPU.
