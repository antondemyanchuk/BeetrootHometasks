
namespace Hometask1_3
{
    public class ConsoleHelper
    {
        private const int Attempts = 3;

        public int GetValue(string invitationToAction, string invalidInputMessage)
        {
            if (string.IsNullOrEmpty(invitationToAction)) { throw new ArgumentNullException(); }
            if (string.IsNullOrEmpty(invalidInputMessage)) { throw new ArgumentNullException(); }
            
            int attempts = 0;

            Console.WriteLine(invitationToAction);
            while (attempts < Attempts)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                ++attempts;
                Console.WriteLine(invalidInputMessage);
                Console.WriteLine(invitationToAction);
            }
            string message = "The limit for entering incorrect data has been exceeded";
            throw new ArgumentOutOfRangeException(message);
        }
    }
}
