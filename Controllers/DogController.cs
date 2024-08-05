using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryCenter.DataTest;
using VeterinaryCenter.Models;
using VeterinaryCenter.Views;

namespace VeterinaryCenter.Controllers
{
    public class DogController
    {
        
        public MainView mainView = new MainView();
        public DogView dogView = new DogView();
        public VeterinaryClinic _app = new VeterinaryClinic("Clinica Riwi", "Outle Guayabal");

        public void ManageDog()
        {
            bool back = false;
            while (!back)
            {
                int option = dogView.ShowDogMenu();

                switch (option)
                {
                    case 1:
                        ShowDogs();
                        break;
                    case 2:
                        AddDog();
                        break;
                    case 3:
                        DeleteDog();
                        break;
                    case 4:
                        SearchDog();
                        break;
                    case 5:
                        EditDog();
                        break;
                    case 6:
                        back = true;
                        break;
                    default:
                        mainView.ShowMessage("Opcion invalida.");
                        break;
                }
            }
        }
        //Mostrar todos los perros
        private void ShowDogs()
        {
            ManagerApp.ShowHeader();
            _app.ShowDogs();
            mainView.ShowMessage("--------------------------");

        }

        //Agregar un nuevo Perro
        private void AddDog()
        {
            Dog dog = dogView.GetDogInfo();
            _app.SaveDog(dog);
            mainView.ShowMessage("Perro agregado exitosamente.");
        }

        // Método para eliminar un Perro
        private void DeleteDog()
        {
            int id = mainView.GetIdIntForAction("Eliminar");
            Dog dog = _app.GetDogById(id); // Usar el método de AdministradorApp para obtener el perro

            if (dog != null)
            {
                _app.DeleteDog(dog); // Usar el método de Veterenary para eliminar el perro
                mainView.ShowMessage("Perro eliminado exitosamente.");
            }
            else
            {
                mainView.ShowMessage("Perro no encontrado.");
            }
        }

        // Buscar un Perro por id
        private void SearchDog()
        {
            int id = mainView.GetIdIntForAction("Buscar");
            Dog dog = _app.GetDogById(id); // Usar el método de Veterinary para obtener el perro

            if (dog != null)
            {
                ManagerApp.ShowHeader();
                mainView.ShowMessage($"Perro encontrado: Nombre: {dog.GetName()}\nColor: {dog.GetColor()}\nAño de nacimiento: {dog.GetBirthdate()}\nRaza: {dog.GetBreed()}\nTemeperamento: {dog.Temperament}\nPelaje: {dog.CoatType}");
                ManagerApp.ShowFooter();
            }
            else
            {
                mainView.ShowMessage("Perro no encontrado.");
            }
        }

        // Editar un Perro
        private void EditDog()
        {
            int id = mainView.GetIdIntForAction("Editar");
            Dog dog = _app.GetDogById(id); // Usar el método de Veterinary para obtener el perro
            if (dog != null)
            {
                dogView.GetDogInfo(dog);
                mainView.ShowMessage("Perro Actualizado con exito");
            }
            else
            {
                mainView.ShowMessage("Perro no encontrado");
            }
        }

        
    }
}