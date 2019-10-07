int lineUp(string commands) 
{
    int count = 0;
    bool sameDirection = true;
    
    foreach( char i in commands)
    {
        if(i=='L' || i=='R')
        {
            sameDirection = !sameDirection;
        }
        if(sameDirection==true)
        {
            count++;
        }
    }
    return count;
    
}
