#include <iostream>

using namespace std;

struct Groceries { //��������� ��������� - ������� 1
	string type;
	string name;
	float price;
};

int main() {
	setlocale(LC_ALL, "ru");

	//Groceries grocery[] = { {"drinks", "Coca-Cola", 1.99}, {"drinks", "Water", 0.99}, { "bakaley", "Rise", 1.49 }, { "bakaley", "Mac", 1.79 } }; //- �������� ������� ������� 2
	//for (auto& p : grocery) cout << p.type << " - " << p.name << " " << p.price << "$" << endl; //- ����� ������� - ������� 2

	int n;
	string codeWork;
	float min, max;

	cout << "������� ��������� ������ ��������? ";
	cin >> n;
	Groceries* grocery = new Groceries[n]; //�������� ������������� �������

	for (int i = 0; i < n; i++) { //���������� ������� ������� ������� - ������� 3
		cout << "��� ��������: ";
		cin >> grocery[i].type;
		cout << "������������ ��������: ";
		cin >> grocery[i].name;
		cout << "���� ��������: ";
		cin >> grocery[i].price;
	}

	cout << "\t����� �� ����������\n\n" << "����� ��������� ����� - ";
	cin >> codeWork;
	for (int i = 0; i < n; i++) { // ����� �� ������� ������ ��������� - ������� 4
		if (codeWork == grocery[i].type)
			cout << grocery[i].name << endl;
	}

	cout << "\t����� �� ����\n\n" << "����������� ���� - ";
	cin >> min;
	cout << "������������ ���� - ";
	cin >> max;

	for (int i = 0; i < n; i++) {
		if
	}

	delete[] grocery;
	return 0;
}