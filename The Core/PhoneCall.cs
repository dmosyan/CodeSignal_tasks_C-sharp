/*
Some phone usage rate may be described as follows:

first minute of a call costs min1 cents,
each minute from the 2nd up to 10th (inclusive) costs min2_10 cents
each minute after 10th costs min11 cents.
You have s cents on your account before the call. What is the duration of the longest call (in minutes rounded down to the nearest integer) you can have?

Example

For min1 = 3, min2_10 = 1, min11 = 2, and s = 20, the output should be
phoneCall(min1, min2_10, min11, s) = 14.
*/
int phoneCall(int min1, int min2_10, int min11, int s)
{
    int minutes = 0;

    if (s>=min1)
    {
        s -= min1;
        minutes += 1;
    }

    while (s >= min2_10 && minutes < 10)
    {
        s -= min2_10;
        minutes += 1;
    }

    while(s >= min11 && minutes >= 10)
    {
        s -= min11;
        minutes += 1;
    }

    return minutes;
}
