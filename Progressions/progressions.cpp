#include <iostream>
#include <vector>
#include <math.h>


class ArithmeticProgression{

    private:
    
        int d_ = 0;
        std::vector <int> a_;

    public:

        void create(int start = 0, int d = 0){
            a_.push_back(start);
            d_ = d;
        }
        
        std::vector <int> get_sequence(){
            return a_;
        }
        
        int get_difference(){
            return d_;
        }
        
        void set_start_element(int start){
            a_.clear();
            a_.push_back(start);
        }
        
        void set_difference(int d){
            int start = a_[0];
            a_.clear();
            a_.push_back(start);
            d_ = d;
        }

        int get_nth(int n){
            return a_[0] + (n - 1) * d_;
        }

        void count_to_nth(int n){
            for(int _ = a_.size(); _ < n; _ ++){
                a_.push_back(a_[a_.size() - 1] + d_);
            }
        }

        std::vector <int> get_to_nth(int n){
            count_to_nth(n);
            return a_;
        }

        int get_sum_to_nth(int n){
            return n * (a_[0] + get_nth(n)) / 2;
        }
};


class GeometricProgression{

    private:
    
        int r_ = 1;
        std::vector <int> b_;
    
    public:

        void create(int start = 1, int r = 1){
            if(start == 0 || r == 0){
                std::cout << "start_element or ratio can't be 0" << std::endl;
                return;
            }
            b_.push_back(start);
            r_ = r;
        }
        
        std::vector <int> get_sequence(){
            return b_;
        }
        
        int get_ratio(){
            return r_;
        }
        
        void set_start_element(int start){
            if(start == 0){
                std::cout << "start_element can't be 0" << std::endl;
                return; 
            }
            b_.clear();
            b_.push_back(start);
        }

        void set_ratio(int r){
            if(r == 0){
                std::cout << "ratio can't be 0" << std::endl;
                return; 
            }
            int start = b_[0];
            b_.clear();
            b_.push_back(start);
            r_ = r;
        }

        int get_nth(int n){
            return b_[0] * std::pow(r_, n - 1);
        }

        void count_to_nth(int n){
            for(int _ = b_.size(); _ < n; _ ++){
                b_.push_back(b_[b_.size() - 1] * r_);
            }
        }

        std::vector <int> get_to_nth(int n){
            count_to_nth(n);
            return b_;
        }

        int get_sum_to_nth(int n){
            if(r_ == 1) return n * b_[0];
            return (b_[0] * (std::pow(r_, n) - 1)) / (r_ - 1);
        }
};

class HarmonicProgression{

    private:
    
        int d_ = 0;
        std::vector <float> c_;
    
    public:
        
        void create(float start = 1.0, int d = 0){
            c_.push_back(start);
            d_ = d;
        }
        
        std::vector <float> get_sequence(){
            return c_;
        }
        
        int get_difference(){
            return d_;
        }
        
        void set_start_element(float start){
            c_.clear();
            c_.push_back(start);
        }
        
        void set_difference(int d){
            float start = c_[0];
            c_.clear();
            c_.push_back(start);
            d_ = d;
        }

        float get_nth(int n){
            return std::pow((std::pow(c_[0], -1) + (n - 1) * d_), -1);
        }

        void count_to_nth(int n){
            for(int _ = c_.size(); _ < n; _ ++){
                c_.push_back(std::pow((std::pow(c_[c_.size() - 1], -1) + d_), -1));
            }
        }

        std::vector <float> get_to_nth(int n){
            count_to_nth(n);
            return c_;
        }
};