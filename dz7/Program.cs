using System;

namespace dz7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите своё имя ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите вашу фамилию ");
            string surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Год рождение ");
            string age = Convert.ToString(Console.ReadLine());
            var students = new Students(id, name, surname, age);
            students.GetInfo();

        }
    }
    class Students
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        public Students(int id, string name, string surname, string age)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;

        }
        public void GetInfo()
        {
            Console.WriteLine(value: $"id:{id},\n name:{name},\n surnameame:{surname},\nage: {age} ");
        }

    }
}
