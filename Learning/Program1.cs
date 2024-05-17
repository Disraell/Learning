
Console.WriteLine("Введите свое имя: ");
Console.WriteLine("Компания \"Рога и копыта\"");
///
string name = "Tom";
int age = 34;
double height = 1.7;
string a = $"Имя: {name}  Возраст: {age}  Рост: {height} + {3+7} м"; /// Интерполяция

Console.WriteLine(a);
Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age); /// 2nd way
///
Console.Write("Введите имя: ");
    //string? name = Console.ReadLine(); //string$ с выводом null

Console.Write("Введите возраст: ");
    //int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите рост: ");
    //double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
    //decimal salary = Convert.ToDecimal(Console.ReadLine());

    //Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");
///
int x1 = 5;
int z1 = ++x1; // z1=6; x1=6
Console.WriteLine($"{x1} - {z1}"); // prefix

int x2 = 5;
int z2 = x2++; // z2=5; x2=6
Console.WriteLine($"{x2} - {z2}"); //postfix
///
int a1 = 3;
int b1 = 5;
int c1 = 40;
int d1 = c1-- -b1 * a1;    // a=3  b=5  c=39  d=25
Console.WriteLine($"a={a1}  b={b1}  c={c1}  d={d1}"); // order: post/pre, multi/divide, plus/minus
///
int value1 = 3;  // 0b0000_0011
int value2 = 2;  // 0b0000_0010
int value3 = 1;  // 0b0000_0001
int result = 0b0000_0000;
    // сохраняем в result значения из value1 
result = result | (value1 << 4); // умножение на 2^4 или сдвиг вправо на 4 разярда
    // сохраняем в result значения из value2
result = result | (value2 << 2); // умножение на 2^2 или сдвиг вправо на 2 разряда
    // сохраняем в result значения из value3
result = result | value3;  // 0b0011_1001

Console.WriteLine(result);  // 57
///
byte aa = 4;
byte bb = (byte)(aa + 70); // сложения/деления... возвращают int, нужно Преобразование

byte a2 = 4;              // 0000100 (7)
ushort b2 = a2;   // 000000000000100 (15) widening без проблем

ushort a3 = 4;
byte b3 = (byte)a3;  //arrownig есть проблемы
///
int a4 = 10;
int b4 = 4;
bool c = a4 == b4; // false
///
int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

int rows = numbers.GetUpperBound(0) + 1;    // индекс последней строки +1 - "0"
int columns = numbers.GetUpperBound(1) + 1;    // индекс последнего столбца +1 - "1"

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numbers[i, j]} \t");
    }
    Console.WriteLine();
}
///
int[][] nums = new int[3][];
nums[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
nums[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
nums[2] = new int[5] { 1, 2, 3, 4, 5 }; // выделяем память для третьего подмассива
foreach (int[] row in nums)
{
    foreach (int number in row)
    {
        Console.Write($"{number} \t");
    }
    Console.WriteLine();
}

    // перебор с помощью цикла for
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums[i].Length; j++)
    {
        Console.Write($"{nums[i][j]} \t");
    }
    Console.WriteLine();
}
///
void SayHello()
{
    Console.WriteLine("Hello");
}

void SayHello1() => Console.WriteLine("Hello"); // ставится ";" как после завершения строки коды

SayHello(); // Hello
SayHello1();
///
void PrintPerson(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson("Tom", company: "Microsoft", age: 37);  // Name: Tom  Age: 37  Company: Microsoft
PrintPerson(age: 41, name: "Bob");          // Name: Bob  Age: 41  Company: Undefined
PrintPerson(company: "Google", name: "Sam"); // Name: Sam  Age: 1   Company: Google
/// 
void Increment(ref int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

int number1 = 5;
Console.WriteLine($"Число до метода Increment: {number1}");
Increment(ref number1);
Console.WriteLine($"Число после метода Increment: {number1}");
///
void GetRectangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
{
    //width = 25; // нельзя изменить и установить, так как width - входной параметр
    rectArea = width * height;
    rectPerimetr = (width + height) * 2;
}

int w = 10;
int h = 20;
GetRectangleData(w, h, out var area, out var perimetr); //w и h - нельзя сменить они только входные параметры

Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60
///
int Fibonachi(int n) // рекурсивная Фибоначчи
{
    if (n == 0 || n == 1) return n;

    return Fibonachi(n - 1) + Fibonachi(n - 2);
}

int fib4 = Fibonachi(4);
int fib5 = Fibonachi(5);
int fib6 = Fibonachi(6);

Console.WriteLine($"4 число Фибоначчи = {fib4}");
Console.WriteLine($"5 число Фибоначчи = {fib5}");
Console.WriteLine($"6 число Фибоначчи = {fib6}");

int Fibonachi2(int n) // функция Фибоначчи
{
    int result = 0;
    int b = 1;
    int tmp;

    for (int i = 0; i < n; i++)
    {
        tmp = result;
        result = b;
        b += tmp;
    }

    return result;
}
int fib7 = Fibonachi2(4);
int fib8 = Fibonachi2(5);
int fib9 = Fibonachi2(6);

Console.WriteLine($"4 число Фибоначчи = {fib7}");
Console.WriteLine($"5 число Фибоначчи = {fib8}");
Console.WriteLine($"6 число Фибоначчи = {fib9}");
///
int Sum(int[] numbers) // локальная статическая функция
{
    int result = 0;
    int limit = 0;
    foreach (int number in numbers)
    {
        if (IsPassed(number, limit)) result += number;
    }
    return result;

    static bool IsPassed(int number, int lim)
    {
        //return number > limit; // Ошибка: метод IsPassed не имеет доступа к переменной limit
        return number > lim;
    }
}

int[] numbers1 = { -3, -2, -1, 0, 1, 2, 3 };
Console.WriteLine(Sum(numbers1));
///
int number2 = 1; // switch "goto case"
switch (number2)
{
    case 1:
        Console.WriteLine("case 1");
        goto case 5; // переход к case 5
    case 3:
        Console.WriteLine("case 3");
        break;
    case 5:
        Console.WriteLine("case 5"); //case 1 /n case 5
        break;
    default:
        Console.WriteLine("default");
        break;
}
///
int DoOperation(int op, int a, int b) // switch-case
{
    switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: return 0;
    }
}

int DoOperation1(int op, int a, int b) //сокращенная форма
{
    return op switch
    {
        1 => a + b, // => - выполение в одну строку, экономит скобки и строку
        2 => a - b,
        3 => a * b,
        _ => 0
    };
}

int DoOperation2(int op, int a, int b) => op switch //еще более соркащенная форма
{
    1 => a + b,
    2 => a - b,
    3 => a * b,
    _ => 0
};

Console.WriteLine(DoOperation(1, 10, 5)); // 15
Console.WriteLine(DoOperation1(2, 10, 5)); // 5
Console.WriteLine(DoOperation2(3, 10, 5)); // 50
///

DoOperation3(10, 5, Operation.Add);          // 15
DoOperation3(10, 5, Operation.Subtract);     // 5
DoOperation3(10, 5, Operation.Multiply);     // 50
DoOperation3(10, 5, Operation.Divide);       // 2

void DoOperation3(double x, double y, Operation op) // функция с enum
{
    double result = op switch
    {
        Operation.Add => x + y,
        Operation.Subtract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y,
        _ => 0
    };
Console.WriteLine(result);
}
enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}
///
/*
DayTime now = DayTime.Morning;  // тип и значение констант перечисления enum
DayTime now1 = 2;    // ! Ошибка
Console.WriteLine((int)now);  // 0
Console.WriteLine((int)DayTime.Night);  // 16
*/
enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night = 16
}
///


