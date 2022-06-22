#include <iostream>
using namespace std;

void heapify(int *array, int n, int i){
    int largest = i;
    int l = 2 * i + 1;
    int r = 2 * i + 2;
    if(l < n && array[i] < array[l]){
        largest = l;
    }
    if(r < n && array[largest] < array[r]){
        largest = r;
    }
    if(largest != i){
        array[i] = array[i] + array[largest];
        array[largest] = array[i] - array[largest];
        array[i] = array[i] - array[largest];
        heapify(array, n, largest);
    }
}

void sort(int *array, int len){
    for(int i = len / 2; i > -1; i --){
        heapify(array, len, i);
    }
    for(int j = len - 1; j > 0; j --){
        array[j] = array[j] + array[0];
        array[0] = array[j] - array[0];
        array[j] = array[j] - array[0];
        heapify(array, j, 0);
    }
}

int main(){
    int len;
    cin >> len;
    int a[len];
    for(int i = 0; i < len; i ++){
        cin >> a[i];
    }
    sort(a, len);
    for(int i = 0; i < len; i ++){
        cout << a[i] << " ";
    }
}