using System.Collections.Generic;

namespace MVVMexample
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }

    public class CarModel
    {
        private List<Car> cars;

        public CarModel()
        {
            cars = new List<Car>
            {
                new Car("Toyota", "Corolla", 2020),
                new Car("Ford", "Mustang", 2022),
                new Car("Honda", "Civic", 2018),
                new Car("BMW", "X5", 2021),
                new Car("Mercedes", "C-Class", 2019)
            };
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public void AddCar(string make, string model, int year)
        {
            cars.Add(new Car(make, model, year));
        }

        public void RemoveCar(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                cars.RemoveAt(index);
            }
        }
    }
}
