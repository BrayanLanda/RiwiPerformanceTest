using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryCenter.Views;

namespace VeterinaryCenter.Controllers
{
    public class MainController
    {
        private readonly MainView _view = new MainView();
        private readonly DogController _dogController = new DogController();
        private readonly CatController _catController = new CatController();
        
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
                    /*case 2:
                        ManageCustomers();
                        break;
                    case 3:
                        ManageVehicle();
                        break;
                    case 4:
                        ManageQueries();
                        break;*/
                    case 5:
                        exit = true;
                        break;
                }
            }

            _view.ShowMessage("Gracias por usar el sistema de Veterinaria");
        }
    }
}