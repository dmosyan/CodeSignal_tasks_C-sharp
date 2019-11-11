int countBlackCells(int n, int m) 
{
    int answer = 0;
    for (int x = 1; x <= n; x++) 
    {
        int L = (int) (m * 1L * (x - 1) / n);
        if (m * 1L * (x - 1) % n == 0) 
    {
            L--;
    }
    int R = (int) (m * 1L * x / n);
    L = Math.Max(0, L);
    R = Math.Min(R, m - 1);
    answer += R - L + 1;
    }
    return answer;
}
