using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab9var17
{
    class Program
    {
        abstract class Vehicle : IComparable
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

            virtual public int CompareTo(object obj)
            {
                Vehicle temp = (Vehicle)obj;
                return price.CompareTo(temp.price);
            }

            virtual public string GetInfo()
            {
                return "\nКоордината X: " + coordX + "\nКоордината Y: " + coordY +
                    "\nСтоимость: " + price + "\nГод выпуска: " + year + "\nСкорость: " + speed;
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType()) return false;
                Vehicle temp = (Vehicle)obj;
                return coordX == temp.coordX && coordY == temp.coordY;
            }
            public override int GetHashCode()
            {
                return price.GetHashCode();
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

            public static bool operator ==(Vehicle a, Vehicle b)
            {
                return (a.CompareTo(b) == 0);
            }
            public static bool operator !=(Vehicle a, Vehicle b)
            {
                return (a.CompareTo(b) != 0);
            }
            public static bool operator <(Vehicle a, Vehicle b)
            {
                return (a.CompareTo(b) < 0);
            }
            public static bool operator >(Vehicle a, Vehicle b)
            {
                return (a.CompareTo(b) > 0);
            }
            public static bool operator <=(Vehicle a, Vehicle b)
            {
                return (a.CompareTo(b) <= 0);
            }
            public static bool operator >=(Vehicle a, Vehicle b)
            {
                return (a.CompareTo(b) >= 0);
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
            public override int CompareTo(object obj)
            {
                Plane temp = (Plane)obj;
                return price.CompareTo(temp.price);
            }
            override public string GetInfo()
            {
                return "Информация о самолете" + base.GetInfo() +
                    "\nКол-во пассажиров: " + passengers + "\nВысота: " + height + "\n";
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
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType()) return false;
                Plane temp = (Plane)obj;
                return coordX == temp.coordX && coordY == temp.coordY;
            }
            public override int GetHashCode()
            {
                return price.GetHashCode();
            }
            public static bool operator ==(Plane a, Plane b)
            {
                return (a.CompareTo(b) == 0);
            }
            public static bool operator !=(Plane a, Plane b)
            {
                return (a.CompareTo(b) != 0);
            }
            public static bool operator <(Plane a, Plane b)
            {
                return (a.CompareTo(b) < 0);
            }
            public static bool operator >(Plane a, Plane b)
            {
                return (a.CompareTo(b) > 0);
            }
            public static bool operator <=(Plane a, Plane b)
            {
                return (a.CompareTo(b) <= 0);
            }
            public static bool operator >=(Plane a, Plane b)
            {
                return (a.CompareTo(b) >= 0);
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
            public override int CompareTo(object obj)
            {
                Car temp = (Car)obj;
                return price.CompareTo(temp.price);
            }
            override public string GetInfo()
            {
                return "Информация о автомобиле" + base.GetInfo() +
                    "\nКол-во пассажиров: " + passengers + "\n";
            }
            public int Passengers
            {
                get { return passengers; }
                set { passengers = value; }
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType()) return false;
                Car temp = (Car)obj;
                return coordX == temp.coordX && coordY == temp.coordY;
            }
            public override int GetHashCode()
            {
                return price.GetHashCode();
            }
            public static bool operator ==(Car a, Car b)
            {
                return (a.CompareTo(b) == 0);
            }
            public static bool operator !=(Car a, Car b)
            {
                return (a.CompareTo(b) != 0);
            }
            public static bool operator <(Car a, Car b)
            {
                return (a.CompareTo(b) < 0);
            }
            public static bool operator >(Car a, Car b)
            {
                return (a.CompareTo(b) > 0);
            }
            public static bool operator <=(Car a, Car b)
            {
                return (a.CompareTo(b) <= 0);
            }
            public static bool operator >=(Car a, Car b)
            {
                return (a.CompareTo(b) >= 0);
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
            public override int CompareTo(object obj)
            {
                Ship temp = (Ship)obj;
                return price.CompareTo(temp.price);
            }
            override public string GetInfo()
            {
                return "Информация о корабле" + base.GetInfo() +
                    "\nПорт приписки: " + port + "\n";
            }
            public string Port
            {
                get { return port; }
                set { port = value; }
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType()) return false;
                Ship temp = (Ship)obj;
                return coordX == temp.coordX && coordY == temp.coordY;
            }
            public override int GetHashCode()
            {
                return price.GetHashCode();
            }
            public static bool operator ==(Ship a, Ship b)
            {
                return (a.CompareTo(b) == 0);
            }
            public static bool operator !=(Ship a, Ship b)
            {
                return (a.CompareTo(b) != 0);
            }
            public static bool operator <(Ship a, Ship b)
            {
                return (a.CompareTo(b) < 0);
            }
            public static bool operator >(Ship a, Ship b)
            {
                return (a.CompareTo(b) > 0);
            }
            public static bool operator <=(Ship a, Ship b)
            {
                return (a.CompareTo(b) <= 0);
            }
            public static bool operator >=(Ship a, Ship b)
            {
                return (a.CompareTo(b) >= 0);
            }
        }

        static void Main(string[] args)
        {
            #region объявление экземпляров класса
            List<Ship> ship = new List<Ship>();
            ship.Add(new Ship(300, 400, 2000000, 2001, 60, "Усть-Луга"));
            ship.Add(new Ship(23, 230, 2300, 1970, 230000, "Дудинка"));

            List<Car> car = new List<Car>();
            car.Add(new Car(200, 300, 1000000, 2000, 50, 4));
            car.Add(new Car(200, 300, 1000000, 2000, 50, 4));

            List<Plane> plane = new List<Plane>();
            plane.Add(new Plane(100, 200, 3000000, 1999, 40, 100, 7000));
            plane.Add(new Plane(5000, 6000, 3200000, 1947, 230, 111, 9999));
            #endregion

            #region вывод полей экземляров
            Console.WriteLine("Вывод информации");
            foreach (Ship el in ship) Console.WriteLine(el.GetInfo());
            foreach (Car el in car) Console.WriteLine(el.GetInfo());
            foreach (Plane el in plane) Console.WriteLine(el.GetInfo());
            #endregion

            #region проверка метода Equals
            Console.WriteLine("Метод Equals");
            Console.WriteLine("point1 == point2: " + ship.ElementAt(0).Equals(ship.ElementAt(1)));
            Console.WriteLine("car1 == car2: " + car.ElementAt(0).Equals(car.ElementAt(1)));
            Console.WriteLine("plane1 == plane2: " + plane.ElementAt(0).Equals(plane.ElementAt(1)));
            #endregion

            #region вывод отсортированных полей экземляров
            Console.WriteLine("\nПереопредление скорости и координатов с помощью set каждого первого объекта");
            ship.ElementAt(0).speed = 999;
            ship.ElementAt(0).coordX = 999;
            ship.ElementAt(0).coordY = 999;

            car.ElementAt(0).speed = 999;
            car.ElementAt(0).coordX = 999;
            car.ElementAt(0).coordY = 999;

            plane.ElementAt(0).speed = 999;
            plane.ElementAt(0).coordX = 999;
            plane.ElementAt(0).coordY = 999;
            #endregion

            #region вывод отсортированных полей экземляров
            Console.WriteLine("Метод CompareTo с помощью сортировки (Сортировка по цене)");
            ship.Sort();
            car.Sort();
            plane.Sort();
            foreach (Ship el in ship) Console.WriteLine(el.GetInfo());
            foreach (Car el in car) Console.WriteLine(el.GetInfo());
            foreach (Plane el in plane) Console.WriteLine(el.GetInfo());
            #endregion
        }

    }
}