#include <iostream>
#include <vector>

int max_subarray_sum(std::vector <int> arr){
    int result = arr[0];
    int local_result = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        if(local_result > 0){
            local_result += arr[i];
        }
        else{
            local_result = arr[i];
        }
        if(local_result > result){
            result = local_result;
        }
    }
    return result;
}

int min_subarray_sum(std::vector <int> arr){
    int result = arr[0];
    int local_result = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        if(local_result < 0){
            local_result += arr[i];
        }
        else{
            local_result = arr[i];
        }
        if(local_result < result){
            result = local_result;
        }
    }
    return result;
}

int max_subarray_prod(std::vector <int> arr){
    int result = arr[0];
    int local_result_pos = arr[0];
    int local_result_neg = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        int local_result_max, local_result_min;
        if(local_result_pos * arr[i] > local_result_neg * arr[i]){
            local_result_max = local_result_pos * arr[i];
            local_result_min = local_result_neg * arr[i];
        }
        else{
            local_result_max = local_result_neg * arr[i];
            local_result_min = local_result_pos * arr[i];
        }
        if(arr[i] > local_result_max){
            local_result_pos = arr[i];
        }
        else{
            local_result_pos = local_result_max;
        }
        if(arr[i] < local_result_min){
            local_result_neg = arr[i];
        }
        else{
            local_result_neg = local_result_min;
        }
        if(local_result_pos > result){
            result = local_result_pos;
        }
    }
    return result;
}

int min_subarray_prod(std::vector <int> arr){
    int result = arr[0];
    int local_result_pos = arr[0];
    int local_result_neg = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        int local_result_max, local_result_min;
        if(local_result_pos * arr[i] > local_result_neg * arr[i]){
            local_result_max = local_result_pos * arr[i];
            local_result_min = local_result_neg * arr[i];
        }
        else{
            local_result_max = local_result_neg * arr[i];
            local_result_min = local_result_pos * arr[i];
        }
        if(arr[i] > local_result_max){
            local_result_pos = arr[i];
        }
        else{
            local_result_pos = local_result_max;
        }
        if(arr[i] < local_result_min){
            local_result_neg = arr[i];
        }
        else{
            local_result_neg = local_result_min;
        }
        if(local_result_neg < result){
            result = local_result_neg;
        }
    }
    return result;
}

int max_circular_subarray_sum(std::vector <int> arr){
    int max_elem = arr[0];
    int arr_sum = 0;
    for(int i = 0; i < arr.size(); i ++){
        if(arr[i] > max_elem){
            max_elem = arr[i];
        }
        arr_sum += arr[i];
    }
    if(max_elem < 0){
        return max_elem;
    }
    int max_simple_sum = max_subarray_sum(arr);
    int max_circle_sum = arr_sum - min_subarray_sum(arr);
    if(max_simple_sum > max_circle_sum){
        return max_simple_sum;
    }
    else{
        return max_circle_sum;
    }
}

int min_circular_subarray_sum(std::vector <int> arr){
    int min_elem = arr[0];
    int arr_sum = 0;
    for(int i = 0; i < arr.size(); i ++){
        if(arr[i] < min_elem){
            min_elem = arr[i];
        }
        arr_sum += arr[i];
    }
    if(min_elem > 0){
        return min_elem;
    }
    int min_simple_sum = min_subarray_sum(arr);
    int min_circle_sum = arr_sum - max_subarray_sum(arr);
    if(min_simple_sum < min_circle_sum){
        return min_simple_sum;
    }
    else{
        return min_circle_sum;
    }
}