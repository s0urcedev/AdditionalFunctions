def addition_big_numbers(a, b):
    a = str(a)[::-1]
    b = str(b)[::-1]

    while(len(b) < len(a)):
        b += '0'
    while(len(a) < len(b)):
        a += '0'

    result = ''
    c = 0
    for i in range(0, len(a)):
        local_result = int(a[i]) + int(b[i]) + c
        c = 0
        if local_result > 9:
            local_result -= 10
            c = 1
        result += str(local_result)
    if c == 1:
        result += '1'
    return result[::-1]

def subtraction_big_numbers(a, b):
    k = False
    if int(a) > int(b):
        a = str(a)[::-1]
        b = str(b)[::-1]
    else:
        k = True
        swap = str(a)[::-1]
        a = str(b)[::-1]
        b = swap
    while(len(b) < len(a)):
        b += '0'
    while(len(a) < len(b)):
        a += '0'

    result = ''
    c = 0
    for i in range(0, len(a)):
        local_result = int(a[i]) - int(b[i]) - c
        c = 0
        if local_result < 0:
            local_result += 10
            c = 1
        result += str(local_result)

    if k:
        result += '-'
    while result[-1] == '0':
        result = result[:-1]
    return result[::-1]

def multiplication_big_numbers(a, b):
    a = str(a)[::-1]
    b = str(b)[::-1]

    result = ''
    c = 0
    for i in range(0, len(b)):
        local_result = ''
        c = 0
        for j in range(0, len(a)):
            local_local_result = int(a[j]) * int(b[i]) + c
            c = 0
            while local_local_result > 9:
                local_local_result -= 10
                c += 1
            local_result += str(local_local_result)
        if c > 0:
            local_result += str(c)
            c = 0
        result = addition_big_numbers(str(result), str(local_result)[::-1] + ('0' * i))
    return result