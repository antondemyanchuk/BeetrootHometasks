
namespace HometaskLibrary
{
    public class NewYearCounter
    {
        public DateTime UpcommingNewYear {get;}
        public DateTime PreviousNewYear { get;}
        public DateTime CurrentDate { get;}

        public NewYearCounter(int toNewYear = 2024, int fromNewYear = 2023)
        {
 
            CurrentDate = DateTime.Now;

            while (toNewYear <= CurrentDate.Year)
            {
                toNewYear++;
            }
            UpcommingNewYear = new DateTime(toNewYear, 1, 1);

            while (fromNewYear > CurrentDate.Year)
            {
                fromNewYear--;
            }
            PreviousNewYear = new DateTime (CurrentDate.Year,1, 1);
        }

        public int DaysToNewYear()
        {
            TimeSpan ts = UpcommingNewYear.Subtract (CurrentDate);
            int result = (int)ts.TotalDays;
            return result;
        }

        public int DaysFromNewYear()
        {
            TimeSpan ts = CurrentDate.Subtract(PreviousNewYear);
            int result = (int)ts.TotalDays;
            return result;
        }
    }
}
