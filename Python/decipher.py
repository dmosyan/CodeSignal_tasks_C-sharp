def decipher(cipher):
    decipher = []
    while cipher:
        if cipher[0]=='9':
            decipher.append(cipher[0:2])
            cipher = cipher[2:]
        else:
            decipher.append(cipher[0:3])
            cipher = cipher[3:]
    
    for i in range(0,len(decipher)):
        decipher[i] = chr(int(decipher[i]))
    
    return "".join(decipher)

