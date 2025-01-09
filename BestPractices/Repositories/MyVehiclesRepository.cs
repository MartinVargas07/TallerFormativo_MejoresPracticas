using Best_Practices.Models;
using System.Collections.Generic;
using System.Linq;

namespace Best_Practices.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        private readonly List<Vehicle> _vehicles = new List<Vehicle>();
        private int _autoIncrementId = 1;

        public void Add(Vehicle vehicle)
        {
            vehicle.Id = _autoIncrementId++;
            _vehicles.Add(vehicle);
        }

        // Sobrecarga si vas a manejar Car directamente
        public void Add(Car car)
        {
            car.Id = _autoIncrementId++;
            _vehicles.Add(car);
        }

        public Vehicle GetById(int id)
        {
            return _vehicles.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _vehicles.ToList();
        }

        public void Update(Vehicle vehicle)
        {
            var existing = _vehicles.FirstOrDefault(v => v.Id == vehicle.Id);
            if (existing != null)
            {
                existing.Brand = vehicle.Brand;
                existing.Color = vehicle.Color;
                existing.Model = vehicle.Model;
                existing.Year = vehicle.Year;
            }
        }

        public void Delete(int id)
        {
            var existing = _vehicles.FirstOrDefault(v => v.Id == id);
            if (existing != null)
            {
                _vehicles.Remove(existing);
            }
        }
    }
}
