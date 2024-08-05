using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryCenter.DataTest;
using VeterinaryCenter.Validations;

namespace VeterinaryCenter.Views
{
    public class ViewQueries
    {
        //Manu princial de los queries
        public int ShowQueriesMenu()
        {
            Console.Clear();
            ManagerApp.ShowHeader();
            Console.WriteLine("================ Gestion Consultas ================ ");
            Console.WriteLine("1. Castrar Perro");
            Console.WriteLine("2. Motilar Perro");
            Console.WriteLine("3. Castrar Gato");
            Console.WriteLine("4. Motilar Gato");
            Console.WriteLine("5. Volver al menú principal");
            Console.Write("Elija una opcion: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 5)
            {
                System.Console.Write("Opcion invalida, Intenta de nuevo: ");
            }
            return option;
        }

        //pra realizar una consulta por string
        public string GetNameIntForAction(string action)
        {
            string name;
            do
            {
                System.Console.Write($"Ingresa el nombre del registro a {action}: ");
                name = Console.ReadLine().Trim();
                if (!InputValidator.IsAlphabetic(name))
                {
                    System.Console.WriteLine("Nombre inválido. Solo se permiten letras y espacios.");
                }
            } while (!InputValidator.IsAlphabetic(name));

            return name;
        }
    }
}