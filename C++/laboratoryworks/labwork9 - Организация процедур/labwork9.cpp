#include <iostream>
using namespace std;
//������������ ������ - ���������/�������

void swap(float&, float&);
void printArr(int arr[], int);
void fill(int numbers[], int);

int main() {
	setlocale(LC_ALL, "Russian");
	srand(time(0) * 10);

	//������ �������
	float a = 4, b = 0;
	cout << a << " " << b << endl;
	swap(a, b);

	//������ �������
	cout << endl;
	int arr[10]{ 2, 4, 6, 1, 3, 5, 7, 8, 9, 0 };
	int size = sizeof(arr) / sizeof(arr[1]);
	printArr(arr, size);

	//������ �������
	cout << endl;
	int numbers[10]{};
	int dimension = 10;
	fill(numbers, dimension);

	return 0;
}
//������ ���������, ������ ������� 2 �����, ��� ������ �������
void swap(float& a, float& b) {
	float storage = a;
	a = b;
	b = storage;
	cout << a << " " << b << endl;

}
//������ ��������� - ��������� �������� ������� ����� ������.
void printArr(int arr[], int size) {
	for (int i = 0; i < size; i++)
		cout << arr[i] << " ";
	cout << endl;
}
//������ ��������� - ��������� ���������� ������ �������.
void fill(int numbers[], int dimension) {
	for (int i = 0; i < dimension; i++) {
		numbers[i] = 1 + rand() % 10;
		cout << numbers[i] << " ";
	}
	cout << endl;
}