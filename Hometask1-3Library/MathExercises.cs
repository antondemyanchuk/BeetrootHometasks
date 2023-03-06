
namespace HometaskLibrary
{
    public class MathExercises
    {
        public int X { get; set; }
        public int Y { get; set; }

        double result;

        public MathExercises(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int FirstExercise()
        {
            result = (-6 * Math.Pow(X, 3) + 5 * Math.Pow(X, 2) - 10 * X + 15);
            return (int)result;
        }

        public double SecondExercise()
        {
            result = Math.Round((Math.Abs(X) * Math.Sin(X)), 4);
            return result;
        }

        public double ThirdExercise()
        {
            result = Math.Round(2 * Math.PI * X, 4);
            return result;
        }

        public int FourthExercise()
        {
            result = Math.Max(X, Y);
            return (int)result;
        }

        public int SumBetweenTwoValues()
        {
            int firstNumber;
            int secondNumber;

            if (X == Y)
            {
                return X;
            }
            else if (X < Y)
            {
                firstNumber = X;
                secondNumber = Y;
            }
            else
            {
                firstNumber = Y;
                secondNumber = X;
            }

            while (firstNumber <= secondNumber)
            {
                result += firstNumber;
                firstNumber++;
            }

            return (int)result;
        }
    }
}
