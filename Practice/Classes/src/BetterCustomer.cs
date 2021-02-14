using System;
using System.Collections.Generic;

namespace Classes
{
    public class BetterCustomer
    {
        public int Id;
        public Person Person { get; set; }
        public List<string> Orders
        {
            get { return new List<string>(); }
        }

        public BetterCustomer(int id)
        {
            this.Id = id;
        }

        public void Order(string thing)
        {
            string orderer = (this.GetType().GetProperty("Person") == null) ? Id.ToString() : Person.Name;
            Orders.Add(thing);

            Console.WriteLine($"[{Id}] {Person.Name} ordered {thing}");
        }
    }
}