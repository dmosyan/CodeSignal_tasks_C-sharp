int parkingCost(string timeIn, string timeOut) 
{
    String[] time1, time2;
    time1 = timeIn.Split(':');
    time2 = timeOut.Split(':');
    int totalHour = Int32.Parse(time2[0]) - Int32.Parse(time1[0]);
    int minutes = Int32.Parse(time2[1]) - Int32.Parse(time1[1]);
    int totalMins = totalHour * 60 + minutes;

    int complex;
    if (totalMins <= 30)
    {
        return 0;
    }
    else
    {
        totalMins -= 30;
        if (totalMins > 0 && totalMins <= 90)
        {
            if (totalMins % 10 == 0)
                return totalMins / 10;
            else if (totalMins % 10 != 0)
                return (totalMins + 10) / 10;
        }
    }
    if (totalMins > 90)
    {
        complex = 9;
        totalMins -= 90;
        if (totalMins % 10 == 0)
            return ((totalMins / 10) * 2 + complex);
        else if (totalMins % 10 != 0)
            return (((totalMins + 10) / 10) * 2 + complex);
    }
    return 1;
}
