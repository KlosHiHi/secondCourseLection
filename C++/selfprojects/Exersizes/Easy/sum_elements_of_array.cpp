#include <iostream>
using namespace std;
//������ - ����� ��������� �������, ������ ������� ������ 2.5
int main() {
	setlocale(LC_ALL, "ru");

	int size;
	float sum = 0;

	cout << "������ �������: ";
	cin >> size;
	float* arr = new float[size];
	
	cout << "��������� ������ (����� ������) - ";
	for (int i = 0; i < size; i++) {
		cin >> arr[i];
		if (fabs(arr[i]) > 2.5)
			sum += arr[i] * arr[i];
	}

	cout << "����� = " << sum << endl;

	return 0;
}