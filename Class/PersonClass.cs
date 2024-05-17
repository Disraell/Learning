class Person
{
    public string name;
    public int age;

    public Person() {
        Console.WriteLine("Создание объекта Person");
        name = "Tom";
        age = 37;
    }

    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}
///////////////////////////////
class Person1 // с конмтуркторами класса
{
    public string name;
    public int age;
    public Person1() { name = "Неизвестно"; age = 18; }      // 1 конструктор
    public Person1(string n) { name = n; age = 18; }         // 2 конструктор
    public Person1(string n, int a) { name = n; age = a; }   // 3 конструктор

    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}
/////////////////////////////////////////
class Person2 // с ключевым словом "this"
{
    public string name;
    public int age;
    public Person2() { name = "Неизвестно"; age = 18; }
    public Person2(string name) { this.name = name; age = 18; }
    public Person2(string name, int age) { this.name = name; this.age = age; }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}

/*В примере выше во втором и третьем конструкторе параметры называются также, как и поля класса.
  И чтобы разграничить параметры и поля класса, к полям класса обращение идет через ключевое слово this.
  Так, в выражении "his.name = name;" первая часть - this.name означает, что name - это поле текущего класса, а не название параметра name. 
  Если бы у нас параметры и поля назывались по-разному, то использовать слово this было бы необязательно. 
  Также через ключевое слово this можно обращаться к любому полю или методу. */

////////////////////////////////////////////////
class Person3
{
    public string name;
    public int age;
    public Person3() : this("Неизвестно")    // первый конструктор вызывает следующий через ":" и инициализурет парметр что автомат. вызывает след. конструктор
    { }
    public Person3(string name) : this(name, 18) // второй конструктор вызывает слудющий
    { }
    public Person3(string name, int age)     // третий конструктор, с него начинается выполнение инструкций
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}

//////////////////////////////////

class Person4 // так как нету инструкцй в прошлых конструкторах, можно записать все парметры по умолчанию в сам конструктор
{
    public string name;
    public int age;
    public Person4(string name = "Неизвестно", int age = 18)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}

/////////////////////////////////

public class Person5(string name, int age) // Первичный конструктор с инициализацией переменных в тело класса
{
    public Person5(string name) : this(name, 18) { } // дополнительный конструктор вызывает первичный и в конечном итоге все доп. конструкторы должны вызывать первичный
    public void Print() => Console.WriteLine($"name: {name}, age: {age}");
}

/////////////////////////////////


class Person6 //класс для инициализации переменных из вне класса через инициализатор, можно так же инициализировать в инициализации, это преимущество перед конструктором
{
    public string name;
    public Company company;
    public Person6()
    {
        name = "Undefined";
        company = new Company();
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Компания: {company.title}");
}

class Company
{
    public string title = "Unknown";
}

/////////////////////////////////

class Person7 // класс с деконструктором
{
    string name;
    int age;
    public Person7(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
}


































