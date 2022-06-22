def heapify(array, n, i):
    largest = i
    l = 2 * i + 1
    r = 2 * i + 2
    if l < n and array[i] < array[l]:
        largest = l
    if r < n and array[largest] < array[r]:
        largest = r
    if largest != i:
        array[i], array[largest] = array[largest], array[i]
        heapify(array, n, largest)

def sort(array):
    for i in range(len(array) // 2, -1, -1):
        heapify(array, len(array), i)
    for j in range(len(array) - 1, 0, -1):
        array[j], array[0] = array[0], array[j]
        heapify(array, j, 0)

a = []
s = input()

for i in s.split(' '):
    a.append(int(i))

sort(a)

print(a)