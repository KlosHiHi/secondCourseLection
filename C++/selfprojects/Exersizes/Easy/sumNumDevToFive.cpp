#include <iostream>
using namespace std;

unsigned sumNumDevToFive(int num) {
	unsigned sum = 0;

	for (int i = 5; i <= num; i += 5) {
		sum += i;
	}

	return sum;
}

int main() {
	setlocale(LC_ALL, "Rus");
	int num;

	cout << "Введите последнее число последовательности: ";
	cin >> num;

	cout << "Сумма чисел делящихся на пять [0, " << num
		<< "] равна - " << sumNumDevToFive(num) << endl;
}