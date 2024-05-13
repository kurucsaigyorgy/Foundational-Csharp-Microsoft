
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

//Random dice = new Random();
//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);
////roll1 = 6;
////roll2 = 6;
////roll3 = 6;

//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if (roll1 == roll2 && roll2 == roll3)
//{
//    Console.WriteLine("You rolled triples! +6 points to total.");
//}
//else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
//{
//    Console.WriteLine("You rolled doubles! +2 bonus to total.");
//    total += 2;
//}

//if (total >= 16)
//{
//    Console.WriteLine("You win a new car!");
//}
//else if (total >= 10)
//{
//    Console.WriteLine("Wou win a new laptop!");
//}
//else if (total == 7)
//{
//    Console.WriteLine("You win a trip for two");
//}
//else
//{
//    Console.WriteLine("You win a cute kitten");
//}


//--------------------------------------------------------------------------
//--------------------------------------------------------------------------

// Complete a challenge activity to apply business rules

//Random random = new Random();
//int daysUntilExpiration = random.Next(12);
//int discountPercentage = 0;

//if (daysUntilExpiration == 0)
//{
//    Console.WriteLine("Your subscription has expired.");
//} 
//else if (daysUntilExpiration == 1)
//{
//    Console.WriteLine($"Your subscription expires within a day!");
//    discountPercentage = 20;
//} 
//else if (daysUntilExpiration <= 5)
//{
//    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//    discountPercentage = 10;
//}
//else if (daysUntilExpiration <= 10)
//{
//    Console.WriteLine("Your subscription expires soon. Renew now!");
//}

//if (discountPercentage > 0)
//{
//    Console.WriteLine($"Renew now and save {discountPercentage}%!");
//}

//--------------------------------------------------------------------------
//--------------------------------------------------------------------------
// Store and iterate through sequences of data using Arrays and the foreach statement in C#

//string[] orderIDs = new string[3];
//orderIDs[0] = "A123";
//orderIDs[1] = "B456";
//orderIDs[2] = "C789";
//orderIDs[3] = "D000";

//string[] orderIDs = ["A123", "B456", "C789"];

//Console.WriteLine($"First: {orderIDs[0]}");
//Console.WriteLine($"Second: {orderIDs[1]}");
//Console.WriteLine($"Third: {orderIDs[2]}");

//orderIDs[0] = "F000";

//Console.WriteLine($"Reassign first: {orderIDs[0]}");

//Console.WriteLine($"There are {orderIDs.Length} fraudulent orders to process.");

//string[] names = ["Rowena", "Robin", "Bao"];
//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

//string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
//foreach (var orderID in orderIDs)
//{
//    if (orderID.StartsWith("B"))
//    {
//        Console.WriteLine(orderID);
//    }
//}

//--------------------------------------------------------------------------
//--------------------------------------------------------------------------
//Create Readable Code with Conventions, Whitespace, and Comments in C#


/*
string fisrstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{fisrstName} purchased {widgetsPurchased} widgets");
*/

//--------------------------------------------------------------------------

/*
Random random = new Random();
string[] orderIDs = new string[5];
//Loop through each blank orderID
for (int letter = 0; letter < orderIDs.Length; letter++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and the suffix together, then assign to current OrderID
    orderIDs[letter] = prefix + suffix;
}
// Print out each orderID
foreach (var orderId in orderIDs)
{
    Console.WriteLine(orderId);
}
*/
//--------------------------------------------------------------------------
/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

/*
Random random = new Random();
string[] orderIDs = new string[5];
for (int letter = 0; letter < orderIDs.Length; letter++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[letter] = prefix + suffix;
}
foreach (var orderId in orderIDs)
{
    Console.WriteLine(orderId);
}
*/

//--------------------------------------------------------------------------

// Example 1:

/*
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord = "Example 2"; Console.WriteLine(firstWord+" "+lastWord+"!"); 
*/

//--------------------------------------------------------------------------

/*
Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    if (roll1 == roll2 && roll2 == roll3)
    {
        Console.WriteLine("You rolled triples! +6 bonus points to total!");
        total += 6;
    } 
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus points to total!");
        total += 2;
    }
}

*///--------------------------------------------------------------------------

/*
    This code sample reverses a given string and counts the occurences of a given character,
    then prints the results to the console window.
*/

/*
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message) 
{ 
    if (letter == 'o') 
    { 
        letterCount++; 
    } 
}

string newmessage = new String(message);

Console.WriteLine(newmessage);
Console.WriteLine($"'o' appears {letterCount} times.");
*/

//--------------------------------------------------------------------------
//--------------------------------------------------------------------------
// Guided project - Develop foreach and if-elseif-else structures to process array data in C#

using System;
using System.Runtime.CompilerServices;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];
string currentStudentLetterGrade;

Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia") studentScores = sophiaScores;
    else if (currentStudent == "Andrew") studentScores = andrewScores;
    else if (currentStudent == "Emma") studentScores = emmaScores;
    else if (currentStudent == "Logan") studentScores = loganScores;
    else if (currentStudent == "Becky") studentScores = beckyScores;
    else if (currentStudent == "Chris") studentScores = chrisScores;
    else if (currentStudent == "Eric") studentScores = ericScores;
    else if (currentStudent == "Gregor") studentScores = gregorScores;


    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;

    int currentStudentExtraCreditAssignments = studentScores.Length - 5;
    int sumExtraCreditScores = 0;

    decimal currentStudentExtraCredit = 0;
    decimal currentStudentExtraPoints = 0;

    decimal currentStudentOverallScore = 0;

    int gradedAssignments = 0;
    foreach (int score in studentScores)
    {
        gradedAssignments++;

        if (gradedAssignments <= examAssignments) 
        { 
            sumAssignmentScores += score; 
        }
        else 
        { 
            sumExtraCreditScores += score;
        }
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    currentStudentExtraCredit = (decimal)sumExtraCreditScores / currentStudentExtraCreditAssignments;

    currentStudentExtraPoints = (currentStudentExtraCredit / 50) * currentStudentExtraCreditAssignments;

    currentStudentOverallScore = currentStudentGrade + currentStudentExtraPoints;

    if (currentStudentOverallScore >= 97) currentStudentLetterGrade = "A+";

    else if (currentStudentOverallScore >= 93) currentStudentLetterGrade = "A";

    else if (currentStudentOverallScore >= 90) currentStudentLetterGrade = "A-";

    else if (currentStudentOverallScore >= 87) currentStudentLetterGrade = "B+";

    else if (currentStudentOverallScore >= 83) currentStudentLetterGrade = "B";

    else if (currentStudentOverallScore >= 80) currentStudentLetterGrade = "B-";

    else if (currentStudentOverallScore >= 77) currentStudentLetterGrade = "C+";

    else if (currentStudentOverallScore >= 73) currentStudentLetterGrade = "C";

    else if (currentStudentOverallScore >= 70) currentStudentLetterGrade = "C-";

    else if (currentStudentOverallScore >= 67) currentStudentLetterGrade = "D+";

    else if (currentStudentOverallScore >= 63) currentStudentLetterGrade = "D";

    else if (currentStudentOverallScore >= 60) currentStudentLetterGrade = "D-";

    else currentStudentLetterGrade = "F";

    Console.WriteLine(
        $"{currentStudent}:\t\t{currentStudentGrade}\t\t{currentStudentOverallScore}\t" +
        $"{currentStudentLetterGrade}\t{currentStudentExtraCredit} ({currentStudentExtraPoints} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
