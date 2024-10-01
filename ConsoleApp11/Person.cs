using System;

namespace People
{
    namespace Human
    {
        class Person
        {
            public double height;
            public int age;
            public string name { get; set; } = string.Empty;

            public void SayHi()
            {
                Console.WriteLine("Hello, my name is " +name);
            }

            public bool IsAdult()
            {
                if (age >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int Add(int num1,int num2, string s)
            {
                return num1 + num2;
            }
        }
    }

}


