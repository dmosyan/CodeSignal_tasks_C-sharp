#What will be the value of RES after the following snippet is executed:

xs = [()]
res = [False] * 2
if xs:
    res[0] = True
if xs[0]:
    res[1] = True

print(res) # [True, False]
