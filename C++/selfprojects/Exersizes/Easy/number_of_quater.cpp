#include <iostream>
using namespace std;
// ����������� ������ �������� �� 2 ����������� (������� �������).

int main() {
	setlocale(LC_ALL, "ru");
	float x, y;
	
	cout << "������� X - ";
	cin >> x;
	cout << "������� Y - ";
	cin >> y;

	if (x == 0 and y == 0)
		cout << "\n��������� ����������!\n";
	else if (x > 0 and y > 0)
		cout << "\n��� ������ ��������!\n";
	else if (x < 0 and y > 0)
		cout << "\n��� ������ ��������!\n";
	else if (x < 0 and y < 0)
		cout << "\n��� ������ ��������!\n";
	else if (x > 0 and y < 0)
		cout << "\n��� �������� ��������!\n";
}