def differentSubstringsTrie(inputString):
    s = set()
    for i in range(len(inputString)):
        for j in range(i+1,len(inputString) + 1):
             s.add(inputString[i:j])
    return len(s)

