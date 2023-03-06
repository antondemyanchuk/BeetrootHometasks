using HometaskLibrary;
using Hometask1_3;

var greeting = "Welcome to my 1 - 3 Home tasks ";
var invitationToActionFirst = "Type please the first integer number, please, than press 'Enter'";
var invitationToActionSecond = "Type please the second integer number, please, than press 'Enter'";
var invalidInput = "The incorrect input";
var parting = "Thank you for your time and have a nice day! \nPress any key to exit";

Console.WriteLine(greeting);
Console.WriteLine();

var consoleHelper = new ConsoleHelper();
int firstValue = consoleHelper.GetValue(invitationToActionFirst,invalidInput);
int secondValue = consoleHelper.GetValue(invitationToActionSecond,invalidInput);

Console.WriteLine();

var mathExercises = new MathExercises(firstValue,secondValue);
var newYearCounter = new NewYearCounter();
var consolePrinter = new ConsolePrinter();

consolePrinter.MathExercisesPrinter(mathExercises.FirstExercise());
consolePrinter.MathExercisesPrinter(mathExercises.SecondExercise());
consolePrinter.MathExercisesPrinter(mathExercises.ThirdExercise());
consolePrinter.MathExercisesPrinter(mathExercises.FourthExercise());

consolePrinter.DaysToNewYearPrinter(newYearCounter.DaysToNewYear());
consolePrinter.DaysFromNewYEarPrinter(newYearCounter.DaysFromNewYear());

consolePrinter.SumBetweenTwoValuesPrinter(firstValue, secondValue, mathExercises.SumBetweenTwoValues());

Console.WriteLine(parting);
Console.ReadKey();


 