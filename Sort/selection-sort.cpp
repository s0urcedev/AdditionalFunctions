#include <iostream>
using namespace std;

int main(){
    int len;
    cin >> len;
    int a[len];
    for(int i = 0; i < len; i ++){
        cin >> a[i];
    }
    for(int i = 0; i < len - 1; i ++){
        int imin = i;
        for(int j = i + 1; j < len; j ++){
            if(a[j] < a[imin]){
                imin = j;
            }
        }
        if(imin != i){
            a[i] = a[i] + a[imin];
            a[imin] = a[i] - a[imin];
            a[i] = a[i] - a[imin];
        }
    }
    for(int i = 0; i < len; i ++){
        cout << a[i] << " ";
    }
}