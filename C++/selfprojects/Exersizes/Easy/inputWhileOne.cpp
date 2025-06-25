#include <iostream>
using namespace std;
// пользователь вводит чило пока оно не будет равно 1.

int main() {
	setlocale(LC_ALL, "Rus");
	int num;
	
	cout << "Введите правильная число:" << endl;
	do {
		cout << "num = ";
		cin >> num;
	} while (num != 1);
	cout << "Правильно!\n";
}