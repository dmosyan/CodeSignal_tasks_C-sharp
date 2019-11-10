int digitDistanceNumber(int n) 
{
    int output = 0;
    int lastDigit = n % 10;
    int multy = 1;
    n /= 10;
    while(n>0)
    {
        output += multy * Math.Abs(n%10-lastDigit);
        multy *= 10;
        lastDigit = n % 10;
        n/=10;
    }
    return output;
}
