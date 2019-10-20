bool isSumOfConsecutive(int n) 
{
    for (int i = 1; i < n; i++) 
    {    
        for (int j = 1; j < n; j++) 
        {
            int sum = 0;
            for (int k = i; k < i + j; k++) sum+= k;
            if (sum == n)
            {
                return true;
            }
        }
        
    }
    return false;
}
