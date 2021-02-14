using System;

namespace Classes
{
    // Example of overloading
    public class Customer
    {
        public readonly Person Person;
        public int Id;
        public bool IsVip;
        public string FavoriteProduct;

        // Default constructor
        public Customer()
        {
            Id = new Random().Next(1, 1000);
            IsVip = false;
        }

        // Here's an example of Constructor Overloading
        // Each overload must be unique
        // public ClassName(Any arg) : this() will call the default constructor
        public Customer(Person person) : this()
        {
            this.Person = person;
        }

        public Customer(Person person, int id) : this(person)
        {
            this.Id = id;
        }

        public Customer(Person person, int id, bool isVip) : this(person, id)
        {
            this.IsVip = isVip;
        }

        public Customer(Person person, int id, bool isVip, string favoriteProduct) : this(person, id, isVip)
        {
            this.FavoriteProduct = favoriteProduct;
        }

        public void Buy(string thing)
        {
            string vipNotification = "";
            if (IsVip) vipNotification = "VIP | ";

            if (thing == FavoriteProduct)
                Console.WriteLine($"[{vipNotification}{Id}] {Person.Name} bought their favorite product — {FavoriteProduct}!");
            else
                Console.WriteLine($"[{vipNotification}{Id}] {Person.Name} bought {thing}");
        }
    }
}