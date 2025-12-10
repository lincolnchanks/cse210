class Calendar
{
    private List<Day> _days;

    public Calendar(User user)
    {
        // Make an empty list of days (can replace this with _days)
        // List<Day> calendarDaysList = new List<Day>();

        // Get today's date, and extract the info into data
        DateTime today = DateTime.Today;
        int currYear = today.Year;
        int currMonth = today.Month;
        int currDay = today.Day;

        // Creates the next 30 days and adds them to the
        // calendar.
        for (int i = 0; i < 30; i++)
        {
            // Checks if the day exceeds the current month.
            if (currMonth is 1 or 3 or 5 or 7 or 8 or 10 or 12)
            {
                if ((31 - currDay) > i)
                {
                    Day tempDay = new Day(currYear, currMonth, currDay + i, user);
                    _days.Add(tempDay);
                }
                else
                {
                    Day tempDay = new Day(currYear, currMonth + 1, i - (31 - currDay), user);
                    _days.Add(tempDay);
                }
            }
            else if (currMonth is 4 or 6 or 9 or 11)
            {
                if ((30 - currDay) > i)
                {
                    Day tempDay = new Day(currYear, currMonth, currDay + i, user);
                    _days.Add(tempDay);
                }
                else
                {
                    Day tempDay = new Day(currYear, currMonth + 1, i - (30 - currDay), user);
                    _days.Add(tempDay);
                }
            }
            else
            {
                if ((28 - currDay) > i)
                {
                    Day tempDay = new Day(currYear, currMonth, currDay + i, user);
                    _days.Add(tempDay);
                }
                else
                {
                    Day tempDay = new Day(currYear, currMonth + 1, i - (28 - currDay), user);
                    _days.Add(tempDay);
                }
            }
        }
    }
    public void DisplayCalendar(int dateRange)
    {
        
    }
}