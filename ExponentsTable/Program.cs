/* name: Connor Wood
 * Date: 6/23/2022
 * Project: Exponent Table
 */

using System.Data;

bool rerun = true;
string runagain = "y";
//int counter = 1;
int userInput = 0;

Console.WriteLine("Hello and welcome to the Powers Program!");
Console.WriteLine("Let's get ready to learn some squares and cubes...");

while (rerun)
{
    Console.WriteLine("Please enter an integer.");
    userInput = int.Parse(Console.ReadLine());
    Console.WriteLine("Number  Squared  Cubed");

    //this for loop checks to see if i is less than userInput.
    //For each time i is less than userInput, the for loop loops, and another console writeline is displayed
    //for each loop, one is added to i until it is equal to userInput
    for (int i = 1; i <= userInput; i++)
    { 
        Console.WriteLine(i + "\t" + squared(i) + "\t" + cubed(i));
    }

    //this method returns the squared number of the user
    //Because this method is included in the for loop above, it will return a number for each time i is less than userInput
    static int squared(int userInput)
    {
        int squared = userInput * userInput;
        return squared;
    }

    //this method returns the cubed number of the user
    //This method is also included in the for loop above
    static int cubed(int userInput)
    {
        int cubed = userInput * userInput * userInput;
        return cubed;
    }

    //this section of the code checks if the user wants to run the program again
    Console.WriteLine("Do you want to run this program again? y/n");
    runagain = Console.ReadLine().ToLower().Trim();
    if (runagain == "y")
    {
        Console.WriteLine("Let's run it back!");
    }
    else
    {
        Console.WriteLine("Thanks for using the Powers Program!  Have a good day");
        //if the user doesnt enter y, rerun is set to false stopping the while loop
        rerun = false;
    }
}