bool isInfiniteProcess(int a, int b) 
{
    if(a>b)
        return true;
    if((b-a)%2 ==0)
        return false;
    else
        return true;
}
