def rom_arab(p):
    z = 0
    try:
        p = str(p).lower()
        for i in range(0, len(p)):
            if p[i] == 'i':
                try:
                    if p[i+1] == 'v' or p[i+1] == 'x': 
                        z -= 1
                    else:
                        z += 1
                except:
                    z += 1
            elif p[i] == 'v':
                z += 5
            elif p[i] == 'x':
                try:
                    if p[i+1] == 'c' or p[i+1] == 'l': 
                        z -= 10
                    else:
                        z += 10
                except:
                    z += 10
            elif p[i] == 'l':
                z += 50
            elif p[i] == 'c':
                try:
                    if p[i+1] == 'm' or p[i+1] == 'd': 
                        z -= 100
                    else:
                        z += 100
                except:
                    z += 100
            elif p[i] == 'd':
                z += 500
            elif p[i] == 'm':
                z += 1000
            else:
                return None
    except:
        return None
    return z

def arab_rom(s):
    v = ""
    try:
        s = int(s)
        while s > 0:
            if s >= 1000:
                s -= 1000
                v += "M"
            elif s >= 900:
                s -= 900
                v += "CM"
            elif s >= 500:
                s -= 500
                v += "D"
            elif s >= 400:
                s -= 400
                v += "CD"
            elif s >= 100:
                s -= 100
                v += "C"
            elif s >= 90:
                s -= 90
                v += "XC"
            elif s >= 50:
                s -= 50
                v += "L"
            elif s >= 40:
                s -= 40
                v += "XL"
            elif s >= 10:
                s -= 10
                v += "X"
            elif s >= 9:
                s -= 9 
                v += "IX"
            elif s >= 5:
                s -= 5
                v += "V"
            elif s >= 4:
                s -= 4
                v += "IV"
            elif s >= 1:
                s -= 1
                v += "I"
    except:
        return None
    return v