#include <iostream>
using std::cout;
using std::cin;
using std::endl;
// ����� ����� ������ ��������� �� 5

int devOnFive(int rightborder, int leftborder) {
	int i = leftborder, sum = 0;
	bool round = true;

	if (rightborder < leftborder)
		return -1;
	do {
		if ((i % 5) == 0) {
			while (i <= rightborder) {
				sum += i;
				i += 5;
			}
			return sum;
		}
		i += 1;
	} while (i < rightborder);
}

int main() {
	setlocale(LC_ALL, "ru");

	int rigthBorder, lefthBorder;

	cout << "������� ����� ������� ��������� �����: ";
	cin >> lefthBorder;
	cout << "������� ������ ������� ��������� �����: ";
	cin >> rigthBorder;

	cout << "����� ����� ��������� �� 5 ��� �������: " << devOnFive(rigthBorder, lefthBorder) << endl;

	return 0;
}