#include <iostream>
using namespace std;
//��������� �������� �� ���������� ������� � �����������������

int main() {
	setlocale(LC_ALL, "Rus");
	int figure;

	cout.unsetf(ios::dec);
	cout.setf(ios::hex); // ������� ��������������� �����

	cout << "������� ���� �����: ";
	cin >> figure;
	
	cout << "I����������������� ����� ������ - " << figure << endl;
}