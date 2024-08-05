using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryCenter.Models;

namespace VeterinaryCenter.DataTest
{
    public class ManagerApp
    {
        //Atributos de la clase
        public static List<Cat> cats = new List<Cat>();
        public static List<Dog> dogs = new List<Dog>();

        //Metodo para crear un perro
        public static Dog CreateDog()
        {
            return new Dog(19, "Sacha", new DateOnly(2010, 8, 4), "Golden", "Blanco", 4.5, true, "TiMIDO", "1548", "Pelo Corto", "Pelo Corto");
        }

        //Metodo para crear un gato
        public static Cat CreateCat()
        {
            return new Cat(89, "Simon", new DateOnly(2017, 12, 24), "Siamese", "Blanco y Negro", 2.0, false, "pelo corto");
        }
            
        //Metodo estatico de mostrar header
        public static void ShowHeader()
        {
            System.Console.WriteLine("##################### Clinic Veterinary #####################");
        }

        //Metodo estatico para mostrar footer
        public static void ShowFooter()
        {
            System.Console.WriteLine("##################### Riwi Veterinary #####################");
        }
    }
}