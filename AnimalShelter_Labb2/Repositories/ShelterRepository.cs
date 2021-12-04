using AnimalShelter_Labb2.Entities;
using System.Collections.Generic;

namespace AnimalShelter_Labb2.Repositories
{
    public class ShelterRepository : IShelterRepository
    {
        private List<Dog> _dogs = new List<Dog>() {
        new() { Id = 1, Name = "Krypto"},
        new() { Id = 2, Name = "Winston"},
        new() { Id = 3, Name = "Opie"},
        };

        public bool AddDog(Dog dog)
        {
            var isOk = !_dogs.Contains(dog);
            if (isOk)
            {
                _dogs.Add(dog);
            }
            return isOk;
        }

        public bool DeleteDog(string name)
        {
            var pos = _dogs.FindIndex(dog => dog.Name == name);
            var isOk = pos >= 0;
            if (isOk)
            {
                _dogs.RemoveAt(pos);
            }
            return isOk;
        }

        public bool DeleteDog(int id)
        {
            var pos = _dogs.FindIndex(dog => dog.Id == id);
            var isOk = pos >= 0;
            if (isOk)
            {
                _dogs.RemoveAt(pos);
            }
            return isOk;
        }



        public IEnumerable<Dog> GetAllDogs()
        {
            return _dogs;
        }

        public Dog GetDog(int id)
        {
            var pos = _dogs.FindIndex(x => x.Id == id);
            if (pos != -1)
            {
                return _dogs[pos];

            }
            else
            {
                return null;

            }

        }

        public bool UpdateDog(int id, string name)
        {
            var pos = _dogs.FindIndex(dog => dog.Id == id);
            var isOk = pos >= 0;
            if (isOk)
            {
                _dogs[pos].Name = name;
            }
            return isOk;
        }
    }
}
