#include <iostream>
using namespace std;

void sort(int *Mass, int b, int e){
    int l = b;
    int r = e;
    int p = Mass[(l + r) / 2];
    while(l <= r){
        while(Mass[l] < p){
            l ++;
        }
        while(Mass[r] > p){
            r --;
        }
        if(l <= r){
            if(l < r){
                Mass[l] = Mass[l] + Mass[r];
                Mass[r] = Mass[l] - Mass[r];
                Mass[l] = Mass[l] - Mass[r];
            }
            l ++;
            r --;
        }
    }
    if(b < r){
        sort(Mass, b, r);
    }
    if(e > l){
        sort(Mass, l, e);
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