int rangeBitCount(int a, int b) 
{
    int count = 0;
    int step;
    for(; a <= b; a++)
    {
        step = a;
        while(step > 0)
        {
            if(step % 2 == 1)
            {
                count++;
            }
            step /= 2;
        }
    }
    
     return count;
    
}
