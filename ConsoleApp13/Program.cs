// Constructor 建構方法, 
using ConsoleApp13;
using System;
/*
namespace ConsoleApp13
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person(164.5, 25, "Joyce");
            Person person2 = new Person(179, 25, "Tom");

            Console.WriteLine(person1.name);
            Console.WriteLine(person2.name);
        }
    }

}
*/
// getter setter

Video video1 = new Video("Hello World", "Joyce", "CC");
Video video2 = new Video("Singing", "Tom", "Music");

video1.Type = "Education";

Console.WriteLine(video1.Type);