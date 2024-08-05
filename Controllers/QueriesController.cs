using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryCenter.DataTest;
using VeterinaryCenter.Models;
using VeterinaryCenter.Views;

namespace VeterinaryCenter.Controllers
{
    public class QueriesController
    {
        public MainView mainView = new MainView();
        public ViewQueries queriesView = new ViewQueries();
        public VeterinaryClinic _app = new VeterinaryClinic("Clinica Riwi", "Outle Guayabal");
        public void ManageQueries()
        {
            bool back = false;
            while (!back)
            {
                int option = queriesView.ShowQueriesMenu();

                switch (option)
                {
                    case 1:
                        DogCastrate();
                        break;
                    case 2:
                        DogMotilar();
                        break;
                    case 3:
                        CatCastrate();
                        break;
                    case 4:
                        CatMotilar();
                        break;
                    case 5:
                        back = true;
                        break;
                    default:
                        mainView.ShowMessage("Opcion invalida.");
                        break;
                }
            }
        }

        // Buscar un Perro y un gato por name para castrar
        private void DogCastrate()
        {
            string name = queriesView.GetNameIntForAction("Castrar");
            Dog dog = _app.GetDogByName(name); // Usar el método de Veterinary para obtener el perro

            if (dog != null)
            {
                if (dog.BreedingStatus == true)
                {
                    ManagerApp.ShowHeader();
                    mainView.ShowMessage("El perro no se puede castrar otra vez");
                    ManagerApp.ShowFooter();
                }
                else
                {
                    ManagerApp.ShowHeader();
                    mainView.ShowMessage("Perro castrado");
                    dog.BreedingStatus = true;
                    ManagerApp.ShowFooter();
                }
            }
            else
            {
                mainView.ShowMessage("Perro no encontrado.");
            }
        }
        private void CatCastrate()
        {
            string name = queriesView.GetNameIntForAction("Castrar");
            Cat cat = _app.GetCatByName(name); // Usar el método de Veterinary para obtener el gato

            if (cat != null)
            {
                if (cat.BreedingStatus == true)
                {
                    ManagerApp.ShowHeader();
                    mainView.ShowMessage("El gato no se puede castrar otra vez");
                    ManagerApp.ShowFooter();
                }
                else
                {
                    ManagerApp.ShowHeader();
                    mainView.ShowMessage("Gato castrado");
                    cat.BreedingStatus = true;
                    ManagerApp.ShowFooter();
                }
            }
            else
            {
                mainView.ShowMessage("Gato no encontrado.");
            }
        }

        // Buscar un Perro y un gato por name para motilar
        private void DogMotilar()
        {
            string name = queriesView.GetNameIntForAction("Motilar");
            Dog dog = _app.GetDogByName(name); // Usar el método de Veterinary para obtener el perro

            if (dog != null)
            {
                if (dog.CoatType == "pelo corto")
                {
                    ManagerApp.ShowHeader();
                    mainView.ShowMessage("El perro tiene pelo corto, no se puede motilar");
                    ManagerApp.ShowFooter();
                }
                else
                {
                    ManagerApp.ShowHeader();
                    mainView.ShowMessage("Perro motilado");
                    dog.CoatType = "pelo corto";
                    ManagerApp.ShowFooter();
                }
            }
            else
            {
                mainView.ShowMessage("Perro no encontrado.");
            }
        }
        private void CatMotilar()
        {
            string name = queriesView.GetNameIntForAction("Motilar");
            Cat cat = _app.GetCatByName(name); // Usar el método de Veterinary para obtener el gato

            if (cat != null)
            {
                if (cat.FurLength == "sin pelo")
                {
                    ManagerApp.ShowHeader();
                    mainView.ShowMessage("El gato no tiene pelo, no se puede motilar");
                    ManagerApp.ShowFooter();
                }
                else
                {
                    ManagerApp.ShowHeader();
                    mainView.ShowMessage("Gato motilado");
                    cat.FurLength = "sin pelo";
                    ManagerApp.ShowFooter();
                }

            }
            else
            {
                mainView.ShowMessage("Gato no encontrado.");
            }
        }
    }
}