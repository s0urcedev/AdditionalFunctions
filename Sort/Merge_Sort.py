def sort(Mass, m):
    mass = []
    for i in range(0, m):
        mass.append(Mass[i])
    if m <= 1:
        Mass[0] = mass[0]
    else:
        l = []
        r = []
        for i in range(0, m):
            if i < int(m/2):
                l.append(mass[i])
            else:
                r.append(mass[i])
        sort(l, len(l))
        sort(r, len(r))
        h = 0
        f = 0
        c = []
        while h < len(l) and f < len(r):
            if l[h] < r[f]:
                c.append(l[h])
                h += 1
            else:
                c.append(r[f])
                f += 1
        while h < len(l):
            c.append(l[h])
            h += 1
        while f < len(r):
            c.append(r[f])
            f += 1
        for i in range(0, m):
            Mass[i] = c[i]

a = []
s = input()

for i in s.split(' '):
    a.append(int(i))

sort(a, len(a))

print(a)