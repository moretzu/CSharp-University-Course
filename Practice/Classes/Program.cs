using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Riku");
            person.Introduce("reader");

            var customer = new Customer(person);
            customer.Buy("Sublime license");

            var person2 = new Person("Saya");
            person2.Introduce("everyone");

            var customer2 = new Customer(person2, 1530, true, "green tea");
            customer2.Buy("green tea");

            var r = new Random();
            var customer3 = new BetterCustomer(r.Next(1, 1000)) { Person = person };
            customer3.Order("pizza with pineapples");
        }
    }
}
