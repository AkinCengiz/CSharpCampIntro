using System.Threading.Channels;
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

namespace Intro;

internal class Program
{
    private static void DrawLine()
    {
        Console.WriteLine("*****************************************************************************");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string message = "Krediler";
        int age = 42;
        double amount = 10000.50;

        bool isAuthenticated = true;

        //condition
        if (isAuthenticated)
        {
            Console.WriteLine("Hoşgeldin Akın...");
        }
        else
        {
            Console.WriteLine("Sisteme giriş yapınız...");
        }

        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8 vs...";
        course1.Price = 0;

        Course course2 = new()
        {
            Id = 2,
            Name = "Java",
            Description = "Java ile Nesne Yönelimli Programlama",
            Price = 100
        };
        Course course3 = new()
        {
            Id = 3,
            Name = "Python",
            Description = "Python ile Veri Bilimi",
            Price = 0
        };

        List<Course> courses = new List<Course>() { course1, course2, course3 };

        foreach (var item in courses)
        {
            Console.WriteLine($"{item.Id,-2} \t {item.Name,-10} \t {item.Description,-50} \t {item.Price,5}");
        }

        DrawLine();
        CourseManager coursesManager = new CourseManager(new EfCourseDal());
        
        //coursesManager.WriteAll();
        DrawLine();
        //coursesManager.WriteAll(coursesManager.GetAll());
        courses = coursesManager.GetAll();

        foreach (var item in courses)
        {
            Console.WriteLine($"{item.Id,-2} \t {item.Name,-10} \t {item.Description,-50} \t {item.Price,5}");
        }

        sbyte nbr = sbyte.MaxValue;
        Console.WriteLine("SByte : {0}",nbr);
        Console.WriteLine("Kod Bitti");
        DrawLine();
        IndividualCustomer customer = new IndividualCustomer();
        customer.Id = 1;
        customer.NationalIdentity = "12345678901";
        customer.FirstName = "Akın";
        customer.LastName = "CENGİZ";
        customer.CustomerNumber = "123456";

        IndividualCustomer customer2 = new IndividualCustomer();
        customer2.Id = 2;
        customer2.NationalIdentity = "10987654321";
        customer2.FirstName = "Engin";
        customer2.LastName = "DEMİROĞ";
        customer2.CustomerNumber = "654321";

        CorporateCustomer customer3 = new CorporateCustomer();
        customer3.Id = 3;
        customer3.Name = "KodlamaIO";
        customer3.CustomerNumber = "555555";
        customer3.TaxNumber = "1234567890";

        CorporateCustomer customer4 = new CorporateCustomer();
        customer4.Id = 4;
        customer4.Name = "Kodluyoruz";
        customer4.CustomerNumber = "444444";
        customer4.TaxNumber = "0123456789";

        int number1 = 10, number2 = 20;
        number1 = number2;
        number2 = 50;
        Console.WriteLine(number1.ToString());

        string[] cities1 = { "İstanbul", "İzmir", "Ankara" };
        string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };
        cities2 = cities1;
        cities1[2] = "Adana";
        Console.WriteLine(cities2[2]);

        BaseCustomer[] customers = { customer, customer2, customer3, customer4 };
        foreach (var cust in customers)
        {
            if (cust is IndividualCustomer)
            {
                Console.WriteLine(((IndividualCustomer)cust).FirstName + " " + cust.CustomerNumber);
            }
            else
            {
                Console.WriteLine(((CorporateCustomer)cust).Name + " " + cust.CustomerNumber);
            }
        }
    }
}
