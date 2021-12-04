using AnimalShelter_Labb2.Entities;
using System.Collections.Generic;

namespace AnimalShelter_Labb2.Repositories
{
    public interface IShelterRepository
    {
        IEnumerable<Dog> GetAllDogs();

        Dog GetDog(int id);
        bool AddDog(Dog dog);
        bool DeleteDog(string name);
        bool DeleteDog(int id);
        bool UpdateDog(int id, string name);
        




    }
}
