# Mars Rover

## Information

A Mars Rover has been developed to map out the landscape. It's a small robot which can move on a grid, controlled by simple commands.

In this example, it will move on a 5x5 grid with a simple co-ordinate system - 0,0 is the bottom left, 4,4 is the top right.

We can control the Rover by sending it a string consisting of commands, such as the following: RFLFFRF

- R means rotate right 90 degrees, 
- L rotate left 90 degrees, 
- F means move forward one square in the direction the Rover is currently facing. 

The Rover starts at 0,0 facing North ("up" the grid). We need a program which will accept strings of commands at the command line, and return the grid position.

## Aim

Clean, readable, maintainable code.

Prepare to extend programs to cope with new features or capabilities. It's quite uncommon to have truly perfect specifications for any program and this is no exception!