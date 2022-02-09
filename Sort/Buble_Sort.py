a = []
s = input()

for i in s.split(' '):
    a.append(int(i))

k = 0
while k < len(a) - 1:
    k = 0
    for j in range(0, len(a)-1):
        if a[j] > a[j+1]:
            a[j] = a[j] + a[j+1]
            a[j+1] = a[j] - a[j+1]
            a[j] = a[j] - a[j+1]
        else:
            k += 1

print(a)