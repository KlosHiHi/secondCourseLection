#include <iostream>
using namespace std;

unsigned sumNumDevToFive(int num) {
	unsigned sum = 0;

	for (int i = 5; i <= num; i += 5) {
		sum += i;
	}

	return sum;
}

int main() {
	setlocale(LC_ALL, "Rus");
	int num;

	cout << "������� ��������� ����� ������������������: ";
	cin >> num;

	cout << "����� ����� ��������� �� ���� [0, " << num
		<< "] ����� - " << sumNumDevToFive(num) << endl;
}