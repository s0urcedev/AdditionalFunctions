#include <iostream>
#include <string>
#include <sstream>
using namespace std;

string addition_big_numbers(string a, string b){
    while(b.length() < a.length()){
        b = "0" + b;
    }
    while(a.length() < b.length()){
        a = "0" + a;
    }
    string result = "";
    int c = 0;
    for(int i = a.length() - 1; i >= 0; i --){
        int local_result = (a[i] - 48) + (b[i] - 48) + c;
        c = 0;
        if(local_result > 9){
            local_result -= 10;
            c = 1;
        }
        result += to_string(local_result);
    }
    if(c == 1){
        result += "1";
    }
    string fresult = "";
    for(auto s: result){
        fresult = s + fresult;
    }
    return fresult;
}

string substraction_big_numbers(string a, string b){
    stringstream ssa;
    ssa << a;
    long long n = 0;
    ssa >> n;
    stringstream ssb;
    ssb << b;
    long long m = 0;
    ssb >> m;
    bool k = false;
    if(n < m){
        k = true;
        string swap = a;
        a = b;
        b = swap;
    }
    while(b.length() < a.length()){
        b = "0" + b;
    }
    while(a.length() < b.length()){
        a = "0" + a;
    }
    string result = "";
    int c = 0;
    for(int i = a.length() - 1; i >= 0; i --){
        int local_result = (a[i] - 48) - (b[i] - 48) - c;
        c = 0;
        if(local_result < 0){
            local_result += 10;
            c = 1;
        }
        result += to_string(local_result);
    }
    if(c == 1){
        result += "1";
    }
    while(result[result.length() - 1] == '0'){
        result = result.substr(0, result.length() - 1);
    }
    string fresult = "";
    for(auto s: result){
        fresult = s + fresult;
    }
    if(k){
        fresult = '-' + fresult;
    }
    return fresult;
}

string multiplication_big_numbers(string a, string b){
    string result = "";
    int c = 0;
    for(int i = b.length() - 1; i >= 0; i --){
        string local_result = "";
        c = 0;
        for(int j = a.length() - 1; j >= 0; j --){
            int local_local_result = (a[j] - 48) * (b[i] - 48) + c;
            c = 0;
            while(local_local_result > 9){
                local_local_result -= 10;
                c += 1;
            }
            local_result += to_string(local_local_result);
        }
        if(c > 0){
            local_result += to_string(c);
            c = 0;
        }
        string flocal_result = "";
        for(auto s: local_result){
            flocal_result = s + flocal_result;
        }
        for(int f = 0; f < b.length() - i - 1; f ++){
            flocal_result += "0";
        }
        result = addition_big_numbers(result, flocal_result);
    }
    return result;
}

int main(){
    cout << substraction_big_numbers("762055", "2229849264") << endl;
    system("pause");
}