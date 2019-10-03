int[] metroCard(int lastNumberOfDays) 
{
    if (lastNumberOfDays == 30 || lastNumberOfDays == 28)
        return new []{31};
    
    if (lastNumberOfDays == 31)
        return new []{28,30,31};
    else 
        throw new ArgumentOutOfRangeException();  
}
