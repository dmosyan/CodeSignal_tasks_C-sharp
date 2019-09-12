def newStyleFormatting(s):
    #The re.sub() function in the re module can be used to replace substrings.
    #The syntax for re.sub() is re.sub(pattern,repl,string).
    s = re.sub("%%", "{%}", s)
    s = re.sub("%[sfFeEGgnNxXoOdDcCbB]", "{}", s)
    return re.sub("{%}", "%", s)
