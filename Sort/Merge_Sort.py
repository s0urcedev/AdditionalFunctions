def sort(Mass, m):
    mass = []
    m = int(m)
    for i in range(0, m):
        mass.append(Mass[i])
    if m <= 1:
        Mass[0] = mass[0]
    else:
        l = []
        r = []
        for i in range(0, m):
            if i < m/2:
                l.append(mass[i])
            else:
                r.append(mass[i])
        sort(l, m/2)
        sort(r, m - (m/2))
        h = 0
        f = 0
        c = []
        while h < m/2 and f < m - (m/2):
            if l[h] < r[f]:
                c.append(l[h])
                h += 1
            else:
                c.append(r[f])
                f += 1
        while h < m/2:
            c.append(l[h])
            h += 1
        while f < m - (m/2):
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