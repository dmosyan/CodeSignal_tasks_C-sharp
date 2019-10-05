int mirrorBits(int a) 
{
    int mirrored = 0;
    while(a != 0)
    {
        mirrored <<= 1;
        mirrored |= (a & 1);
        a >>= 1;
    }
    return mirrored;
    
}
    

