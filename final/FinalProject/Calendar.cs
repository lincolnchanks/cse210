class Calendar
{
    private List<Day> _days;

    private int GetNumDaysInCurrentMonth(int currMonth)
    {
        int numDaysInCurrentMonth;
        // If the current month is a 31-day month, set it to 31 days
        if (currMonth is 1 or 3 or 5 or 7 or 8 or 10 or 12)
        {
            numDaysInCurrentMonth = 31;
        }
        // If the current month is a 30-day month, set it to 30 days
        else if (currMonth is 4 or 6 or 9 or 11)
        {
            numDaysInCurrentMonth = 30;
        }
        // Otherwise, it's February so set it to 28 days
        else
        {
            numDaysInCurrentMonth = 28;
        }
        return numDaysInCurrentMonth;
    }
    
    public Calendar(User user)
    {
        List<Day> days = new List<Day>();

        // Get today's date, then get the year, month, and day of today's date.
        DateTime today = DateTime.Today;
        int currYear = today.Year;
        int currMonth = today.Month;
        int currDay = today.Day;

        // Creates the next 14 days and adds them to the calendar's list.

        int numDaysInCurrentMonth;
        // Could we try declaring the daysLeftInMonth variable outside the for loop?
        for (int i = 0; i < 14; i++)
        {
            // Get the correct number of days depending on the current month.
            numDaysInCurrentMonth = GetNumDaysInCurrentMonth(currMonth);

            // This handles dates wrapping into the next month.

            int daysLeftInMonth = numDaysInCurrentMonth - currDay;
            // If there is at least one day left in the month, create a Day object
            // for the day matching today + i.
            if (daysLeftInMonth > i)
            {
                Day tempDay = new Day(currYear, currMonth, currDay + i, user);
                days.Add(tempDay);
            }
            // If there is not another day left in this month, run this code to wrap the month.
            else
            {
                currMonth += 1; // Increment month number by one.
                // This code doesn't work right now.
                if (currMonth == 13)
                {
                    // If we roll past December, set the month to January
                    // and increment the year.
                    currMonth = 1;
                    currYear += 1;
                    Day yearWrapDay = new Day(currYear, currMonth, i - daysLeftInMonth, user);
                    days.Add(yearWrapDay);
                }
                else
                {
                    Day tempDay = new Day(currYear, currMonth, i - daysLeftInMonth, user);
                    days.Add(tempDay);
                }
            }

            // For some reason I can't directly add Day objects to _days.
            _days = days;

            //TO-DO: Handle year wrapping as well.
            // the code above looks like it would work just fine. Why doesn't it?
        }
    }
    public void DisplayCalendar()
    {
        foreach (Day day in _days)
        {
            day.DisplayDay();
        }
    }
    public List<Day> GetDays()
    {
        return _days;
    }
}