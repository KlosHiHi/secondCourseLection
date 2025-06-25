#include <iostream>
using namespace std;

void printTriangels(unsigned quantityTriangels);

int main() {
	//setlocale(LC_ALL, "Rus");
	unsigned quantityTriangels;

	cout << "Введите количество треугольников:";
	cin >> quantityTriangels;

	printTriangels(quantityTriangels);
}

void printTriangels(unsigned quantityTriangels) {
	if (quantityTriangels <= 0)
		return;

	for (int j = 0; j < quantityTriangels; j++) {
		for (int i = 0; i < quantityTriangels; i++)
			cout << "      Ы      ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << "     ЫЫЫ     ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << "    ЫЫЫЫЫ    ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << "   ЫЫЫЫЫЫЫ   ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << "  ЫЫЫЫЫЫЫЫЫ  ";
		cout << endl;
		for (int i = 0; i < quantityTriangels; i++)
			cout << " ЫЫЫЫЫЫЫЫЫЫЫ ";
		cout << endl << endl;
	}
}