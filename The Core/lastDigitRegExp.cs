char lastDigitRegExp(string inputString) 
{
    for (int i = inputString.Length - 1; i >= 0; i--) 
    {
        if ('0' <= inputString[i] && inputString[i] <= '9')
        return inputString[i];
    }
    return ' ';
}
