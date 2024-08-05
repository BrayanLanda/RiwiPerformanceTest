using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryCenter.DataTest;
using VeterinaryCenter.Models;
using VeterinaryCenter.Validations;

namespace VeterinaryCenter.Views
{
    public class CatView
    {
        //Metodo para mostrar accion a realizar
        public int ShowCatMenu()
        {
            Console.Clear();
            ManagerApp.ShowHeader();
            Console.WriteLine("================ Gestion Gatos ================ ");
            Console.WriteLine("1. Mostrar gatos");
            Console.WriteLine("2. Agregar gato");
            Console.WriteLine("3. Eliminar gato");
            Console.WriteLine("4. Buscar gato");
            Console.WriteLine("5. Editar gato");
            Console.WriteLine("6. Volver al menú principal");
            Console.Write("Elija una opcion: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 6)
            {
                System.Console.Write("Opcion invalida, Intenta de nuevo: ");
            }
            return option;
        }

        //Metodo para agregar o editar un gato
        public Cat GetCatInfo(Cat cat = null)
        {
            Console.Clear();
            System.Console.WriteLine(cat == null ? "==== Agregar un nuevo gato ====" : "==== Editar un gato ====");

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

            string furLength;
            do
            {
                System.Console.Write("Tipo de Pelo (SIN PELO/PELO CORTO/PELO MEDIANO/PELO LARGO ): ");
                furLength = Console.ReadLine().Trim().ToUpper();
                if (furLength != "SIN PELO" && furLength != "PELO CORTO" && furLength != "PELO MEDIANO" && furLength != "PELO LARGO") 
                System.Console.WriteLine("Tipo de pelo invalido. Intente de nuevo.");
            } while (furLength != "SIN PELO" && furLength != "PELO CORTO" && furLength != "PELO MEDIANO" && furLength != "PELO LARGO");

            int id = 1;

            if (cat == null)
            {
                return new Cat(id, name, hireDate, breed, color, weight, status, furLength);
            }
            else
            {
                //Actualizar datos del cat existente
                cat.SetId(id);
                cat.SetName(name);
                cat.SetBirthdate(hireDate);
                cat.SetBreed(breed);
                cat.SetColor(color);
                cat.SetWeightInKg(weight);
                cat.BreedingStatus = status;
                cat.FurLength = furLength;

                return cat;
            }
        }
    }
}