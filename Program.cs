using System.ComponentModel.DataAnnotations;

namespace Tuple
{
    public struct Date
    {

        public int Year {get; set;}
        public int Month {get; set;}
        public int Day {get; set;}

        public Date(int year, int month, int day)
        {
            this.Year = year; 
            this.Month = month; 
            this.Day = day; 
        }

        public bool IsValid()
        {
            try
            {
                //Checks if the Year, Month, and Day properties represent a valid date.
                DateTime dateTime = new DateTime(Year, Month, Day);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override string ToString()
        {
            //Returns the date in the format "yyyy-mm-dd". 
            return $"{Year:0000}-{Month:00}-{Day:00}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(2023, 2, 17);

            Date date2 = new Date(2023, 2, 29);

            Date date3 = new Date(2023, 13, 1);

            Console.WriteLine("Date 1 is valid? " + date1.IsValid());

            Console.WriteLine("Date 2 is valid? " + date2.IsValid());

            Console.WriteLine("Date 3 is valid? " + date3.IsValid());

            Console.WriteLine("Date 1: " + date1.ToString());

            Console.WriteLine("Date 2: " + date2.ToString());

            Console.WriteLine("Date 3: " + date3.ToString());
        }
    }
}
