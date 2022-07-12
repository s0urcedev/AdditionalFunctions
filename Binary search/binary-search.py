def binary_search(arr, value):
    first = 0
    last = len(arr) - 1
    while first <= last:
        middle = (first + last) // 2
        if value < arr[middle]:
            last = middle - 1
        elif value > arr[middle]:
            first = middle + 1
        else:
            return middle
    return -1