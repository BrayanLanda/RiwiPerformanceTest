using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class Cat : Animal
    {
        //Atributos
        public bool BreedingStatus { get; set; }
        public string FurLength { get; set; }

        //Contructor
        public Cat(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string furLength) : base (id, name, birthdate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            FurLength = furLength;
        }

        //Metodo para mostrar detalles
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Estado de la Cria: {BreedingStatus}");
            Console.WriteLine($"Longitud del pelaje: {FurLength}");
        }

        //Metodo para validar si esta castrado
        public void CastrateAnimal()
        {
            System.Console.WriteLine($"El gato {Name} esta castrado");
        }

        //Metodo para saber el estado del pelo
        public void Hairdress()
        {
            System.Console.WriteLine($"El gato {Name} esta motilado ");
        }
    }
}