using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_Lesson14
{
    class Program
    {
        class Person
        {
            public static int count = 0;
            public string name;
            public int age;
            public string gender;

            public void showInfo()
            {
                Console.WriteLine("{0}  {1}  {2} ", name, age, gender);
            }

            public Person()
            {
                Console.WriteLine("Person created");
                count++;
            }

            public Person(string name, int age, string gender)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
            }

            public static void showCount()
            {
                Console.WriteLine(count);
            }
        }

        class Car
        {
            
            public string mark { get; set; }
            public string colour { get; set; }
            public Engine engine { get; set; }

            private int _wheels;
            public int wheels
            {
                get { return _wheels; }
                set { _wheels = value * 2; }
            }

            public Car()
            {
                _wheels = 4;
            }

            public double getMaxSpeed()
            {
                double result = (engine.power * wheels) / 8;
                return result;
            }
        }

        class Engine
        {
            public int power { get; set;}
            public string manufacture { get; set; }

        }

        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.manufacture = "Motors";
            engine.power = 500;

            Car huyndai = new Car();
            huyndai.mark = "Getz";
            huyndai.colour = "Green";
            //huyndai.wheels = 4;
            huyndai.engine = engine;

            Console.WriteLine(huyndai.getMaxSpeed());
            


            /*
            Person p1 = new Person();
            //p1.name = "Ivan";
            //p1.age = 32;
            //p1.gender = "Man";
            //p1.showInfo(); 
            Person.showCount();

            Person p2 = new Person();
            Person.showCount();
            Person p3 = new Person();
            Person.showCount();
            */



        }
    }
}
