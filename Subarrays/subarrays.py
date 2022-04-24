def max_subarray_sum(arr):
    result = arr[0]
    local_result = arr[0]
    for i in range(1, len(arr)):
        if local_result > 0:
            local_result += arr[i]
        else:
            local_result = arr[i]
        if local_result > result:
            result = local_result
    return result

def min_subarray_sum(arr):
    result = arr[0]
    local_result = arr[0]
    for i in range(1, len(arr)):
        if local_result < 0:
            local_result += arr[i]
        else:
            local_result = arr[i]
        if local_result < result:
            result = local_result
    return result

def max_subarray_prod(arr):
    result = arr[0]
    local_result_pos = arr[0]
    local_result_neg = arr[0]
    for i in range(1, len(arr)):
        if local_result_pos * arr[i] > local_result_neg * arr[i]:
            local_result_max = local_result_pos * arr[i]
            local_result_min = local_result_neg * arr[i]
        else:
            local_result_max = local_result_neg * arr[i]
            local_result_min = local_result_pos * arr[i]
        if arr[i] > local_result_max:
            local_result_pos = arr[i]
        else:
            local_result_pos = local_result_max
        if arr[i] < local_result_min:
            local_result_neg = arr[i]
        else:
            local_result_neg = local_result_min
        if local_result_pos > result:
            result = local_result_pos
    return result
        
def min_subarray_prod(arr):
    result = arr[0]
    local_result_pos = arr[0]
    local_result_neg = arr[0]
    for i in range(1, len(arr)):
        if local_result_pos * arr[i] > local_result_neg * arr[i]:
            local_result_max = local_result_pos * arr[i]
            local_result_min = local_result_neg * arr[i]
        else:
            local_result_max = local_result_neg * arr[i]
            local_result_min = local_result_pos * arr[i]
        if arr[i] > local_result_max:
            local_result_pos = arr[i]
        else:
            local_result_pos = local_result_max
        if arr[i] < local_result_min:
            local_result_neg = arr[i]
        else:
            local_result_neg = local_result_min
        if local_result_neg < result:
            result = local_result_neg
    return result

def max_circular_subarray_sum(arr):
    max_elem = arr[0]
    arr_sum = 0
    for i in range(0, len(arr)):
        if arr[i] > max_elem:
            max_elem = arr[i]
        arr_sum += arr[i]
    if max_elem < 0:
        return max_elem
    max_simple_sum = max_subarray_sum(arr)
    max_cicle_sum = arr_sum - min_subarray_sum(arr)
    if max_simple_sum > max_cicle_sum:
        return max_simple_sum
    else:
        return max_cicle_sum

def min_circular_subarray_sum(arr):
    min_elem = arr[0]
    arr_sum = 0
    for i in range(0, len(arr)):
        if arr[i] < min_elem:
            min_elem = arr[i]
        arr_sum += arr[i]
    if min_elem > 0:
        return min_elem
    min_simple_sum = min_subarray_sum(arr)
    min_cicle_sum = arr_sum - max_subarray_sum(arr)
    if min_simple_sum < min_cicle_sum:
        return min_simple_sum
    else:
        return min_cicle_sum