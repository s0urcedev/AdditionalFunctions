#include <iostream>
#include <cmath>
#include <vector>
using namespace std;

template <typename T>

class HashTable{

    private:

        int size_;
        vector<T> table_;

        bool isprime_(int n){
            vector<int> result;
            int d = 2;
            while(d * d <= n){
                if(n % d == 0){
                    result.push_back(d);
                    n = n / d;
                }
                else{
                    d ++;
                }
            }
            if(n > 1){
                result.push_back(n);
            }
            if(result.size() > 1) return false;
            else return true;
        }

        int nearest_prime_(int n){
            if(n % 2 == 0){
                n += 1;
            }
            while(!isprime_(n)){
                n += 2;
            }
            return n;
        }

        int count_hash_(string s){
            int n = 7;
            for(auto c: s){
                n = n * 31 + (c + 0);
            }
            return (size_ * (n * ((sqrt(5) - 1) / 2) - floor(n * ((sqrt(5) - 1) / 2))));
        }

    public:

        HashTable(int size){
            size_ = nearest_prime_(size);
            table_ = vector<T>(size_);
            T def;
            for(int i = 0; i < size_; i ++){
                table_[i] = def;
            }
        }

        T search(string key){
            return table_[count_hash_(key)];
        }

        void insert(string key, T value){
            table_[count_hash_(key)] = value;
        }

        void remove(string key){
            T def;
            table_[count_hash_(key)] = def;
        }

};

int main(){
}