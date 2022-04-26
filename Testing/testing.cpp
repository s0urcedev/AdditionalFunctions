#include <iostream>
#include <vector>

#define type int //choose your function type
#define arg_type int // choose your arguments type

class Test{

    private:

        type (*func_)(arg_type) = NULL;
        std::vector <arg_type> params_ = {};
        std::vector <type> results_ = {};

    public:

        void set_func(type (*func)(arg_type)){
            func_ = func;
        }

        bool test(type (*func)(arg_type), arg_type param, type result){
            return func(param) == result;
        }

        bool test(arg_type param, type result){
            if(func_ == NULL){
                std::cout << "No function set" << std::endl;
                return false;
            }
            return func_(param) == result;
        }

        void add_test_cases(arg_type param, type result){
            params_.push_back(param);
            results_.push_back(result);
        }

        void show_test_cases(){
            if(params_.size() == 0){
                std::cout << "No test cases" << std::endl;
            }
            for(int i = 0; i < params_.size(); i ++){
                std::cout << "Arguments: " << params_[i] << ", Correct result: " << results_[i] << std::endl;
            }
        }

        void clear_test_cases(){
            params_.clear();
            results_.clear();
        }

        bool test_all(){
            if(func_ == NULL){
                std::cout << "No function set" << std::endl;
                return false;
            }
            for(int i = 0; i < params_.size(); i ++){
                if(func_(params_[i]) != results_[i]){
                    return false;
                }
            }
            return true;
        }

        void print_results(){
            if(func_ == NULL){
                std::cout << "No function set" << std::endl;
                return;
            }
            int totaly_valid = 0;
            int totaly_invalid = 0;
            for(int i = 0; i < params_.size(); i ++){
                std::cout << "Arguments: " << params_[i] << ", Correct result: " << results_[i] << ", Desicion: ";
                if(func_(params_[i]) != results_[i]){
                    std::cout << "INVALID" << std::endl;
                    totaly_invalid ++;
                }
                else{
                    std::cout << "VALID" << std::endl;
                    totaly_valid ++;
                }
            }
            std::cout << "Totaly: " << totaly_valid << " Valid, " << totaly_invalid << " INVALID" << std::endl;
        }
};