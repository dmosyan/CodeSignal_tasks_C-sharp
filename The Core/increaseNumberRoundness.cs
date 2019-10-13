bool increaseNumberRoundness(int n) 
{
    bool answer = false;
    while(n > 0)
    {
        if(n % 10 == 0 && answer==true)
        {
            return true;
        }
        else if(n % 10 != 0)
        {
            answer = true;
        }
        n /= 10;
    }
    return false;
}

