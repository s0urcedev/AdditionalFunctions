#include <iostream>
using namespace std;

void sort(int *array, int b, int e){
    int l = b;
    int r = e;
    int p = array[(l + r) / 2];
    while(l <= r){
        while(array[l] < p){
            l ++;
        }
        while(array[r] > p){
            r --;
        }
        if(l <= r){
            if(l < r){
                array[l] = array[l] + array[r];
                array[r] = array[l] - array[r];
                array[l] = array[l] - array[r];
            }
            l ++;
            r --;
        }
    }
    if(b < r){
        sort(array, b, r);
    }
    if(e > l){
        sort(array, l, e);
    }
}

int main(){
    int len;
    cin >> len;
    int a[len];
    for(int i = 0; i < len; i ++){
        cin >> a[i];
    }
    sort(a, 0, len - 1);
    for(int i = 0; i < len; i ++){
        cout << a[i] << " ";
    }
}