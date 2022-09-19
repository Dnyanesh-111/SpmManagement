using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpmManagement.Models;
using SpmManagement.Views;
namespace SpmManagement.Presenters
{
    class ClientPresenter
    {
        private IClientsView view;
        private IClientsRepository repository;
        private BindingSource clientsBindingSource;
        private IEnumerable<ClientsModel> clientList;

        //Constructor
        public ClientPresenter(IClientsView view, IClientsRepository repository)
        {
            this.clientsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Subscribe Event handler methods to view events
            this.view.SearchEvent += SearchClient;
            this.view.AddNewEvent += AddNewClient;
            this.view.EditEvent += LoadSelectedClientToEdit;
            this.view.DeleteEvent += DeleteSelectedClient;
            this.view.SaveEvent += SaveClient;
            this.view.CancelEvent += CancelAction;

            //Set Clients Binding Source
            this.view.SetClientListBindingSource(clientsBindingSource);

            //Load Client List view
            LoadAllClientList();

            //Show View
            this.view.Show();

        }

        //Methods

        private void LoadAllClientList()
        {
            clientList = repository.GetAll();
            clientsBindingSource.DataSource = clientList; //Set data Source
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveClient(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedClient(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedClientToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewClient(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchClient(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                clientList = repository.GetByValue(this.view.SearchValue);
            else clientList = repository.GetAll();
            LoadAllClientList();

        }
    }
}
