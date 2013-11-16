Assignment 1
------------

First thing's first. Copy the contents of this directory to the following path (creating the appropriate
directories along the way):

C:\...\GitHub\WOS-Advanced-CSharp-Winter-2013\Submissions\1\yourName\

Please do not change the source code inside the root directory. You should instead commit your own copy
into the submissions directory, and replace "yourName" above with a first initial then last name format.
For example, my submission would be located at:

C:\...\GitHub\WOS-Advanced-CSharp-Winter-2013\Submissions\1\jeremyd\

Next, notice that there are two main parts to this assignment. There are a couple of problems to solve
along with a program you need to finish out. When you open up the solution you should see three projects: 
Problems, Tests, and TicTacToe. 

To begin with, take a look in the Problems project. There are two class files you need to pay attention to: 
Problem1.cs and Problem2.cs. Each of these files has some code and comments inside it. Let's take a look.

### Problem 1
The objective of the first part of the assignment is to make all implemented unit tests pass. You can find these
tests in the Tests project, and you can figure out how to run them at the link below. Don't worry about trying to
modify any code in the Tests project--instead focus on changing the code in Program1.cs until the tests light up
green. We will spend a lot more time playing with MSTest in later assignments.

http://msdn.microsoft.com/en-us/library/hh270865.aspx[1]

You should modify the code in the Problem1.cs file until all of the unit tests pass as described
in the above link. The comments in each method in the Problems1.cs file should also give you some hints.

### Problem 2
The objective of the second part of the assignment is to exercise your program design muscles. Open
up Problem2.cs and follow the instructions in the comments for each class. This exercise is particularly
open ended, so be creative. Try to build out as robust an object model as you can think of--and be sure
to use properties, fields, and methods as you see fit. We're not actually going to execute this code, but 
please make sure it compiles.

### Problem 3
Finally, in the last part of the assignment you will be finishing out a simple TicTacToe implementation
that I started. Take a look at the code inside the TicTacToe project and familiarize yourself with what's
going on. Then, implement the missing pieces in TicTacToeBoard.cs. You can identify these missing pieces
by looking for ```throws new NotImplementedException``` in the method and property bodies. In the end, you
should have a working two player TicTacToe game.

[1]: http://msdn.microsoft.com/en-us/library/hh270865.aspx