using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class Dog : Animal
    {
        //Atributos clase
        public bool BreedingStatus { get; set; }
        public string Temperament { get; set; }
        public string MicrochipNumber { get; set; }
        public string BarkVolume { get; set; }
        public string CoatType { get; set; }

        //Contructor
        public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) : base (id, name, birthdate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            Temperament = temperament;
            MicrochipNumber = microchipNumber;
            BarkVolume = barkVolume;
            CoatType = coatType;
        }

         //Metodo para mostrar detalles
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Estado de la Cria: {BreedingStatus}");
            Console.WriteLine($"Temperamento: {Temperament}");
            Console.WriteLine($"Estado de la Cria: {BreedingStatus}");
            Console.WriteLine($"Numero de micropchip: {MicrochipNumber}");
            Console.WriteLine($"Volumen: {BarkVolume}");
            Console.WriteLine($"Tipo de pelaje: {CoatType}");
        }

        //Metodo para validar si esta castrado
        public void CastrateAnimal()
        {

        }

        //Metodo para saber el estado del pelo
        public void Hairdress()
        {

        }
    }
}