#include <iostream>
using namespace std;

class Book {
private:
	string _title;
	string _author;
	int _year;
protected: //������ �� ��������� ������ �� �������� ��� �����������
	int _isbn;
public:
	Book(string title, string author, int year) { //��� �������� ������ � ��������� ����� ��� �������
		_title = title;
		_author = author;
		_year = year;
	}
	//Book(string title, string author, int year) : _title(title), 
	//	_author(author), _year(year)
	
	//�������� �����������(������ �������, �� �������� � ���� ��������)
	string getTitle() const {
		return _title;
	}
	string getAuthor() const {
		return _author;
	}
	int getYear() const {
		return _year;
	}

	void print() const {
		cout << _title << " " << _author << " " << _year;
	}
};

//������� ������������ - (����������� ������������ ������� � ������� ��������)
class EBook : public Book {
private:
	string _format;
	double _filesize;
public:
	EBook(string title, string author, int year, string format, double filesize) :
		Book(title, author, year), _format(format), _filesize(filesize){}
	void print() const {
		Book::print();
		cout << " | " << _format << " | " << _filesize;
	}
};

//����������� - (����������� ��������� ��������� ����� ������, ����� ��� ������������� �������).
//������������� ����������� ����� ������, ���������� �������.
class LibraryItem{
public:
	virtual void print() const = 0;
};

//���������� - ��������� ���� �������� ���� �������, ������ ��� ������.
class PhysicalBook : public Book, public LibraryItem {
public:
	PhysicalBook(string title, string author, int year): Book(title, author, year){}
	void print() const override {
		Book::print();
		cout << endl << "�������� �����";
	}
};

class ElectronicBook : public EBook, public LibraryItem {
public:
	ElectronicBook(string title, string author, int year, string format, double filesize) :
		EBook(title, author, year, format, filesize) {}
	void print() const override {
		EBook::print();
		cout << endl << "����������� �����";
	}
};

int main() {
	setlocale(LC_ALL, "ru");

	Book* book = new Book("���� ������� � ������ �� ���������", "����� ������", 2017);
	book->print();
	cout << endl << endl;
	EBook* ebook = new EBook("Mine Craft", "����������� ��������", 1848, "pdf", 10.92);
	ebook->print();
	cout << endl;


	return 0;
}