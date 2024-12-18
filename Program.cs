using System;
using EncapsulationOOP;

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("John Doe", 30, "Developer");
        person.DisplayPersonInfo();
        Person person2 = new Person("Jane Doe", 25, "Designer");
        person2.DisplayPersonInfo();
    }
}