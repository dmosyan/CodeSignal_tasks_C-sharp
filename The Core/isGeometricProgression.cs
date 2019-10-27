bool isGeometricProgression(int[] sequence) 
{
    Array.Sort(sequence);
    int prog = sequence[1] / sequence[0];
    for (int i = 2; i < sequence.Length; i++)
    {
        if (sequence[i] / sequence[i - 1] != prog || sequence[i] % sequence[i - 1] != 0)
            return false;
    }
    return true;
}
