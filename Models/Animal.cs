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

        //Gettin y setting
        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public DateOnly GetBirthdate()
        {
            return Birthdate;
        }
        public void SetBirthdate(DateOnly birthdate)
        {
            Birthdate = birthdate;
        }
        public string GetBreed()
        {
            return Breed;
        }
        public void SetBreed(string breed)
        {
            Breed = breed;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public double GetWeightInKg()
        {
            return WeightInKg;
        }
        public void SetWeightInKg(double weightInKg)
        {
            WeightInKg = weightInKg;
        }
    }
}