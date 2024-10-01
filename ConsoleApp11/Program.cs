// class object namespace using method
using People.Human;
using System;

class Program
{
    static void Main()
    {
        Person person1 = new Person();

        person1.height = 164.5;
        person1.age = 25;
        person1.name = "Joyce";

        Person person2 = new Person();

        person2.height = 179;
        person2.age = 25;
        person2.name = "Tom";

        //Console.WriteLine(person1.height);
        person1.SayHi();
        Console.WriteLine(person1.IsAdult());

        Console.WriteLine(person1.Add(2, 3, "Hi"));
    }
}
