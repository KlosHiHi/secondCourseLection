#include <iostream>
using namespace std;
// ������������ ������ ���� ���� ��� �� ����� ����� 1.

int main() {
	setlocale(LC_ALL, "Rus");
	int num;
	
	cout << "������� ���������� �����:" << endl;
	do {
		cout << "num = ";
		cin >> num;
	} while (num != 1);
	cout << "���������!\n";
}