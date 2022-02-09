a = []
s = input()

for i in s.split(' '):
    a.append(int(i))

for j in range(1, len(a)):
    key = a[j]
    i = j - 1
    while i >= 0 and a[i] > key:
        a[i+1] = a[i]
        i -= 1
    a[i+1] = key

print(a)