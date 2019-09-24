def adjacentElementsProduct(inputArray):
    length = len(inputArray)
    new_list = [] 
    for i in range(length-1):
        new_list.append(inputArray[i] * inputArray[i+1])

    return max(new_list)
