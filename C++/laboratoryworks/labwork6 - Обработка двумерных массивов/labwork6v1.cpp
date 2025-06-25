#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "ru");

    float cols, rows, x, sum = 0;
    int min = -150, numc;

    cout << "������� ���������� ����� ";
    cin >> rows;
    cout << "���������� �������� ";
    cin >> cols;
    cout << endl;
    float** arr = new float* [rows];
    for (int i = 0; i < rows; i++) {
        arr[i] = new float[cols];
    }

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            x = rand();
            arr[i][j] = min + x / 100;
        }
    }

    cout << "��� ������\n";
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            cout << arr[i][j] << " | ";
        }
        cout << endl;
    }
    cout << endl;

    cout << "������� ����� ������� ";
    cin >> numc;

    for (int i = 0; i < rows; i++) {
        if (numc > cols) break;
        sum += arr[i][numc - 1];
    }

    sum = round(sum * 10) / 10;
    cout << "����� ����� � " << numc << " ������� ����� " << sum;

	return 0;
}