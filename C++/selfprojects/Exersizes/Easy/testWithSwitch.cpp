#include <iostream>
using namespace std;
//����-���� ��� ������ switch:case
int main() {
	setlocale(LC_ALL, "Rus");

	float grade = 0;
	char var;
	bool injury = 0;

	cout << "\t���� �� ��������\n\n";
	cout << "1)���� ���� ���..?\na -> ��. ��������\nb -> ��. ����\nc -> ��. ���������\n�����:";
	cin >> var;

	switch (var) {
	case 'a':
		grade += 2;
		break;
	case 'b':
		break;
	case 'c':
		break;
	default:
		break;
	}

	cout << "\n2)� ����� ������ ����������������� 80% ������������� \"������ �������\"?\na -> �����\nb -> ������\nc -> ���\n�����:";
	cin >> var;

	switch (var) {
	case 'a':
		break;
	case 'b':
		break;
	case 'c':
		grade += 1;
		break;
	default:
		break;
		return 0;
	}

	cout << "\n3*)� ������� ����� ����� ����� ����...\na -> � �������� �������\nb -> �������� �����\nc -> � �����\n�����:";
	cin >> var;

	switch (var) {
	case 'a':
		grade += 1.5;
		break;
	case 'b':
		break;
	case 'c':
		break;
	default:
		break;
		return 0;
	}

	cout << "\n��� ��������� - " << grade << endl;

	return 0;
}