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

        //Metodo para validar si esta castrado
        public void CastrateAnimal()
        {

        }

        //Metodo para saber el color del vestido
        public void Hairdress()
        {

        }
    }
}