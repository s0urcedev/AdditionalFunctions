#include <iostream>
using namespace std;

int main(){
    int len;
    cin >> len;
    int a[len];
    for(int i = 0; i < len; i ++){
        cin >> a[i];
    }
    int k = 0;
    while(k < len - 1){
        k = 0;
        for(int j = 0; j < len - 1; j ++){
            if(a[j] > a[j+1]){
                a[j] = a[j] + a[j+1];
                a[j+1] = a[j] - a[j+1];
                a[j] = a[j] - a[j+1];
            }
            else{
                k ++;
            }
        }
    }
    for(int i = 0; i < len; i ++){
        cout << a[i] << " ";
    }
}