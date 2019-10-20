int[] robotPath(string instructions, int bound) 
{
    int len = instructions.Length;
    int[] position = new int[] {0,0};
    
    for(int i = 0; i < len; i++)
    {
        if(instructions[i] == 'L')
        {
            position[0] -= 1;
            if(position[0] == bound - (bound*2) - 1)
            {
                position[0] += 1;
            }
        }
        if(instructions[i] == 'U')
        {
            position[1] += 1;
            if(position[1] == bound+1)
            {
                position[1] -= 1;
            }
        }
        if(instructions[i] == 'D')
        {
            position[1] -=1;
            if(position[1] == bound - (bound*2) - 1)
            {
                position[1] += 1;
            }
        }
        if(instructions[i] == 'R')
        {
            position[0] += 1;
            if(position[0] == bound + 1 )
            {
                position[0] -= 1;
            }
        }
    }
    return position;
}
