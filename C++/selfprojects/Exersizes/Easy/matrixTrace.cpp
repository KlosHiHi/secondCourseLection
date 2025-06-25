#include <iostream>
using namespace std;
//��������� ��������� ���� �������

int main() {
	setlocale(LC_ALL, "Rus");

	unsigned rows, cols;
	int mTrace = 0;
	srand(time(NULL));

	cout << "\t��������� ������ � ���������!\n\n";

	cout << "���������� ����� �������: ";
	cin >> rows;
	cout << "���������� �������� �������: ";
	cin >> cols;
	cout << endl;

	int** matrix = new int* [cols];
	for (int i = 0; i < cols; i++)
		matrix[i] = new int[rows];

	for (int i = 0; i < cols; i++) {
		for (int j = 0; j < rows; j++) {
			matrix[i][j] = rand() % 100;
			if (i == j)
				mTrace += matrix[i][j];
			if ((matrix[i][j] / 10) == 0) {
				cout << ' ' << matrix[i][j] << ' ';
				continue;
			}
			cout << matrix[i][j] << " ";
		}
		cout << endl;
	}

	if (rows != cols)
		cout << "\n\n� ������ ������� ��� �����!" << endl;
	else
		cout << "\n\n���� �������: " << mTrace << endl;
	
	delete[] matrix;
	return 0;
}