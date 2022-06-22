#include <iostream>
using namespace std;

int main(){
    int len;
    cin >> len;
    int a[len];
    for(int i = 0; i < len; i ++){
        cin >> a[i];
    }
    for(int j = 1; j < len; j ++){
        int key = a[j];
        int i = j - 1;
        while (i >= 0 && a[i] > key){
            a[i + 1] = a[i];
            i --;
        }
        a[i + 1] = key;
    }
    for(int i = 0; i < len; i ++){
        cout << a[i] << " ";
    }
}