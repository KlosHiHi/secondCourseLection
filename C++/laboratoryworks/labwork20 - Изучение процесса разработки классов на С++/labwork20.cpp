#include <iostream>
using namespace std;

class Time {
private:
    int _hours{ 0 };
    int _minutes{ 0 };
    int _seconds{ 0 };
public:
    Time() : _hours(12) {}
    Time(int h, int m, int s){
        if (s < 0) _seconds = 0;
        else if (s > 59) {
            _seconds += s % 60;
            _minutes += s / 60;
        }
        else _seconds = s;

        if (m < 0) _minutes = 0;
        else if(m > 59) {
            _minutes += m % 60;
            _hours += m / 60;
        }
        else _minutes += m;

        if (h < 0) _hours = 0;
        else _hours += h;
    }

    Time(unsigned seconds) : _hours(seconds / 3600), _minutes((seconds - (_hours * 3600)) / 60),
        _seconds((seconds - (_hours * 3600)) - _minutes*60) {}

    void PrintT() {
        if ((_minutes / 10) != 0 and (_seconds / 10) != 0)
            cout << _hours << ":" << _minutes << ":" << _seconds;
        else if ((_minutes / 10) == 0 and (_seconds / 10) != 0)
            cout << _hours << ":0" << _minutes << ":" << _seconds;
        else if ((_minutes / 10) != 0 and (_seconds / 10) == 0)
            cout << _hours << ":" << _minutes << ":0" << _seconds;
        else if ((_minutes / 10) == 0 and (_seconds / 10) == 0)
            cout << _hours << ":0" << _minutes << ":0" << _seconds;
    }

    unsigned GetFullSeconds() {
        return _hours * 3600 + _minutes * 60 + _seconds;
    }

    int operator[](int index) const{
        switch (index) {
        case 1: return _hours;
        case 2: return _minutes;
        case 3: return _seconds;
        default: return -1;
        }
    }
};

int main()
{
    setlocale(LC_ALL, "Rus");
    /*
    unsigned seconds = 105232;
    Time time{ 5, 45, 340 };
    Time sec{seconds};
    Time defaultT;

    cout << "Время: ";
    time.PrintT();
    cout << " | ";
    sec.PrintT();
    cout << " | ";
    defaultT.PrintT();
    cout << "\n\nВремя в секундах: ";
    cout << time.GetFullSeconds() << " | " << sec.GetFullSeconds() << " | " << defaultT.GetFullSeconds() << endl;
    */
    int hour = 0, minute = 0, second = 0, quantity = 0, hourVal, minVal;

    cout << "Какое количество элементов вы ходите добавить - ";
    cin >> quantity;
    Time* arrOfTime = new Time[quantity];

    for (int i = 0; i < quantity; i++) {
        cout << "Введите часы, минуты и секунды для " << i+1 << " элемента : ";
        cin >> hour >> minute >> second;
        arrOfTime[i] = { hour, minute, second };
    }
    cout << endl << "| ";
    for (int i = 0; i < quantity; i++) {
        arrOfTime[i].PrintT();
        cout << " | ";
    }

    cout << "\n\nВведите значение времени и минут: ";
    cin >> hourVal >> minVal;
    cout << endl << "| ";
    for (int i = 0; i < quantity; i++) {
        if (arrOfTime[i][1] > hourVal) {
            arrOfTime[i].PrintT();
            cout << " | ";
        }
        else if (arrOfTime[i][1] == hourVal && arrOfTime[i][2] > minVal) {
            arrOfTime[i].PrintT();
            cout << " | ";
        }
    }
    cout << endl;
    
    delete[] arrOfTime;
    return 0;
}

