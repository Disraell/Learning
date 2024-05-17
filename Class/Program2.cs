
Person tom = new Person();  // создание объекта класса Person

tom.Print();

    // устанавливаем новые значения полей
tom.name = "Loh";
tom.age = 20;
tom.Print();    // обращаемся к методу Print

///////////////////////////////

Person1 tim = new Person1();          // вызов 1-ого конструктора без параметров
Person1 bob = new Person1("Bob");     //вызов 2-ого конструктора с одним параметром
Person1 sam = new Person1("Sam", 25); // вызов 3-его конструктора с двумя параметрами

/*
Person tom = new ();            // аналогично new Person();
Person bob = new ("Bob");       // аналогично new Person("Bob");
Person sam = new ("Sam", 25);   // аналогично new Person("Sam", 25);
*/

tim.Print();          // Имя: Неизвестно  Возраст: 18
bob.Print();          // Имя: Bob  Возраст: 18
sam.Print();          // Имя: Sam  Возраст: 25

///////////////////////////////////

Person2 sam1 = new("Sam", 25);

sam1.Print();          // Имя: Sam  Возраст: 25

////////////////////////////////////

Person3 sam2 = new();

sam2.Print();

////////////////////////////////////

Person4 sam3 = new();
sam3.name = "Sam3"; // доступ к полю класса

sam3.Print();

////////////////////////////////////

Person5 tom1 = new Person5("Tom", 12);
Person5 tom2 = new Person5("Tom");

Console.WriteLine(tom1); // выдаст тип объекта "Person5"
tom1.Print();

Console.WriteLine(tom2); // выдаст тип объекта "Person5"
tom2.Print();

////////////////////////////////////

Person6 tom3 = new Person6 { name = "Tom", company = { title = "Microsoft" } }; // инициализация в инициализации
tom3.Print();          // Имя: Tom  Компания: Microsoft

////////////////////////////////////

Person7 person = new Person7("Tom", 33);

string name; int age;
person.Deconstruct(out name, out age); // аналогично выражению внизу

(/*string*/name, /*int*/age) = person; // аналогично выражению вверху

// деКонстурктор вытягивает переменные

Console.WriteLine(name);    // Tom
Console.WriteLine(age);     // 33

( _ , age ) = person; // если нам не нужны все переменные то ставим "_"
Console.WriteLine(age);

////////////////////////////////////













