#include <iostream>
using namespace std;

void sort(int *array, int m){
    int mass[m];
    for(int i = 0; i < m; i ++){
        mass[i] = array[i];
    }
    if(m <= 1){
        array[0] = mass[0];
    }
    else{
        int L[m / 2], R[m - (m / 2)];
        for(int i = 0; i < m; i ++){
            if(i < m / 2) L[i] = mass[i];
            else R[i - (m / 2)] = mass[i];
        }
        sort(L, m / 2);
        sort(R, m - (m / 2));
        int h = 0, f = 0, k = 0;
        int C[m];
        while(h < m / 2 && f < m - (m / 2)){
            if(L[h] < R[f]){
                C[k] = L[h];
                h ++;
            }
            else{
                C[k] = R[f];
                f ++;
            }
            k ++;
        }
        while(h < m / 2){
            C[k] = L[h];
            h ++;
            k ++;
        }
        while(f < m - (m / 2)){
            C[k] = R[f];
            f ++;
            k ++;
        }
        for(int i = 0; i < m; i ++){
            array[i] = C[i];
        }
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