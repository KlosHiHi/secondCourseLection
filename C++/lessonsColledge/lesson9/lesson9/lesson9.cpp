#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main() {
	setlocale(LC_ALL, "ru");

	ofstream os; //����� ������
	os.open("test.txt", ios::app);

	if (os.is_open()) {
		os << "Hello" << endl;

		os.close();
	}

	ifstream is; //����� ������ 
	is.open("test.txt");

	if (is.eof()) {
		while (!is.eof()) {

		}
		is.close();
	}

	fstream fs; //����� ������-������
	fs.open("data.bin");
	if (!fs.is_open())
		return 1;

	return 0;
}