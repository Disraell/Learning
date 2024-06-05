using Base; // используем чтобы не писать перед классом: (пространство_имен).(класс)
using Base.PersonTypes;

class Program4
{
    static void Main(string[] args)
    {
        Base.OrganisationTypes.Company microsoft = new Base.OrganisationTypes.Company("Microsoft");
        Base.PersonTypes.Person tom = new Base.PersonTypes.Person("Tom", microsoft); // можно использовать: using Base;
        tom.Print();

        tom = new Base.PersonTypes.Person("Tom1", microsoft); // проверка на создание нового сегмента в хипе
        tom.Print();


    }




}

namespace Base
{
    namespace PersonTypes
    {
        class Person
        {
            string name;
            OrganisationTypes.Company company;
            public Person(string name, OrganisationTypes.Company company)
            {
                this.name = name;
                this.company = company;
            }
            public void Print()
            {
                Console.WriteLine($"Имя: {name} ");
                company.Print();
            }
        }
    }
    namespace OrganisationTypes
    {
        class Company
        {
            string title;
            public Company(string title) => this.title = title;
            public void Print() => Console.WriteLine($"Название компании: {title}");
        }
    }
}