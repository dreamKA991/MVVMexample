using System.Collections.Generic;
using System.ComponentModel;

namespace MVVMexample
{
    public class CarViewModel : INotifyPropertyChanged
    {
        private CarModel carModel;

        public List<Car> Cars => carModel.GetAllCars();

        public CarViewModel()
        {
            carModel = new CarModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddCar(string make, string model, int year)
        {
            carModel.AddCar(make, model, year);
            OnPropertyChanged(nameof(Cars));
        }

        public void RemoveCar(int index)
        {
            carModel.RemoveCar(index);
            OnPropertyChanged(nameof(Cars));
        }
    }
}
