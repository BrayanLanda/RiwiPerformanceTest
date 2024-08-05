using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryCenter.DataTest;
using VeterinaryCenter.Models;
using VeterinaryCenter.Validations;

namespace VeterinaryCenter.Views
{
    public class DogView
    {
        public int idCounter { get; set; } = 7;
        //Metodo Para mostrar perrors   
        public int ShowDogMenu()
        {
            Console.Clear();
            ManagerApp.ShowHeader();
            Console.WriteLine("================ Gestion Perros ================");
            Console.WriteLine("1. Mostrar perros");
            Console.WriteLine("2. Agregar perro");
            Console.WriteLine("3. Eliminar perro");
            Console.WriteLine("4. Buscar perro");
            Console.WriteLine("5. Editar perro");
            Console.WriteLine("6. Volver al menú principal");
            Console.Write("Elija una opcion: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 6)
            {
                System.Console.Write("Opcion invalida, Intenta de nuevo: ");
            }
            return option;
        }

        //Metodo para agregar o editar un perro
        public Dog GetDogInfo(Dog dog = null)
        {
            Console.Clear();
            System.Console.WriteLine(dog == null ? "==== Agregar un nuevo perro ====" : "==== Editar un perro ====");

            string name;
            do
            {
                System.Console.Write("Nombre: ");
                name = Console.ReadLine().Trim();
                if (!InputValidator.IsAlphabetic(name))
                {
                    System.Console.WriteLine("Nombre inválido. Solo se permiten letras y espacios.");
                }
            } while (!InputValidator.IsAlphabetic(name));

            System.Console.Write("Fecha de Nacimiento (YYYY-MM-DD): ");
            DateOnly hireDate;
            while (!DateOnly.TryParse(Console.ReadLine(), out hireDate))
            {
                System.Console.Write("Formato invalido. Intente de nuevo (YYYY-MM-DD): ");
            }

            string breed;
            do
            {
                System.Console.Write("Raza: ");
                breed = Console.ReadLine().Trim();
                if (!InputValidator.IsAlphabetic(breed))
                {
                    System.Console.WriteLine("Raza inválido. Solo se permiten letras y espacios.");
                }
            } while (!InputValidator.IsAlphabetic(breed));

            string color;
            do
            {
                System.Console.Write("Color: ");
                color = Console.ReadLine().Trim();
                if (!InputValidator.IsAlphabetic(color))
                {
                    System.Console.WriteLine("Nombre inválido. Solo se permiten letras y espacios.");
                }
            } while (!InputValidator.IsAlphabetic(color));

            System.Console.Write("Peso (Ej: 5.0): ");
            double weight;
            while (!Double.TryParse(Console.ReadLine(), out weight))
            {
                System.Console.Write("Formato invalido. Intente de nuevo (Ej: 5.0, 11.0): ");
            }

            System.Console.Write("Estado de la cria: ");
            bool status;
            while (!Boolean.TryParse(Console.ReadLine(), out status))
            {
                System.Console.Write("Formato invalido. Intente de nuevo: ");
            }

            string temperament;
            do
            {
                System.Console.Write("Tipo de Temperamento (TIMIDO/NORMAL/AGRESIVO ): ");
                temperament = Console.ReadLine().Trim().ToUpper();
                if (temperament != "TIMIDO" && temperament != "NORMAL" && temperament != "AGRESIVO")
                    System.Console.WriteLine("Tipo de pelo invalido. Intente de nuevo.");
            } while (temperament != "TIMIDO" && temperament != "NORMAL" && temperament != "AGRESIVO");

            string microchipNumber;
            do
            {
                System.Console.Write("Numero de microchip: ");
                microchipNumber = Console.ReadLine().Trim();
                if (!InputValidator.IsNumeric(microchipNumber))
                {
                    System.Console.WriteLine("Número de microchip inválido. Solo se permiten números.");
                }
            } while (!InputValidator.IsNumeric(microchipNumber));

            // string barkVolume;
            // do
            // {
            //     System.Console.Write("Tipo de Pelo (SIN PELO/PELO CORTO/PELO MEDIANO/PELO LARGO ): ");
            //     barkVolume = Console.ReadLine().Trim().ToUpper();
            //     if (barkVolume != "SIN PELO" && barkVolume != "PELO CORTO" && barkVolume != "PELO MEDIANO" && barkVolume != "PELO LARGO")
            //         System.Console.WriteLine("Tipo de pelo invalido. Intente de nuevo.");
            // } while (barkVolume != "SIN PELO" && barkVolume != "PELO CORTO" && barkVolume != "PELO MEDIANO" && barkVolume != "PELO LARGO");

            string coatType;
            do
            {
                System.Console.Write("Tipo de Pelo (SIN PELO/PELO CORTO/PELO MEDIANO/PELO LARGO ): ");
                coatType = Console.ReadLine().Trim().ToUpper();
                if (coatType != "SIN PELO" && coatType != "PELO CORTO" && coatType != "PELO MEDIANO" && coatType != "PELO LARGO")
                    System.Console.WriteLine("Tipo de pelo invalido. Intente de nuevo.");
            } while (coatType != "SIN PELO" && coatType != "PELO CORTO" && coatType != "PELO MEDIANO" && coatType != "PELO LARGO");

            string barkVolume = coatType;

            int id = idCounter * 24 + idCounter++;
            //Enviar datos para creacion de perro
            if (dog == null)
            {
                return new Dog(id, name, hireDate, breed, color, weight, status, temperament, microchipNumber, barkVolume, coatType);
            }
            else
            {
                //Actualizar datos del perro existente
                dog.SetId(id);
                dog.SetName(name);
                dog.SetBirthdate(hireDate);
                dog.SetBreed(breed);
                dog.SetColor(color);
                dog.SetWeightInKg(weight);
                dog.BreedingStatus = status;
                dog.Temperament = temperament;
                dog.MicrochipNumber = microchipNumber;
                return dog;
            }
        }
    }
}