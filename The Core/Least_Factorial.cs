int leastFactorial(int n) 
{
    int f = 1;
    for(int i = 1; i < n; i++)
    {
        f *=i;
        if(f >= n)
        {
            break;
        }
    }
    return f;
}
