namespace LeapYear
{
    public class LeapYearValidator
    {
        public bool Validate(int year)
        {
            return IsTypicalLeapYear(year) && !IsAnAtypicalCommonYear(year);
        }

        private static bool IsTypicalLeapYear(int year)
        {
            return year % 4 == 0;
        }

        private static bool IsAnAtypicalCommonYear(int year)
        {
            return year % 100 == 0 && year % 400 != 0;
        }
    }
}
