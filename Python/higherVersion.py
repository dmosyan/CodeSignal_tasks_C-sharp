def higherVersion(ver1, ver2):
    v1 = ver1.split(".")
    v2 = ver2.split(".")

    for i in range(0,len(v1)):
        if int(v1[i])>int(v2[i]):
            return True
        elif int(v1[i])<int(v2[i]):
            return False
            
    return False
