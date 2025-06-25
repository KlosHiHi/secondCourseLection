#include <iostream>
using namespace std;

struct Node { //Node - ����
	int data;
	Node* next;
	Node(int val) {
		this->data = val;
		this->next = nullptr;
	} //��������� ������ ��� Node
};

struct LinkedList {
	Node* head;
	LinkedList() {this->head = nullptr;}
	void print() {
		Node* current = head;
		while (current != nullptr) {
			cout << current->data << " ";
			current = current->next;
		} //���������� ������������� ������� � ���� ������, � ������� ����� ��������� ����� ���������� ���������.
	}
	void insert(int data) {
		Node* newNode = new Node(data);
		newNode->next = head;
		this->head = newNode;
	}
};

int main() {

	LinkedList* linlis = new LinkedList;

	linlis->insert(10);
	linlis->insert(1);
	linlis->insert(5);
	linlis->insert(41);
	linlis->insert(3);
	linlis->insert(0);
	linlis->insert(10);
	linlis->insert(5);

	linlis->print();

	delete[] linlis;

	/*
	int a = 1;
	int* p = &a;

	int* i = new int; //�������� ���������� ����������.
	delete i; //������������ ������
	*/
}