using System;

namespace HealthCheck.Data.Entities
{
    public class Person
    {
        protected Person() { }

        public Person(Guid id, string name, string lastName, int age)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public int Age { get; protected set; }
    }
}
