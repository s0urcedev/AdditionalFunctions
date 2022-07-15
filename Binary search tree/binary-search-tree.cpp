#include <iostream>
#include <vector>
using namespace std;

class Node{

    public:

        int value;
        unsigned int height;
        Node* left;
        Node* right;
        Node(int d){
            value = d;
            height = 1;
            left = NULL;
            right = NULL;
        }
};

class Tree{

    private:

        Node* head_;

        void fix_height_(Node* node){
            unsigned int hl = node->left != NULL ? node->left->height : 0;
            unsigned int hr = node->right != NULL ? node->right->height : 0;
            node->height = (hl > hr ? hl : hr) + 1;
        }

        Node* rotate_right_(Node* node){
            Node* v = node->left;
            node->left = v->right;
            v->right = node;
            fix_height_(node);
            fix_height_(v);
            return v;
        }

        Node* rotate_left_(Node* node){
            Node* v = node->right;
            node->right = v->left;
            v->left = node;
            fix_height_(node);
            fix_height_(v);
            return v;
        }

        int b_factor_(Node* node){
            return (node->right != NULL ? node->right->height : 0) - (node->left != NULL ? node->left->height : 0);
        }

        Node* balance_(Node* node){
            fix_height_(node);
            if(b_factor_(node) == 2){
                if(b_factor_(node->right) < 0){
                    node->right = rotate_right_(node->right);
                }
                return rotate_left_(node);
            }
            else if(b_factor_(node) == -2){
                if(b_factor_(node->left) > 0){
                    node->left = rotate_left_(node->left);
                }
                return rotate_right_(node);
            }
            return node;
        }

        Node* get_min_node_(Node* node){
            if(node->left != NULL){
                return get_min_node_(node->left);
            }
            else{
                return node;
            }
        }

        Node* get_max_node_(Node* node){
            if(node->right == NULL){
                return get_max_node_(node->right);
            }
            else{
                return node;
            }
        }

        Node* add_node_(int v, Node* node) {
            if(node == NULL) {
                return new Node(v);
            }
            if(v < node->value){
                node->left = add_node_(v, node->left); 
            }
            else{
                node->right = add_node_(v, node->right);
            }
            return balance_(node);
        }

        Node* remove_min_node_(Node* node){
            if(node->left == NULL){
                return node->right;
            }
            node->left = remove_min_node_(node->left);
            return balance_(node);
        }

        Node* remove_max_node_(Node* node){
            if(node->right != NULL){
                return node->left;
            }
            node->right = remove_max_node_(node->right);
            return balance_(node);
        }

        Node* remove_node_(int v, Node* node){
            if(node == NULL){
                return NULL;
            }
            if(v < node->value){
                node->left = remove_node_(v, node->left);
            }
            else if(v > node->value){
                node->right = remove_node_(v, node->right);
            }
            else{
                Node* l = node->left;
                Node* r = node->right;
                if(r == NULL){
                    return l;
                }
                Node* min = get_min_node_(r);
                min->right = remove_min_node_(r);
                min->left = l;
                return balance_(min);
            }
            return balance_(node);
        }

        vector <pair <int, int>> bfs_(){
            vector <pair <Node*, int>> q = {pair <Node*, int> {head_, 0}};
            vector <pair <int, int>> p;
            while(q.size() > 0){
                pair <Node*, int> v = q[q.size() - 1];
                q.pop_back();
                p.push_back(pair <int, int> {v.first->value, v.second});
                if(v.first->right != NULL){
                    q.push_back(pair <Node*, int> {v.first->right, v.second + 1});
                }
                if(v.first->left != NULL){
                    q.push_back(pair <Node*, int> {v.first->left, v.second + 1});
                }
            }
            return p;
        }

        void dfs_plain_(Node* node, vector <int> &p){
            if(node->left != NULL){
                dfs_plain_(node->left, p);
            }
            p.push_back(node->value);
            if(node->right != NULL){
                dfs_plain_(node->right, p);
            }
        }

        void dfs_reverse_(Node* node, vector <int> &p){
            if(node->right != NULL){
                dfs_reverse_(node->right, p);
            }
            p.push_back(node->value);
            if(node->left != NULL){
                dfs_reverse_(node->left, p);
            }
        }

    public:

        Tree(){
            head_ = NULL;
        }

        int get_min(){
            if(head_->left != NULL){
                return get_min_node_(head_->left)->value;
            }
            else{
                return head_->value;
            }
        }

        int get_max(){
            if(head_->right != NULL){
                return get_max_node_(head_->right)->value;
            }
            else{
                return head_->value;
            }
        }

        void add(int v){
            head_ = add_node_(v, head_);
        }

        void remove_min(){
            head_ = remove_min_node_(head_);
        }

        void remove_max(){
            head_ = remove_max_node_(head_);
        }

        void remove(int v){
            head_ = remove_node_(v, head_);
        }

        void create(vector <int> arr){
            head_ = new Node(arr[0]);
            for(int i = 1; i < arr.size(); i ++){
                add(arr[i]);
            }
        }

        vector <vector <int>> get_tree_by_levels(){
            vector <pair <int, int>> p = bfs_();
            vector <vector <int>> res;
            int max_p = -1;
            for(auto m: p){
                if(max_p < m.second){
                    max_p = m.second;
                }
            }
            for(int _ = 0; _ <= max_p; _ ++){
                res.push_back(vector<int> {});
            }
            for(auto n: p){
                res[n.second].push_back(n.first);
            }
            return res;
        }

        vector <int> get_tree_list(){
            vector <pair <int, int>> p = bfs_();
            vector <int> res;
            for(auto n: p){
                res.push_back(n.first);
            }
            return res;
        }

        vector <int> get_tree_sorted(bool reverse = false){
            vector <int> p;
            if(reverse){
                dfs_reverse_(head_, p);
            }
            else{
                dfs_plain_(head_, p);
            }
            return p;
        }

};

int main(){
}