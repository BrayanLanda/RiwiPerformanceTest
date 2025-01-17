using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryCenter.Views;

namespace VeterinaryCenter.Controllers
{
    public class MainController
    {
        //Instancia de clases y listas
        private readonly MainView _view = new MainView();
        private readonly DogController _dogController = new DogController();
        private readonly CatController _catController = new CatController();
        private readonly QueriesController _queController = new QueriesController();
        
        //Metodo principal para correr aplicacion
        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                int mainOption = _view.ShowMenu();
                switch (mainOption)
                {
                    case 1:
                        _catController.ManageCat();
                        break;
                    case 2:
                        _dogController.ManageDog();
                        break;

                    case 3:
                        _queController.ManageQueries();
                        break;
                    case 4:
                        exit = true;
                        break;
                }
            }

            _view.ShowMessage("Gracias por usar el sistema de Veterinaria");
        }
    }
}