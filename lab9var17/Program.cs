using System;
using System.Collections;
namespace lab9var17
{
    class Program
    {
        abstract class Vehicle
        {
            public int coordX, coordY;
            public int price, year, speed;
            public Vehicle()
            {
                coordX = 0;
                coordY = 0;
                price = 0;
                year = 0;
                speed = 0;
            }
            public Vehicle(int coordX, int coordY, int price, int year, int speed) : this()
            {
                this.coordX = coordX;
                this.coordY = coordY;
                this.price = price;
                this.year = year;
                this.speed = speed;
            }
            virtual public void GetInfo()
            {
                Console.WriteLine("\tКоордината X: " + coordX);
                Console.WriteLine("\tКоордината Y: " + coordY);
                Console.WriteLine("\tСтоимость: " + price);
                Console.WriteLine("\tГод выпуска: " + year);
                Console.WriteLine("\tСкорость: " + speed);
            }
            public int CoordX
            {
                get { return coordX; }
                set { coordX = value; }
            }
            public int CoordY
            {
                get { return coordY; }
                set { coordY = value; }
            }
            public int Price
            {
                get { return price; }
                set { price = value; }
            }
            public int Year
            {
                get { return year; }
                set { year = value; }
            }
            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }

        }
        
        class Plane : Vehicle
        {
            private int passengers;
            private int height;
            public Plane() : base()
            {
                passengers = 0;
                height = 0;
            }
            public Plane(int coordX, int coordY, int price, int year, int speed, int passengers, int height) : base(coordX, coordY, price, year, speed)
            {
                this.passengers = passengers;
                this.height = height;
            }

            override public void GetInfo()
            {
                Console.WriteLine("Информация о самолете");
                base.GetInfo();
                Console.WriteLine("\tКол-во пассажиров: " + passengers);
                Console.WriteLine("\tВысота: " + height + "\n");
            }

            public int Passengers
            {
                get { return passengers; }
                set { passengers = value; }
            }

            public int Height
            {
                get { return height; }
                set { height = value; }
            }
        }
        class Car : Vehicle
        {
            private int passengers;
            public Car() : base()
            {
                passengers = 0;
            }
            public Car(int coordX, int coordY, int price, int year, int speed, int passengers) : base(coordX, coordY, price, year, speed)
            {
                this.passengers = passengers;
            }

            override public void GetInfo()
            {
                Console.WriteLine("Информация о автомобиле");
                base.GetInfo();
                Console.WriteLine("\tКол-во пассажиров: " + passengers + "\n");
            }

            public int Passengers
            {
                get { return passengers; }
                set { passengers = value; }
            }


        }
        class Ship : Vehicle
        {
            private string port;
            public Ship() : base()
            {
                port = "";
            }
            public Ship(int coordX, int coordY, int price, int year, int speed, string port) : base(coordX, coordY, price, year, speed)
            {
                this.port = port;
            }
            override public void GetInfo()
            {
                Console.WriteLine("Информация о корабле");
                base.GetInfo();
                Console.WriteLine("\tПорт приписки: " + port + "\n");
            }
            public string Port
            {
                get { return port; }
                set { port = value; }
            }

        }

        static void Main(string[] args)
        {
            
            Ship ship = new Ship(300, 400, 2000000, 2001, 60, "Усть-Луга");
            ship.GetInfo();

            ship.CoordX = 23;
            ship.CoordY = 230;
            ship.Price = 2300;
            ship.Year = 1970;
            ship.Speed = 230000;
            Console.WriteLine("Каждый параметр был изменен с помощью метода set: ");
            ship.Port = "Дудинка";

            ship.GetInfo();

            Console.WriteLine("Метод get. Первые три параметра: ");
            Console.WriteLine("\t" + ship.CoordX);
            Console.WriteLine("\t" + ship.CoordY);
            Console.WriteLine("\t" + ship.Price + "\n");

            Car car = new Car(200, 300, 1000000, 2000, 50, 4);
            car.GetInfo();

            car.CoordX = 120000;
            car.CoordY = 233321;
            car.Price = 122212;
            car.Year = 1987;
            car.Speed = 2300;
            car.Passengers = 23;
            Console.WriteLine("Каждый параметр был изменен с помощью метода set: ");
            car.GetInfo();

            Console.WriteLine("Метод get. Первые три параметра: ");
            Console.WriteLine("\t" + car.CoordX);
            Console.WriteLine("\t" + car.CoordY);
            Console.WriteLine("\t" + car.Price + "\n");

            Plane plane = new Plane(100, 200, 3000000, 1999, 40, 100, 7000);
            plane.GetInfo();

            plane.CoordX = 5000;
            plane.CoordY = 6000;
            plane.Price = 3200000;
            plane.Year = 1947;
            plane.Speed = 230;
            plane.Passengers = 111;
            plane.Height = 9999;
            Console.WriteLine("Каждый параметр был изменен с помощью метода set: ");
            plane.GetInfo();

            Console.WriteLine("Метод get. Первые три параметра: ");
            Console.WriteLine("\t" + plane.CoordX);
            Console.WriteLine("\t" + plane.CoordY);
            Console.WriteLine("\t" + plane.Price + "\n");
        }

    }
}