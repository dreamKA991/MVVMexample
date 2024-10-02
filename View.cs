using System;

namespace MVVMexample
{
    public class CarView
    {
        private CarViewModel viewModel;

        public CarView()
        {
            viewModel = new CarViewModel();
        }

        public void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Меню управління автомобілями:");
                Console.WriteLine("1. Показати всі автомобілі");
                Console.WriteLine("2. Додати автомобіль");
                Console.WriteLine("3. Видалити автомобіль");
                Console.WriteLine("4. Вийти");
                Console.Write("Виберіть дію (1-4): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowAllCars();
                        break;
                    case "2":
                        AddCar();
                        break;
                    case "3":
                        RemoveCar();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nНатисніть будь-яку клавішу, щоб продовжити...");
                    Console.ReadKey();
                }
            }
        }

        private void ShowAllCars()
        {
            Console.WriteLine("Список автомобілів:");
            var cars = viewModel.Cars;
            for (int i = 0; i < cars.Count; i++)
            {
                var car = cars[i];
                Console.WriteLine($"{i}. {car.Make} {car.Model}, рік: {car.Year}");
            }
        }

        private void AddCar()
        {
            Console.Write("Введіть марку автомобіля: ");
            string make = Console.ReadLine();
            Console.Write("Введіть модель автомобіля: ");
            string model = Console.ReadLine();
            Console.Write("Введіть рік випуску: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                viewModel.AddCar(make, model, year);
                Console.WriteLine("Машина додана успішно.");
            }
            else
            {
                Console.WriteLine("Невірний рік.");
            }
        }

        private void RemoveCar()
        {
            Console.Write("Введіть індекс автомобіля для видалення: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                viewModel.RemoveCar(index);
                Console.WriteLine("Машина видалена.");
            }
            else
            {
                Console.WriteLine("Невірний індекс.");
            }
        }
    }
}
