using System;

namespace Classes
{
    // Basic example of a class
    public class Person
    {
        public readonly string Name;

        // Constructor of the class
        public Person(string name)
        {
            this.Name = name;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I'm {1}!", to, Name);
        }
    }
}