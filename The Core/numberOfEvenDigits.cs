int numberOfEvenDigits(int n) 
{
    int countEven = 0;
    while(n>0)
    {
        int a = n%10;
        if(a%2==0)
        {
            countEven++;
        }
        n /= 10;
    }
    return countEven;
}
