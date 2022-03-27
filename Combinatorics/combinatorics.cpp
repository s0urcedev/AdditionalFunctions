#include <iostream>
#include <vector>
#include <iterator>
using namespace std;

int factorial(int n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

int count_combinations(int n, int k){
    return factorial(n) / (factorial(k) * factorial(n - k));
}

int count_permutations(int n, int k){
    return factorial(n) / factorial(n - k);
}

vector <vector <int>> generate_combinations(vector <int> arr, int k){
    vector <vector <int>> result;
    for(int i = 0; i < count_combinations(arr.size(), k); i ++){
        vector <int> local_result(1, 0);
        int n = arr.size();
        int s = 0;
        for(int j = 1; j <= k; j++){
            int t = local_result[j - 1] + 1;
            while((t < (n - k + j)) && ((s + count_combinations(n - t, k - j) <= i))){
                s += count_combinations(n - t, k - j);
                t ++;
            }
            local_result.push_back(t);
        }
        for(int l = 1; l < local_result.size(); l ++){
            local_result[l] = arr[local_result[l] - 1];
        }
        result.push_back(vector <int>(local_result.begin() + 1, local_result.end()));
    }
    return result;
}

vector <vector <int>> generate_permutations(vector <int> arr, int k){
    vector <vector <int>> result;
    vector <vector <int>> m = generate_combinations(arr, k);
    for(auto a: m){
        vector <vector <int>> local_result;
        for(int i = 0; i < factorial(a.size()); i ++){
            int ind = i + 1;
            vector <int> local_local_result;
            vector <int> local_local_arr;
            for(auto r: a){
                local_local_arr.push_back(r);
            }
            int n = local_local_arr.size();
            for(int j = 1; j <= n; j ++){
                int f = factorial(n - j);
                int g = (ind + f - 1) / f;
                local_local_result.push_back(local_local_arr[g - 1]);
                auto iter = local_local_arr.cbegin();
                local_local_arr.erase(iter + g - 1);
                ind -= (g - 1) * f;
            }
            if(local_local_arr.size()){
                local_local_result.push_back(local_local_arr[0]);
            }
            local_result.push_back(local_local_result);
        }
        for(auto u: local_result){
            result.push_back(u);
        }
    }
    return result;
}

void print(vector <vector <int>> const &input)
{
    cout << "{ ";
    for(auto i: input){
        cout << "{ ";
        for(auto j: i){
            cout << j << ' ';
        }
        cout << "}";
    }
    cout << " }" << endl;
}

int main(){
    return 0;
}