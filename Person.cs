using System;

namespace EncapsulationOOP;

public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Role { get; private set; }

    public Person(string name, int age, string role)
    {
        SetName(name);
        SetAge(age);
        SetRole(role);
    }

    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("Name cannot be null or empty");
        }

        Name = name;
    }

    public void SetAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentOutOfRangeException("Age cannot be less than 0");
        }

        Age = age;
    }

    public void SetRole(string role)
    {
        if (string.IsNullOrEmpty(role))
        {
            throw new ArgumentNullException("Role cannot be null or empty");
        }

        Role = role;
    }   
     public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Role: {Role}");
    }
}
