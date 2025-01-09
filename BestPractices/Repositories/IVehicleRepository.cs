using Best_Practices.Models;
using System.Collections.Generic;

namespace Best_Practices.Repositories
{
    public interface IVehicleRepository
    {
        void Add(Vehicle vehicle);
        void Add(Car car); // adicional si quieres manejar Car directamente

        Vehicle GetById(int id);
        IEnumerable<Vehicle> GetAll();

        void Update(Vehicle vehicle);
        void Delete(int id);
    }
}
