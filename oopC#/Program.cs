using System.Security.Cryptography;
using System.Text;
using oopC_;
using oopC_.zoo;
using oopC_.zoo2;

internal class Program
{
    private static void Main(string[] args)
    {
        //DateTime dob1 = new DateTime(2000, 12, 3);
        //var c1 = new Customer("pippo", "de pippis", dob1, "via vannucci 3, 16123 Genova, Italy", "pippopippo@topoliniaonline.it");

        //c1.Mdp = PaymentMethod.Iban;

        //var c3 = new Customer("orazio", "de pippis", new DateTime(1999, 1, 1), "via vannucci 4, 16123 Genova, Italy", "orazio@topoliniaonline.it");

        //var c2 = new Customer("clarabella", "de pippis", 2001, 3, 23, "via vannucci 4, 16123 Genova, Italy", "claramoltobella@topoliniaonline.it");

        //var v1 = new VipCustomer("topolino", "mouse", 1990, 1, 30, "via gramsci 4, 16123 Genova, Italy", "granbeltopo@topoliniaonline.it", 10000);

        //var e1 = new Employee("paperino", "de paperis", 1980, 3, 23, "genova 1");

        //e1.Level = ExperienceLevels.Senior;


        //List<VipCustomer> vipCustomers = [];

        //vipCustomers.Add(v1);

        ////vipCustomers.Add(c1);

        //List<Customer> customers = new List<Customer>();

        //customers.Add(c1);
        //customers.Add(c3);
        //customers.Add(v1);


        ////foreach (var customer in customers)
        ////{
        ////    Console.WriteLine(customer.PrintAddress());
        ////}


        //List<Person> persons = new List<Person>();

        //persons.Add(c1);
        //persons.Add(c3);
        //persons.Add(v1);
        //persons.Add(e1);



        //var a1 = new BankAccount("123456789", v1, e1);

        //a1.Operate(1000);
        //a1.Operate(-500);
        //a1.Operate(2000);
        //a1.Operate(-1000);
        //a1.Operate(-500);
        //a1.Operate(10000);
        //a1.Operate(-2000);
        //a1.Operate(-10000);

        //Console.OutputEncoding = Encoding.Unicode;

        //Console.WriteLine(a1.generateReport());

        //var a2 = new CashBackAccount("987654321", c3, e1);

        //a2.Operate(1000);
        //a2.Operate(-500);
        //a2.Operate(2000);
        //a2.Operate(-1000);
        //a2.Operate(-500);
        //a2.Operate(10000);
        //a2.Operate(-2000);

        //Console.WriteLine(a2.generateReport());

        //var a3 = new SaveAccount("6666666", c2, e1);

        //a3.Operate(1000);
        //a3.Operate(-500);
        //a3.Operate(2000);
        //a3.Operate(-1000);
        //a3.Operate(-500);
        //a3.Operate(10000);
        //a3.Operate(-2000);

        //Console.WriteLine(a3.generateReport());

        //var duck1 = new Duck("paperina");
        //var duck2 = new Duck("paperino");
        //var duck3 = new Duck{Name = "PAPERONE"};
        //var dog1 = new Dog("pippo");
        //var dog2 = new Dog("pluto");

        var duck1 = new Beast("paperina", new QuackBehaviour());
        var duck2 = new Beast("paperino", new QuackBehaviour());
        var duck3 = new Beast("PAPERONE", new QuackBehaviour());
        var dog1 = new Beast("pippo", new WoofBehaviour());
        var dog2 = new Beast("pluto", new WoofBehaviour());

        var animals = new List<Beast>();
        animals.Add(duck1);
        animals.Add(duck2);
        animals.Add(duck3);
        animals.Add(dog1);
        animals.Add(dog2);

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Speak());
        }


    }
}