#include <iostream>
using namespace std;
//������ �� ������ ����� �������
int main() {
	setlocale(LC_ALL, "Russian");

	int x, y, z;
	float length;

	cout << "������� X: ";
	cin >> x;
	cout << "������� Y: ";
	cin >> y;
	cout << "������� Z: ";
	cin >> z;

	length = round(sqrt(x * x + y * y + z * z) * 1000) / 1000;

	cout << endl << "����� ������� (" << x << ";" << y << ";" << z << ") = " << length << endl;


	return 0;
}