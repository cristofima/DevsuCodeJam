## Medium Exercises

**[1. Rock Paper Scissors Lizard Spock](https://github.com/cristofima/DevsuCodeJam/blob/master/DevsuCodeJam.Exercises/Medium/Exercise01.cs)**

Rock Paper Scissors Lizard Spock is an extension of the original Rock Paper Scissors (Rochambeau). It adds two possibilities, them being a lizard and Star Trek™’s Spock.

Two friends are playing, and you are in charge of writing down who won.

Implement a function that takes **two string[]** containing any of the following words: rock,  paper, scissors, lizard or spock.

The first array represents what player 1 drew while playing, while the second array represents what player 2 drew. If one of the corresponding strings is different than any of the given options, that player loses the round. If both strings are different than any of the given options, no points are awarded that round.

If for some reason the two string arrays are not of the same size, then you should take the smallest of the sizes and continue comparing as normal. This also means that if any of the inputs is null or empty, then both players tied.

The function should return one of five case-sensitive **string**:
- players tied, when both players tied	 
- player 1 won by 1 point, when player 1 wins by one point	 
- player 1 won by X points, when player 1 wins by X points
- player 2 won by 1 point, when player 2 wins by one point	 
- player 2 won by X points, when player 2 wins by X points

**Example:**

**Input:** [ "rock", "lizard  ", "scissors", "scissors"] ["paper", "rock", "spock", "paper"]

**Output:** player 2 won by 3 points

**[2. Minesweeper map](https://github.com/cristofima/DevsuCodeJam/blob/master/DevsuCodeJam.Exercises/Medium/Exercise02.cs)**

Minesweeper is a known computer puzzle game that debuted in the 1960s consisting of a grid that could contain a mine. You have to build a minesweeper solver, knowing the bomb placements. You are presented with an **M x N** matrix, containing either an **empty string or whitespace** or an x, which	represents a bomb.

You need to fill the matrix with numbers: every cell has a number representing how many adjacent squares contain mines. If no mines are adjacent, then you must fill the cell with a 0.

You have to implement a function that takes a **char[][]** 	and returns another **char[][]**. No input will be null.

**Example:**

**Input:**

[[ , , ,x, , , ,x, , ], 
[ , ,x, , ,x, , , ,x], 
[ ,x, , , ,x,x,x,x, ], 
[ , , ,x, ,x, ,x, , ], 
[ , , , , ,x,x,x, ,x], 
[ ,x, , ,x,x,x, , , ]] 

**Output:**

[ 
[0,1,2,x,2,1,2,x,2,1], 
[1,2,x,2,3,x,5,4,4,x], 
[1,x,3,2,4,x,x,x,x,2], 
[1,1,2,x,4,x,8,x,5,2], 
[1,1,2,2,5,x,x,x,3,x], 
[1,x,1,1,x,x,x,3,2,1] 
] 
