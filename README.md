# Creational-Patterns-Example
Simple example of creational patterns for studying purposes

## Table of contents

- [Problem](#problem)
- [Program usage guide](#program-usage-guide)
- [Documentation](#documentation)
- [Aclarations](#aclarations)

## Problem

The problem Im solving with creational patterns is a Character creation menu.

This program is actually just a part of a bigger project (game) I made about creating characters who shoot each other.

In this previous project It would have been usefull to use a creational pattern. So I decided to a apply
the **Factory creational pattern** for the character creation part in the project.

## Program usage guide

Just run this program with a C# compiler.

This mini game menu program consist of:

-  An initial character creation.
-  A menu which lets the user choose to create more characters, to select another character that was created or to showcase the actual player in use.

This process is in the main program (program.cs)

Note: The default character in use is the initial character that is created at the start of the program.

## Documentation

This project was made trying to follow SOLID principles and I ended up with some classes to recolect the Character data that are easier
to understand with diagrams.

In this repository are images with a Classes diagram and a Sequence diagram of this program.

## Aclarations

-  I know this project could be enhanced and be more SOLID, but the main focus was just to implement the **Factory creational pattern** to solve some problem.
In this case the problem was the way the characters are created.

-  In the Sequence diagram, I use a function called "SelectPlayerCharacter()" but in the actual program there is no function for the character/player selection
I just wrote that function in the diagram to make sense of the actions in the program.cs file.
What the "SelectPlayerCharacter()" represents is what the name says, but in the code this is a simple "player = playerList[selection];"

-  The sequence diagram only represents the events ocurring in the main file "program.cs"