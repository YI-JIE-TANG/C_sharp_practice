namespace ConsoleApp13
{
    class Person
    {
        public double height;
        public int age;
        public string name { get; set; } = string.Empty;

        public Person(double hight, int age, string name) // public Person(double h, int a, string n)
        {
            //height = h;
            //age = a;
            //name = n;
            this.height = hight;
            this.age = age;
            this.name = name;

        }
    
    }
}
