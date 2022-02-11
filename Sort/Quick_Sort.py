a = []
s = input()

for i in s.split(' '):
    a.append(int(i))

def sort(Mass, b, e):
    l = b
    r = e
    p = Mass[int((l + r) / 2)]
    while l <= r:
        while Mass[l] < p:
            l += 1
        while Mass[r] > p:
            r -= 1
        if l <= r:
            if l < r:
                Mass[l] = Mass[l] + Mass[r]
                Mass[r] = Mass[l] - Mass[r]
                Mass[l] = Mass[l] - Mass[r]
            l += 1
            r -= 1
    if b < r:
        sort(Mass, b, r)
    if e > l:
        sort(Mass, l, e)

sort(a, 0, len(a) - 1)

print(a)