#include <map>
#include <iostream>
using namespace std;

int main() {
	setlocale(LC_ALL, "ru");
	map <int, int > i;
	map <string, string> m;
	map <string, string> d;
	
	i[1] = 3;
	m["Slava"] = "Vlasov";
	d["Roman"] = "Sadovskiy"; // ������������� �������, � ������� ��� - ��� ����� ��������,  � ������� - ��� ��� �������.

	cout << d["Roman"] << endl;
}