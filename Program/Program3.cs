class Program3
{
    static void Main(string[] args) // программа верхнего уровня
    {
        Person tom = new();
        tom.SayHello();

        
        Person1 sam = new Person1(); // инициализация структуры как и класса (с конструктором)                 
        sam.Print(); // Имя:   Возраст: 0
        sam.name = "Sam";
        sam.Print(); // Имя: Sam  Возраст: 0

        Person1 sam1; // инициализация без конструктора, но с обязательной инициализация полей (без - ошибка)
        sam1.name = "Sam";
        sam1.age = 37;
        sam1.Print(); // Имя: Sam  Возраст: 37

        Person2 tob = new(); // в отличии от класса применяется конструктор по-умол., а не определенный
        Person2 bob = new("Bob");
        Person2 som = new("Som", 25);
        tob.Print();    // Имя:   Возраст: 0   - не работает определенный конструктор
        bob.Print();    // Имя: Bob  Возраст: 1 
        som.Print();    // Имя: Sam  Возраст: 25

        Person3 tom1 = new();
        Person3 bob1 = new("Bob");
        Person3 som1 = new("Som", 25);
        tom1.Print();    // Имя: Tom  Возраст: 1
        bob1.Print();    // Имя: Bob  Возраст: 1 
        sam1.Print();    // Имя: Sam  Возраст: 25

        Person4 tob1 = new Person4("Tob");
        tob1.Print();

        Person5 tom2 = new Person5 { name = "Tom", age = 22 }; //инициализатор после конструткора без параметров/по-умол.
        tom2.Print();    // Имя: Tom  Возраст: 22
        Person5 bob2 = tom2; // копирование значений одной структуры в другую
        bob2.Print();    // Имя: Tom  Возраст: 22

        bob2 = tom2 with { name = "Bob", age = 14 }; // копирование значений одной структуры в другую, с заменой переменных ключ слово "with"
        bob2.Print();    // Имя: Bob  Возраст: 14

        ////////////////////////

        State state1 = new State();
        State state2 = new State();

        state2.country.x = 5;
        state1 = state2;
        state2.country.x = 8; // теперь и state1.country.x = 8, так как state1.country и state2.country указывают на один объект в хипе
        Console.WriteLine(state1.country.x); // 8
        Console.WriteLine(state2.country.x); // 8

        ////////////////////////

        Person6 p = new Person6 { name = "Tom", age = 23 }; 

        ChangePerson(p);
        Console.WriteLine(p.name); // Alice
        Console.WriteLine(p.age + "\n"); // 23

        void ChangePerson(Person6 person) // передача ссылочного объеккта в параметр метода
        {
            // сработает
            person.name = "Alice";
            // сработает только в рамках данного метода потому, что создает новую ссылку в хипе под объект "person", не может выделить новую пасять под "p"
            person = new Person6 { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }

        ChangePerson1(ref p);
        Console.WriteLine(p.name); // Bill
        Console.WriteLine(p.age); // 45

        void ChangePerson1(ref Person6 person)
        {
            // сработает
            person.name = "Alice";
            // сработает т.к. имеет референс на обёект и может заново создать объём памяти в хипе для "p"
            person = new Person6 { name = "Bill", age = 45 };
            Console.WriteLine(person.name);
        }

    }
}

class Person // классы/структуры обычно определяются внизу программы верхнего уровня
{
    public void SayHello() => Console.WriteLine("Hello");
}

struct Person1 // структуры нужны для создания типов данных
{
    public string name = "Tom";
    public int age = 1;

    public Person1() { }

    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}

struct Person2
{
    public string name;
    public int age;

    public Person2(string name = "Tob", int age = 1)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}

struct Person3 // структура с цепочкой вызовов классов
{
    public string name;
    public int age;

    public Person3() : this("Tom")
    { }
    public Person3(string name) : this(name, 1)
    { }
    public Person3(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}

public struct Person4(string name, int age) // структура с первичным конструктором создает !приватные поля с переменными
{
    public Person4(string name) : this(name, 18) { } // доп. конструктор должен вызывать первичный
    public void Print() => Console.WriteLine($"name: {name}, age: {age}");
}

struct Person5 //структуру можно определить инициализацией
{
    public string name;
    public int age;
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}

////////////////////////////////////// ссылочные типы и типы значений

struct State //тип значений (стек)
{
    public int x;
    public int y;
    public Country country;
    public State()
    {
        x = 0;
        y = 0;
        country = new Country(); // выделение памяти для объекта Country
    }
}
class Country // ссылочный тип (хип)
{
    public int x;
    public int y;
}

class Person6
{
    public string name = "";
    public int age;
}

//1123