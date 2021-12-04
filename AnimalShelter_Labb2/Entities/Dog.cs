using System;

namespace AnimalShelter_Labb2.Entities
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Dog dog && Id == dog.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
