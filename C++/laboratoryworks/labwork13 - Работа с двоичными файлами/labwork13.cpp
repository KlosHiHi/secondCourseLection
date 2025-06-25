#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main() {
	setlocale(LC_ALL, "ru");

	//������� 1 - ������ � ����.
	srand(time(0));
	string nameW;
	int n = 0;
	cout << "\t������ � ��������� �������\n\n" << "������� ��� ����� ��� ������: ";
	cin >> nameW;

	ofstream write(nameW, ios::binary | ios::out);
	if (write.is_open()) {
		cout << "����� ���������� ����� ������������� - ";
		cin >> n;
		for (int i = 0; i < n; i++) 
			write << rand() % 101 << " ";
		write.close();
	}
	else
		cout << "������ ������!" << endl;
	
	//������� 2 - ������ �� �����.
	string nameR;
	int number;
	cout << "\n������� ��� ����� ��� ������: ";
	cin >> nameR;
	ifstream read(nameR, ios::binary | ios::in);
	if (read.is_open()) {
		for (int i = 0; i < n; i++) {
			read.seekg(sizeof(int) * i);
			read.read(reinterpret_cast<char*>(&number), sizeof(number));
			cout << number << " ";
		}
		cout << endl;
		read.close();
	}
	else
		cout << "������ ������!" << endl;

	//������� 3 - ������ 3 ����������.
	struct Grocery {
		string type;
		string name;
		int cost;
	};
	Grocery groceries[] = { {"drinks", "Water", 0.99}, { "bakaley", "Rise", 1.49 }, { "bakaley", "Mac", 1.79 } };
	string fileWrite;
	cout << "������� ��� ����� ��� ������ ������: ";
	cin >> fileWrite;

	ofstream fileW(fileWrite, ios::binary | ios::out);
	if (fileW.is_open()) {
		for (auto& p : groceries)
			fileW << p.type << " " << p.name << " " << p.cost;
		fileW.close();
	}
	else
		cout << "SECURITY ALERT SECURITY ALERT" << endl;

	//������� 4 - ������ � ��������� (�� ��������)
	string fileRead, line;
	Grocery gList;
	cout << "������� ��� ����� ��� ������ ������: ";
	cin >> fileRead;

	ifstream fileR(fileRead, ios::binary | ios::in);
	if (fileR.is_open()) {
		while (getline(fileR, line))
			cout << line;
		fileR.close();
	}
	else
		cout << "������";

	return 0;
}