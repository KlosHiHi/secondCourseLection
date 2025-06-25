#include <iostream>
using std::cout;
using std::endl;
//“аблица квадратов чисел
int main() {
	setlocale(LC_ALL, "Rus");

	cout << "\n" << "--число--" << "\t\t" << "--квадрат числа--" << endl << "---------" << "\t\t" << "-----------------" << "\n\n";
	for (int i = 4; i < 10; i++) {
		cout << "    " << i << "\t\t\t\t" << pow(i, 2) << endl;
	}

	return 0;
}