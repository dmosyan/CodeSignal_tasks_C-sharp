def makeArrayConsecutive2(statues):
    statues.sort()
    number_of_additional_statues = 0
    a =  max(statues) - min(statues) + 1 - len(statues)
    return a
