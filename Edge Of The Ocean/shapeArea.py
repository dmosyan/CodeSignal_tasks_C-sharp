def shapeArea(n):
    # the formula of counting n-polygons is n to the power of 2
    # plus n-1 to the power of 2
    return n**2 + (n-1)**2
