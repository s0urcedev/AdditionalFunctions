def sort(array, b, e):
    l = b
    r = e
    p = array[int((l + r) / 2)]
    while l <= r:
        while array[l] < p:
            l += 1
        while array[r] > p:
            r -= 1
        if l <= r:
            if l < r:
                array[l], array[r] = array[r], array[l]
            l += 1
            r -= 1
    if b < r:
        sort(array, b, r)
    if e > l:
        sort(array, l, e)

a = []
s = input()

for i in s.split(' '):
    a.append(int(i))


sort(a, 0, len(a) - 1)

print(a)