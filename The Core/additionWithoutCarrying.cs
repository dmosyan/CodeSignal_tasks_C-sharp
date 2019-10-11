int additionWithoutCarrying(int param1, int param2) 
{
    int result = 0;
    int temp = 1;
        while (param1 > 0 || param2 > 0) 
        {
            result += temp * ((param1 + param2) % 10);
            param1 /= 10;
            param2 /= 10;
            temp *= 10;
        }
        return result;
}
