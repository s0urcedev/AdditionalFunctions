#include <iostream>

template <typename T>

class Node{

    public:

        T value;
        Node<T>* prev = NULL;
        Node<T>* next = NULL;
        Node(T v, Node<T>* p = NULL, Node<T>* n = NULL){
            value = v;
            prev = p;
            next = n;
        }
};

template <typename T>

class LinkedList{
    
    public:

        Node<T>* head = NULL;
        Node<T>* tail = NULL;
        unsigned int length = 0;

        LinkedList(){
            head = NULL;
            length = 0;
            tail = NULL;
        }

        LinkedList(T value){
            head = new Node<T>(value);
            length = 1;
            tail = NULL;
        }

        void add(T value){
            if(head == NULL){
                head = new Node(value);
            }
            else if(tail == NULL){
                tail = new Node(value, head);
                head->next = tail;
            }
            else{
                tail->next = new Node(value, tail);
                tail = tail->next;
            }
            length ++;
        }

        void shift(){
            head = head->next;
            length --;
        }

        void pop(){
            if(length == 1){
                shift();
            }
            else{
                tail->prev = NULL;
                tail = tail->prev;
                length --;
            }
        }

        void remove(int n){
            if(n < 0){
                n = length + n;
            }
            if(length == 0){
                throw "List is empty";
            }
            if(n >= length){
                throw "Index is bigger than length";
            }
            if(n == 0){
                shift();
            }
            else if(n == length - 1){
                pop();
            }
            else if(n < length / 2){
                Node<T>* node = head;
                for(int _ = 0; _ < n; _ ++){
                    node = node->next;
                }
                node->next->prev = node->prev;
                node->prev->next = node->next;
                length --;
            }
            else{
                Node<T>* node = tail;
                for(int _ = length - 1; _ > n; _ --){
                    node = node->prev;
                }
                node->next->prev = node->prev;
                node->prev->next = node->next;
                length --;
            }
        }

        Node<T>* getNode(int n){
            if(n < 0){
                n = length + n;
            }
            if(length == 0){
                throw "List is empty";
            }
            if(n >= length){
                throw "Index is bigger than length";
            }
            if(n == 0){
                return head;
            }
            else if(n == length - 1){
                return tail;
            }
            else if(n < length / 2){
                Node<T>* node = head;
                for(int _ = 0; _ < n; _ ++){
                    node = node->next;
                }
                return node;
            }
            else{
                Node<T>* node = tail;
                for(int _ = length - 1; _ > n; _ --){
                    node = node->prev;
                }
                return node;
            }
        }

        T get(int n){
            return getNode(n);
        }

};

int main(){
}