#include <iostream>
using std::cout;
using std::cin;
using std::endl;
//Таблица умножение от 1 до 9.

void MultTab(int num) {
	if (num == 0)
		return;
	for (int i = 1; i < 10; i++)
		cout << i << " * " << num << " = " << i * num << endl;
}

int main() {
	setlocale(LC_ALL, "ru");
	int num;

	cout << "Введите число: ";
	cin >> num;
	cout << endl;
	MultTab(num);

	return 0;
}