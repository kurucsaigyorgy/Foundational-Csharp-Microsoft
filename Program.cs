
//Random dice = new Random();
//int roll1 = dice.Next();
//int roll2 = dice.Next(101);
//int roll3 = dice.Next(50, 101);

//Console.WriteLine($"The first roll: {roll1}");
//Console.WriteLine($"The second roll: {roll2}");
//Console.WriteLine($"The third roll: {roll3}");


/*int firstValue = 700;
int secondValue = 1000;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
*/

//--------------------------------------------------------------------------

// Dice rolling mini game
// Add Decision Logic to Your Code Using if, else, and else if statements in C#

using System.Globalization;

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("You rolled triples! +6 points to total.");
}
else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    Console.WriteLine("You rolled doubles! +2 bonus to total.");
    total += 2;
}

if (total >= 15)
{
    Console.WriteLine("You Win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}


//--------------------------------------------------------------------------



