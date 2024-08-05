using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class VeterinaryClinic
    {


        //Atributos de la clase
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Dog> dogs { get; set; } 
        public List<Cat> cats { get; set; } 

        int idCounter = 1;

        //Contructor
        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Address = address;
            dogs = new List<Dog>();
            cats = new List<Cat>();

            //Datos prueba perros
            dogs.Add(new Dog(idCounter++, "Saimon", new DateOnly(2018, 8, 9), "Criollo", "Blanco", 2.5, false, "TIMIDO", "2569", "sin pelo", "sin pelo"));
            dogs.Add(new Dog(idCounter++, "Saimon", new DateOnly(2015, 6, 4), "Pitbull", "Negro", 4.5, true, "AGRESIVO", "1685", "pelo largo", "pelo largo"));
            dogs.Add(new Dog(idCounter++, "Saimon", new DateOnly(2015, 6, 4), "Labrador", "Gris", 6.9, true, "NORMAL", "8585", "pelo corto", "pelo corto"));

            //Datos prueba Gatos
            cats.Add(new Cat(idCounter++, "Simon", new DateOnly(2018, 8, 9), "Angora", "Blanco", 2.5, false,"sin pelo"));
            cats.Add(new Cat(idCounter++, "Chanel", new DateOnly(2015, 1, 25), "Criolla", "Gris y Blanco", 1.5, false,"pelo corto"));
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
                System.Console.WriteLine("-------------------------------------");
                dog.ShowDetails();
                System.Console.WriteLine("-------------------------------------");
            }
        }
        public void ShowCats()
        {
            foreach (var cat in cats)
            {
                System.Console.WriteLine("-------------------------------------");
                cat.ShowDetails();
                System.Console.WriteLine("-------------------------------------");
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

        //Datos de pruebas

        
        // public VeterinaryClinic()
        // {
            
        // }
    }
}