#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
using namespace std;

int main() {
	setlocale(LC_ALL, "ru");

	//������� 1 � 2
	string name;
	cout << "\t������\n\n������� ��� �����: ";
	cin >> name;
	FILE *file = fopen(name.c_str(), "r");
	if (file != NULL) {
		char letters[100]{"\0"};
		fread(letters, sizeof(letters[1]), 100, file);
		cout << "\n����������:\n" << letters << endl << endl;
		fclose(file);
	}
	else
		cout << "\n������! ������ ���� ������ ����� �� ����������" << endl << endl;

	//������� 3
	string OUT, IN;
	cout << "\t����������\n\n������� ��� ������� �����: ";
	cin >> OUT;
	cout << "������� ��� ������� �����: ";
	cin >> IN;
	FILE* out = fopen(OUT.c_str(), "r");
	FILE* in = fopen(IN.c_str(), "a");
	if (out != NULL and in != NULL) {
		char buffer[100]{ "\0" };
		fread(buffer, sizeof(buffer[1]), 100, out);
		fwrite(buffer, sizeof(char), sizeof(buffer), in);
		fclose(out);
		fclose(in);
	}
	else
		cout << endl << "������! ������ ���� ���� ������" << endl;

	return 0;
}