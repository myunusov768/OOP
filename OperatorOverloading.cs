using System;

namespace OOP
{
    public sealed class OperatorOverloading
    {
        
        public void Checked()
        {
            Car car1 = new Car() { Model = "Lexus", Price = 10000, Age = 2010 };
            Car car2 = new Car() { Model = "Toyota", Price = 8000, Age = 2008 };
            Car car3 = new Car() { Model = "Toyota", Price = 5000, Age = 2008 };

            bool Bulian = car1 == car2;
            bool Bulian1 = car1 == car2;
            Console.WriteLine(Bulian);
            Console.WriteLine(Bulian1);
            Console.WriteLine(car1);
            car1++;
            car2--;
            var car4 = car2 + car3;

            Console.WriteLine(car4.Price);

            Car car5 = (Car)2500;
            int price = car5;
            Console.WriteLine(car5);
            Console.WriteLine(price);

            
        }


    }



    public sealed class Car
    {
        public string Model { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Age.ToString();
        }
        

        public static bool operator ==(Car leftOperend, Car rightOperend) 
        {
            if (leftOperend.Model == rightOperend.Model
                && leftOperend.Price == rightOperend.Price
                && leftOperend.Age == rightOperend.Age) return true;
            return false;
        }
        public static bool operator !=(Car leftOperend, Car rightOperend)
        {
            if (leftOperend.Model == rightOperend.Model
                && leftOperend.Price == rightOperend.Price
                && leftOperend.Age == rightOperend.Age) return false;
            return true;
            
        }
        public static Car operator ++(Car operend)
        {
            operend.Age++;
            return operend;
        }
        public static Car operator --(Car operend)
        {
            operend.Age--;
            return operend;
        }
        public static Car operator +(Car leftOperend, Car rightOperend)
        {
            return new Car() { Price = leftOperend.Price + rightOperend.Price };   
        }

        public static implicit operator int (Car car) { return car.Price;}
        public static explicit operator Car(int price) { return new Car() { Price = price }; }


        /*
        public static implicit|explicit operator Тип_в_который_надо_преобразовать(исходный_тип param)
        {
            // логика преобразования
        }
        */


    }
}
