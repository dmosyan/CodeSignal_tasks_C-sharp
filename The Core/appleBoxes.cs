int appleBoxes(int k) 
{
    int count1=0;
    int count2=0;
    for(int i=3; i<=k; i+=2)
    {
        count1 += i*i;
    }
    for(int j=2; j<=k; j+=2)
    {
        count2 +=  j*j;
    }
    return count2-count1-1;
}
