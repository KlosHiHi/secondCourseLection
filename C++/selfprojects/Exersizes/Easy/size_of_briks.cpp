#include <iostream>
using namespace std;
//������� - ������ �� ������ � ���������

int main() {
	setlocale(LC_ALL, "Russian");
	int length_Brick = 0, width_Brick = 0, height_Brick = 0;
	int holeHeig = 0, holeLen = 0;

	cout << "������� ����� ���������: ";
	cin >> length_Brick;
	cout << "������� ������ ���������: ";
	cin >> width_Brick;
	cout << "������� ������ ���������: ";
	cin >> height_Brick;
	cout << "\n������� ������ ���������: ";
	cin >> holeHeig;
	cout << "������� ������ ���������: ";
	cin >> holeLen;

	int side1 = length_Brick * width_Brick, side2 = length_Brick * height_Brick, side3 = width_Brick * height_Brick;
	int holeSide = holeHeig * holeLen;

	if (side1 != 0 and side2 != 0 and side3 != 0) {
		if (side1 <= holeSide)
			cout << "\n���������� ������� ��������� - 1" << endl;
		else if (side2 <= holeSide)
			cout << "\n���������� ������� ��������� - 2" << endl;
		else if (side3 <= holeSide)
			cout << "\n���������� ������� ��������� - 3" << endl;
		else
			cout << "\n������ �� ��������!" << endl;
	}
}