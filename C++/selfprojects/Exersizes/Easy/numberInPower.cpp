#include <iostream>
using namespace std;
//������� - ���������� ����� � ������� (����� ������� ��������, � ����� ������ �������� �������)

float exponentiation(float number, int power) {
	if (power == 0)
		return 1;
	if (power == 1)
		return number;
	return number * exponentiation(number, power - 1);
}

int main() {
	setlocale(LC_ALL, "ru");

	double number;
	int power;

	cout << "������� �����: ";
	cin >> number;
	cout << "������� �������: ";
	cin >> power;

	cout << "�����: " << exponentiation(number, power) << endl;

	return 0;
}