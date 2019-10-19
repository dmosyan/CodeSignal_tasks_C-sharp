def findSquareSide(x, y):
    dist = []
    for i in range(len(x)-1):
        dist.append((y[i-1]-y[i])**2+(x[i-1]-x[i])**2)
    
    return min(dist)
