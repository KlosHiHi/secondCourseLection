#include <iostream>
using namespace std;
//��������� ����������, �������� �� 5-������� ����� �����������.

int main() {
	setlocale(LC_ALL, "Rus");

	unsigned fivesigned = 00000;
	cout << "������� ����������� �����: ";
	cin >> fivesigned;
	unsigned short first = fivesigned / 10000, second = ((fivesigned - (fivesigned % 1000)) / 1000) % 10, fourth = (fivesigned % 100) / 10, fifth = fivesigned % 10;

	cout << endl  << first << " " << second << " " << fourth << " " << fifth << endl;

	if (first == fifth and second == fourth)
		cout << "\n������ ����� - ���������." << endl;
	else
		cout << "\n����� �� �������� ����������� :(" << endl;
	return 0;
}