#include <iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;

class Person{
private:
    string _name;
protected:
    unsigned _age;
public:
    Person(string name = "Template", unsigned age = 0) {
        _name = name;
        _age = age;
    }

    string getName() {
        return _name;
    }
    unsigned getAge() {
        return _age;
    }

    void print() const {
        cout << _name << " - " << _age << " years old";
    }
};

class Worker : public Person {
private:
    unsigned _seniority;
    unsigned _salary;
public:
    Worker(string name = "Template", unsigned age = 0, unsigned seniority = 0, unsigned salary = 0) :
        Person(name, age), _seniority(seniority), _salary(salary){}
    void print() const {
        Person::print();
        cout << " | " << _seniority << " is his seniority, " << _salary << " rubles";
    }

    unsigned getSeniority() {
        return _seniority;
    }

    unsigned getSalary() {
        return _salary;
    }

    unsigned GetStartWorkAge(unsigned age, unsigned seniority) {
        return _age - _seniority;
    }
};

class Figure {
public:
    virtual unsigned Area() const = 0;
    virtual unsigned Perimetr() const = 0;
    virtual void TypeOfFigure() {};
};

class Square : public Figure {
private:
    unsigned _side;
public:
    Square(unsigned side = 0) : _side(side) {};

    unsigned Area() const override {
        return _side * _side;
    }
    unsigned Perimetr() const override {
        return _side * 4;
    }
    void TypeOfFigure() {
        cout << "Square";
    }
};

class Rectangle : public Figure {
private:
    unsigned _width;
    unsigned _height;
public:
    Rectangle(unsigned w, unsigned h) : _width(w), _height(h) {};
    
    unsigned Area() const override {
        return _width * _height;
    }
    unsigned Perimetr() const override {
        return (_width + _height) * 2;
    }
    void TypeOfFigure() {
        cout << "Rectangle";
    }
};

int main() {
    setlocale(LC_ALL, "Rus");

    Worker* person = new Worker("Nill", 21, 4, 550000);
    person->print();

    cout << endl << endl << "Start work: " << person->GetStartWorkAge(person->getAge(), person->getSeniority()) << endl << endl;

    Square* square = new Square(5);
    square->TypeOfFigure();
    cout << " - " << square->Area() << " area, " << square->Perimetr() << " perimetr" << endl;

    Rectangle* rectangle = new Rectangle(3, 2);
    rectangle->TypeOfFigure();
    cout << " - " << rectangle->Area() << " area, " << rectangle->Perimetr() << " perimetr" << endl;

    delete person, square, rectangle;
    return 0;
}

