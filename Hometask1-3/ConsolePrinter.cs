
namespace Hometask1_3
{
    internal class ConsolePrinter
    {
        public void MathExercisesPrinter(int result)
        {
            Console.WriteLine($"The result is {result} \n");
        }

        public void MathExercisesPrinter(double result) 
        {
            Console.WriteLine($"The result is {result} \n");
        }

        public void DaysToNewYearPrinter(int result) 
        {
            Console.WriteLine($"{result} days left to New Year \n");
        }

        public void DaysFromNewYEarPrinter(int result)
        {
            Console.WriteLine($"{result} days passed from New Year \n");
        }

        public void SumBetweenTwoValuesPrinter(int firstValue, int secondValue, int result)
        {
            Console.WriteLine($"The sum of all numbers between {firstValue} and {secondValue} is {result} \n");
        }
    }
}
