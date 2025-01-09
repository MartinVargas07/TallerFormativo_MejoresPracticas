using Best_Practices.Models;

namespace Best_Practices.Infraestructure.Factories
{
    // Abstract Creator
    public abstract class Creator
    {
        public abstract Vehicle CreateVehicle();
    }
}
