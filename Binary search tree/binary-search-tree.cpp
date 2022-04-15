#include <iostream>
#include <vector>

class Node{

    public:

        int value;
        Node* left;
        Node* right;
        Node(int d){
            value = d;
            left = NULL;
            right = NULL;
        }
};

class Tree{

    private:

        Node* head_;

        std::vector <std::pair <int, int>> bfs_(){
            std::vector <std::pair <Node*, int>> q = {std::pair <Node*, int> {head_, 0}};
            std::vector <std::pair <int, int>> p;
            while(q.size() > 0){
                std::pair <Node*, int> v = q[q.size() - 1];
                q.pop_back();
                p.push_back(std::pair <int, int> {v.first->value, v.second});
                if(v.first->right != NULL){
                    q.push_back(std::pair <Node*, int> {v.first->right, v.second + 1});
                }
                if(v.first->left != NULL){
                    q.push_back(std::pair <Node*, int> {v.first->left, v.second + 1});
                }
            }
            return p;
        }

        void dfs_plain_(Node* node, std::vector <int> &p){
            if(node->left != NULL){
                dfs_plain_(node->left, p);
            }
            p.push_back(node->value);
            if(node->right != NULL){
                dfs_plain_(node->right, p);
            }
        }

        void dfs_reverse_(Node* node, std::vector <int> &p){
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

        void add_node(int v, Node* node = NULL){
            if(head_ == NULL){
                head_ = new Node(v);
            }
            if(node == NULL){
                node = head_;
            }
            if(v < node->value){
                if(node->left == NULL){
                    node->left = new Node(v); 
                }
                else{
                    add_node(v, node->left);
                }
            }
            else{
                if(node->right == NULL){
                    node->right = new Node(v);
                }
                else{
                    add_node(v, node->right);
                }
            }
        }

        void create(std::vector <int> arr){
            head_ = new Node(arr[0]);
            for(int i = 1; i < arr.size(); i ++){
                add_node(arr[i], head_);
            }
        }

        std::vector <std::vector <int>> get_tree_by_levels(){
            std::vector <std::pair <int, int>> p = bfs_();
            std::vector <std::vector <int>> res;
            for(int _ = 0; _ <= p[p.size() - 1].second; _ ++){
                res.push_back(std::vector<int> {});
            }
            for(auto n: p){
                res[n.second].push_back(n.first);
            }
            return res;
        }

        std::vector <int> get_tree_list(){
            std::vector <std::pair <int, int>> p = bfs_();
            std::vector <int> res;
            for(auto n: p){
                res.push_back(n.first);
            }
            return res;
        }

        std::vector <int> get_tree_sorted(bool reverse = false){
            std::vector <int> p;
            if(reverse){
                dfs_reverse_(head_, p);
            }
            else{
                dfs_plain_(head_, p);
            }
            return p;
        }

        int get_min(Node* node = NULL){
            if(node == NULL){
                node = head_;
            }
            if(node->left != NULL){
                return get_min(node->left);
            }
            else{
                return node->value;
            }
            return 0;
        }

        int get_max(Node* node = NULL){
            if(node == NULL){
                node = head_;
            }
            if(node->right != NULL){
                return get_max(node->right);
            }
            else{
                return node->value;
            }
            return 0;
        }

};