#include <iostream>
using std::cout;
using std::cin;
using std::endl;

void checkingForInt(float num);

int main() {
	setlocale(LC_ALL, "ru");
	float num;

	cout << "������� ����� �����: ";
	cin >> num;

	checkingForInt(num);
}

void checkingForInt(float num) {
	int numCHK = num;
	if((num - int(num)) == 0)
		cout << "���� ����� (" << num << ")" << " - �����!";
	else
		cout << "���� ����� (" << num << ") - �� �����.";
}
