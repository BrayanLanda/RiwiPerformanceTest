using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryCenter.Models;
using VeterinaryCenter.Views;

namespace VeterinaryCenter.Controllers
{
    public class CatController
    {
        public MainView mainView = new MainView();
        public CatView catView = new CatView();
        public VeterinaryClinic _app = new VeterinaryClinic("Clinica Riwi", "Outle Guayabal");

        public void ManageCat()
        {
            bool back = false;
            while (!back)
            {
                int option = catView.ShowCatMenu();

                switch (option)
                {
                    case 1:
                        ShowCats();
                        break;
                    case 2:
                        AddCat();
                        break;
                    case 3:
                        DeleteCat();
                        break;
                    case 4:
                        SearchCat();
                        break;
                    case 5:
                        EditCat();
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
        //Mostrar todos los gatos
        private void ShowCats()
        {
            System.Console.WriteLine("------------------------");
            _app.ShowCats();
            mainView.ShowMessage("--------------------------");

        }

        //Agregar un nuevo gato
        private void AddCat()
        {
            Cat cat = catView.GetCatInfo();
            _app.SaveCat(cat);
            System.Console.WriteLine("------------------------");
            mainView.ShowMessage("Gato agregado exitosamente.");
        }

        // Método para eliminar un gato
        private void DeleteCat()
        {
            int id = mainView.GetIdIntForAction("eliminar");
            Cat customer = _app.GetCatById(id); // Usar el método de AdministradorApp para obtener el cliente

            if (customer != null)
            {
                _app.DeleteCat(customer); // Usar el método de AdministradorApp para eliminar el cliente
                mainView.ShowMessage("Gato eliminado exitosamente.");
            }
            else
            {
                mainView.ShowMessage("Gato no encontrado.");
            }
        }

        // Buscar un gato por id
        private void SearchCat()
        {
            int id = mainView.GetIdIntForAction("Buscar");
            Cat cat = _app.GetCatById(id); // Usar el método de AdministradorApp para obtener el cliente

            if (cat != null)
            {
                // System.Console.WriteLine($"Cliente encontrado: {customer.GetName()} {customer.GetLastName()}");
                // System.Console.WriteLine($"Documentyo: {customer.GetTypeDocument()}-{customer.GetIdentificationNumber()}");
                // System.Console.WriteLine($"Cliente encontrado: {customer.GetEmail()}");
                // System.Console.WriteLine($"Cliente encontrado: {customer.GetPhoneNumber()}");
                // System.Console.WriteLine("Cliente Encontrado con exito");
            }
            else
            {
                mainView.ShowMessage("Gato no encontrado.");
            }
        }

        // Editar un gato
        private void EditCat()
        {
            int id = mainView.GetIdIntForAction("Editar");
            Cat cat = _app.GetCatById(id); // Usar el método de AdministradorApp para obtener el cliente
            if (cat != null)
            {
                catView.GetCatInfo(cat);
                mainView.ShowMessage("Gato Actualizado con exito");
            }
            else
            {
                mainView.ShowMessage("Gato no encontrado");
            }
        }
    }
}