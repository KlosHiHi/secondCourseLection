#include <iostream>
using namespace std;
//��������� �������� ������������������ �����, ������������ ����������� ����� ������������� �����.

int main() {
	setlocale(LC_ALL, "Rus");
	string numbers;
	int num;

	cout << "������� ������������������ ����: ";
	cin >> numbers;

	char* arr = new char[numbers.length()];
	for (int i = 0; i < numbers.length(); i++)
		arr[i] = (char)numbers[i];
	
	cout << "\n������� ���������� ����� ������ �����: ";
	cin >> num;
	cout << "\n���� ����� - " << arr[num - 1] << endl;

	delete[] arr;
	return 0;
}