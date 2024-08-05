// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using VeterinaryCenter.Models;
// using VeterinaryCenter.Validations;

// namespace VeterinaryCenter.Views
// {
//     public class DogCat
//     {
//         //Metodo Para mostrar perrors   
//         public int ShowDogMenu()
//         {
//             Console.Clear();
//             Console.WriteLine("============= Gestion Perros ============= ");
//             Console.WriteLine("1. Mostrar perros");
//             Console.WriteLine("2. Agregar perro");
//             Console.WriteLine("3. Eliminar perro");
//             Console.WriteLine("4. Buscar perro");
//             Console.WriteLine("5. Editar perro");
//             Console.WriteLine("6. Volver al menú principal");
//             Console.Write("Elija una opcion: ");
//             int option;
//             while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 6)
//             {
//                 System.Console.Write("Opcion invalida, Intenta de nuevo: ");
//             }
//             return option;
//         }

//         //Metodo para agregar o editar un perro
//         public Dog GetCustomerInfo(Dog dog = null)
//         {
//             Console.Clear();
//             System.Console.WriteLine(dog == null ? "==== Agregar un nuevo perro ====" : "==== Editar un perro ====");

//             string name;
//             do
//             {
//                 System.Console.Write("Nombre: ");
//                 name = Console.ReadLine().Trim();
//                 if (!InputValidator.IsAlphabetic(name))
//                 {
//                     System.Console.WriteLine("Nombre inválido. Solo se permiten letras y espacios.");
//                 }
//             } while (!InputValidator.IsAlphabetic(name));

//             System.Console.Write("Fecha de Nacimiento (YYYY-MM-DD): ");
//             DateOnly hireDate;
//             while (!DateOnly.TryParse(Console.ReadLine(), out hireDate))
//             {
//                 System.Console.Write("Formato invalido. Intente de nuevo (YYYY-MM-DD): ");
//             }

//             string breed;
//             do
//             {
//                 System.Console.Write("Raza: ");
//                 breed = Console.ReadLine().Trim();
//                 if (!InputValidator.IsAlphabetic(breed))
//                 {
//                     System.Console.WriteLine("Raza inválido. Solo se permiten letras y espacios.");
//                 }
//             } while (!InputValidator.IsAlphabetic(breed));

//             string color;
//             do
//             {
//                 System.Console.Write("color: ");
//                 color = Console.ReadLine().Trim();
//                 if (!InputValidator.IsAlphabetic(color))
//                 {
//                     System.Console.WriteLine("Nombre inválido. Solo se permiten letras y espacios.");
//                 }
//             } while (!InputValidator.IsAlphabetic(color));

//             System.Console.Write("Peso (Ej: 5.0): ");
//             double weight;
//             while (!Double.TryParse(Console.ReadLine(), out weight))
//             {
//                 System.Console.Write("Formato invalido. Intente de nuevo (Ej: 5.0, 11.0): ");
//             }

//             System.Console.Write("Estado de la cria: ");
//             bool status;
//             while (!Boolean.TryParse(Console.ReadLine(), out status))
//             {
//                 System.Console.Write("Formato invalido. Intente de nuevo: ");
//             }

//             int id = 5;

//             if (dog == null)
//             {
//                 return new Dog(id, name, hireDate, breed, color, weight, status,);
//             }
//             else
//             {
//                 //Actualizar datos del cat existente
//                 dog.SetId(id);
//                 dog.SetName(name);
//                 dog.SetBirthdate(hireDate);
//                 dog.SetBreed(breed);
//                 dog.SetColor(color);
//                 dog.SetWeightInKg(weight);
//                 dog.BreedingStatus = status;
//                 return dog;
//             }
//         }
//     }
// }