#include <iostream>
using std::cout;
using std::cin;
using std::endl;
//����� ����� ���������� ���� ����� (y = ax^2 + b*x + c) � (y = d*x + k)

void pointOfIntersection(int a, int b, int c, int d, int k) {
	int x1, x2, y1, y2;

	x1 = -(b - d) + sqrt((pow((b - d), 2) - 4 * a * (c-k))) / (2*a);
	x2 = -(b - d) - sqrt((pow((b - d), 2) - 4 * a * (c - k))) / (2 * a);
	y1 = d * x1 + k;
	y2 = d * x2 + k;

	if (x1 == x2) cout << "\n����� ����������� ���� ������ ������:"
		"[" << x1 << ", " << y1 << "]\n";
	else
		cout << "\n������ ����� ��� ����� �����������: "
		"[" << x1 << ", " << y1 << "] � "
		"[" << x2 << ", " << y2 << "]\n";
}

int main() {
	setlocale(LC_ALL, "Russian");
	int a, b, c, d, k;

	cout << "������� ������������ ��� ������� ��������� - y = ax^2 + bx + c" << endl;
	cout << "a = ";
	cin >> a;
	cout << "b = ";
	cin >> b;
	cout << "c = ";
	cin >> c;
	cout << "\n������� ������������ ��� ������� ��������� - y = dx + k" << endl;
	cout << "d = ";
	cin >> d;
	cout << "k = ";
	cin >> k;

	pointOfIntersection(a, b, c, d, k);

	return 0;
}