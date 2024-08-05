using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Views
{
    public class MainView
    {
        //Vista principal
        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("============= Clinica Veterinaria ============= ");
            Console.WriteLine("1. Gestionar Gatos");
            Console.WriteLine("2. Gestionar Perros");
            Console.WriteLine("3. Gestionar Macotas");
            Console.WriteLine("4. Salir");
            Console.Write("Elija una opcion: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4)
            {
                System.Console.Write("Opcion invalida, intenta de nuevo: ");
            }
            return option;
        }

        //Solicitar un id para editar o eliminar
        public int GetIdIntForAction(string action)
        {
            System.Console.Write($"Ingresa el id del registro a {action}: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Id invalido. Intente de nuevo: ");
            }
            return id;
        }

        //Monstrar mensaje y esperar confirmacion del usuario
        public void ShowMessage(string mensaje)
        {
            System.Console.WriteLine(mensaje);
            System.Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}