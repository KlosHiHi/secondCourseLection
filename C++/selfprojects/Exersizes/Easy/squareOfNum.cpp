#include <iostream>
using std::cout;
using std::endl;
//������� ��������� �����
int main() {
	setlocale(LC_ALL, "Rus");

	cout << "\n" << "--�����--" << "\t\t" << "--������� �����--" << endl << "---------" << "\t\t" << "-----------------" << "\n\n";
	for (int i = 4; i < 10; i++) {
		cout << "    " << i << "\t\t\t\t" << pow(i, 2) << endl;
	}

	return 0;
}