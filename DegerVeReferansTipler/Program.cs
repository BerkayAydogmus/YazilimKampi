using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            ////int,decimal,float,enum,boolean değer tiptir.value type. stack de olur
            //int sayi1 = 10; // sayi 1 değeri eşittir 10
            //int sayi2 = 30; // sayi 2 değeri eşittir 30
            //sayi1 = sayi2; // sayi 1 in değeri eşittir sayi 2 nin değerine
            //sayi2 = 65; // sayi 2 değeri eşittir 65
            //Console.WriteLine(sayi1); // sayi1 = 30

            ////array,class,interface referance type stack+heap de olur 
            //int[] sayilar1 = new int[] { 10, 20, 30 };
            //int[] sayilar2 = new int[] { 100, 200, 300 };
            //sayilar1 = sayilar2; // sayilar1 in adresini sayilar2 nin adresi ile değiştiriyoruz.
            //sayilar2[0] = 999; // sayilar2 nin adresinin 1. elemanı 999.
            //Console.WriteLine(sayilar1[0]);
            //Console.WriteLine(sayilar2[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "BERKAY";
            person2 = person1;
            person1.FirstName = "İLKAY";


           // Console.WriteLine(person2.FirstName);
           // Console.WriteLine(person1.FirstName);


            Costumer costumer = new Costumer();
            costumer.FirstName = "AHMET";
            costumer.CreditCardNumber = "1351321312";
            Costumer costumer2 = new Costumer();
            costumer2.FirstName = "BACİİİİYEAAHHHH";


            Employee employee = new Employee();

            employee.FirstName = "velii";

            Person person3 = costumer;
            //Console.WriteLine(person3.FirstName);

            //Console.WriteLine(((Costumer)person3).CreditCardNumber);


            PersonManager personManager = new PersonManager();
            personManager.Add(costumer2);
            personManager.Add(employee);




        }

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Costumer:Person

    {
        public string CreditCardNumber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
