using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class VeterinaryClinic
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Dog> dogs { get; set; } 
        public List<Cat> cats { get; set; } 

        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Address = address;
            dogs = new List<Dog>();
            cats = new List<Cat>();
        }

        //Metodos para agregar
        public void SaveDog(Dog dog)
        {
            dogs.Add(dog);
        }
        public void SaveCat(Cat cat)
        {
            cats.Add(cat);
        }
        
        //Metodos para eliminar
        public void DeleteDog(Dog dog)
        {
            if (dogs.Contains(dog))
            {
                dogs.Remove(dog);
            }
            else
            {
                System.Console.WriteLine("Perro no encontrado.");
            }
        }
        public void DeleteCat(Cat cat)
        {
            if (cats.Contains(cat))
            {
                cats.Remove(cat);
            }
            else
            {
                System.Console.WriteLine("Perro no encontrado.");
            }
        }
    

        //Metodos para mostrar 
        public void ShowDogs()
        {
            foreach (var dog in dogs)
            {
                dog.ShowDetails();
            }
        }
        public void ShowCats()
        {
            foreach (var cat in cats)
            {
                cat.ShowDetails();
            }
        }
        // public void Show()
        // {
        //     foreach (var vehicle in vehicles)
        //     {
        //         vehicle.ShowDetails();
        //     }
        // }

        //Metodos para buscar
        public Cat GetCatById(int id)
        {
            return cats.FirstOrDefault(c => c.GetId() == id);
        }
        public Dog GetDogById(int id)
        {
            return dogs.FirstOrDefault(d => d.GetId() == id);
        }
    }
}