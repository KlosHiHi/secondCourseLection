#include <iostream>
using namespace std;
// ��������� ����������� �� ����� � �����

int main() {
	setlocale(LC_ALL, "ru");
	int numbers;

	cout << "\t�������� �� ������������ �������������� �����\n\n" << "������� ������������� �����: ";
	cin >> numbers;

	int first = numbers % 10, second = numbers / 10 - ((numbers / 100) * 10), third = numbers / 100 - ((numbers / 1000) * 10), fourth = numbers / 1000;
	cout << "\n|" << first << "|" << second << "|" << third << "|" << fourth << "|";

	if (first == second or first == third or first == fourth or second == third or second == fourth or fourth == third)
		cout << "\n\n���� ���������� �����!" << endl;
	else
		cout << "\n\n��� ���������� �����!" << endl;

	return 0;
}