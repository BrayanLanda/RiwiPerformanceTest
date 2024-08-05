using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class Animal
    {
        //Atributos de clase pricipal
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Breed { get; set; }
        protected string Color { get; set; }
        protected double WeightInKg { get; set; }

        //Contructor
        public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        //Show Details
        public virtual void ShowDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Fecha de Nacimiento: {Birthdate}");
            System.Console.WriteLine($"Edad: {CalculateAgeInMonths()} años");
            Console.WriteLine($"Raza: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso en Kilos: {WeightInKg}");
        }

        //Metodo para calcular la edad y mostrarla
        protected int CalculateAgeInMonths()
        {
            int age = DateTime.Today.Year - Birthdate.Month;
            if (DateTime.Today.Month < Birthdate.Month || (DateTime.Today.Month == Birthdate.Month && DateTime.Today.Day < Birthdate.Day))
            {
                age--;
            }
            return age;
        }

        //Metodo revision basica
        public virtual void BasicReview()
        {

        }
    }
}