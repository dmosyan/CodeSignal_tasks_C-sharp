//Given an integer n, return the largest number that contains exactly n digits.
//Example
//For n = 2, the output should be
//largestNumber(n) = 99

int largestNumber(int n)
{
    return (int)Math.Pow(10,n)-1;
}
