#include <iostream>
using namespace std;

int binary_search(int *arr, int len, int value){
    int first = 0;
    int last = len - 1;
    int middle;
    while(first <= last){
        middle = (first + last) / 2;
        if(value < arr[middle]){
            last = middle - 1;
        }
        else if(value > arr[middle]){
            first = middle + 1;
        }
        else{
            return middle;
        }
    }
    return -1;
}

int main(){

}