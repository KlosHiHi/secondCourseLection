#include <iostream>
using namespace std;

void printTriangels(unsigned quantityTriangels);

int main() {
	//setlocale(LC_ALL, "Rus");
	unsigned quantityTriangels;

	cout << "������� ���������� �������������:";
	cin >> quantityTriangels;

	printTriangels(quantityTriangels);
}

void printTriangels(unsigned quantityTriangels) {
	if (quantityTriangels <= 0)
		return;

	for (int j = 0; j < quantityTriangels; j++) {
		for (int i = 0; i < quantityTriangels; i++)
			cout << "      �      ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << "     ���     ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << "    �����    ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << "   �������   ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << "  ���������  ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << " ����������� ";
		cout << endl << endl;
	}
}