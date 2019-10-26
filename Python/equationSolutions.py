def equationSolutions(l, r):
    
    count = 0;
    for A in range(l, r+1):
        B = min(A+1, l)
        while B <= r:
            if A*A*A == B*B:
                count +=1
            B+=1
    return count

