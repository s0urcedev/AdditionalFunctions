from additional_functions import combinatorics as comb
from additional_functions import factorials as fact

def generate_combinations(arr, k = None):
    if(k == None):
        k = 1
    result = []
    for i in range(0, comb.combinations(len(arr), k)):
        local_result = [0]
        n = len(arr)
        s = 0
        for j in range(1,k+1):
            t = local_result[j - 1] + 1;
            while (t < (n - k + j)) and ((s + comb.combinations(n - t, k - j)) <= i):
                s += comb.combinations(n - t, k - j)
                t += 1  
            local_result.append(t)
        for l in range(0, len(local_result)):
            local_result[l] = arr[local_result[l] - 1]
        result.append(local_result[1:])
    return result

def generate_permutations(arr, k = None):
    if(k == None):
        k = len(arr)
    result = []
    m = generate_combinations(arr, k)
    for arr in m:
        local_result = []
        for i in range(0, fact.factorial(len(arr))):
            ind = i + 1
            local_local_result = []
            local_local_arr = []
            for a in arr:
                local_local_arr.append(a)
            n = len(local_local_arr)
            for j in range(1, n + 1):
                f = fact.factorial(n - j)
                g = int((ind + f - 1) / f)
                local_local_result.append(local_local_arr.pop(g - 1))
                ind -= (g - 1) * f
            if len(local_local_arr):
                local_local_result.append(local_local_arr[0])
            local_result.append(local_local_result)
        for u in local_result:
            result.append(u)
    return result
