class Calendar
{
    private List<Day> _days;

    public Calendar(User user)
    {
        // Get today's date, and extract the info into data
        DateTime today = DateTime.Today;
        int currYear = today.Year;
        int currMonth = today.Month;
        int currDay = today.Day;

        // Creates the next 30 days and adds them to the calendar's list.
        int numDays;
        for (int i = 0; i < 30; i++)
        {
            // Sets the number of days in the month.
            if (currMonth is 1 or 3 or 5 or 7 or 8 or 10 or 12)
            {
                numDays = 31;
            }
            else if (currMonth is 4 or 6 or 9 or 11)
            {
                numDays = 30;
            }
            else
            {
                numDays = 28;
            }

            // This handles dates wrapping into the next month.
            int daysLeftInMonth = numDays - currDay;
            if (daysLeftInMonth > i)
            {
                Day tempDay = new Day(currYear, currMonth, currDay + i, user);
                _days.Add(tempDay);
            }
            else
            {
                Day tempDay = new Day(currYear, currMonth + 1, i - daysLeftInMonth, user);
                _days.Add(tempDay);
            }
        }
    }
    public void DisplayCalendar(int dateRange)
    {
        
    }
}