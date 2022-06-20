a = []
s = input()

for i in s.split(' '):
    a.append(int(i))

for i in range(0, len(a) - 1):
    imin = i
    for j in range(i + 1, len(a)):
        if a[j] < a[imin]:
            imin = j
    if imin != i:
        a[i] = a[i] + a[imin]
        a[imin] = a[i] - a[imin]
        a[i] = a[i] - a[imin]

print(a)