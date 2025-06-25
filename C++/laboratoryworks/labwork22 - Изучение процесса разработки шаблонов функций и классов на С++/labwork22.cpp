#include <iostream>
using std::cout;
using std::endl;
using std::cin;

template <typename T>
T Maximum(T a, T b) {
	if (a > b)
		return a;
	return b;
}

template <typename T>
int IndexOfMin(T* arr, unsigned size) {
	T min = arr[0];
	for (int i = 0; i < size; i++) {
		if (arr[i] < min)
			min = arr[i];
	}
	return min;
}

template <typename T, int siz = 10>
class List {
private:
	T _array[siz];
	int _count;
public:
	List() : _count(0) {}
	void Add(int value) {
		if (siz == _count) return;
		_array[_count] = value;
		_count += 1;
	}
	
	int Count() {
		return _count;
	}

	int CountOf(T value) {
		int total = 0;
		for (int i = 0; i < _count; i++) {
			if (value == _array[i])
				total += 1;
		}
		if (total == 0) return -1;
		return total;
	}
};

int main() {
	setlocale(LC_ALL, "ru");
	srand(time(0));

	int n1 = 5, n2 = 3;
	float n3 = 0.4, n4 = -2.3;
	cout << "max int: " << Maximum(n1, n2) << endl;
	cout << "max float: " << Maximum(n3, n4) << endl;

	int arr1[5] = { 2, -5, 32, 10, 5 };
	double arr2[5] = { 1.321, 2.31, 4.5, 1.17, 4.49 };
	unsigned size1 = sizeof(arr1) / sizeof(int), size2 = sizeof(arr2) / sizeof(double);
	cout << "\nmin index int: " << IndexOfMin(arr1, size1) << endl;
	cout << "min index float: " << IndexOfMin(arr2, size2) << endl;

	int value = 0, findV;
	List<int> list;
	list.Add(1);
	list.Add(1);
	list.Add(1);
	list.Add(2);
	list.Add(3);
	list.Add(3);

	cout << "\nКоличество элементов: " << list.Count() << endl;
	cout << "Нужный элемент: ";
	cin >> findV;
	cout << "Количество: " << list.CountOf(findV) << endl;

	return 0;
}

//for (int i = 0; i < 6; i++) list.Add(1 + rand() % 9);
/*void add(int index, int value) { _array[index] = value; }
cout << "\nВведите индекс и значение: ";
cin >> index, value;
list.Add(index, value);*/
