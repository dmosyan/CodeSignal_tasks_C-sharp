def permutationCipher(password, key):
    table = ' '*97+key
    return str(password).translate(table)
