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
            CleanviewFields();
        }

        private void SaveClient(object sender, EventArgs e)
        {
            var model = new ClientsModel();
            model.Id = Convert.ToInt32(view.Id);
            model.CName = view.CName;
            model.Email = view.Email;
            model.Mobile = view.Mobile;
            model.City = view.City;
            model.State = view.State;
            model.Country = view.Country;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Client edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Client added successfully";
                }
                view.IsSuccessful = true;
                LoadAllClientList();
                CleanviewFields();
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.Id = "0";
            view.CName = "";
            view.Email = "";
            view.Mobile = "";
            view.City = "";
            view.State = "";
            view.Country = "";
        }

        private void DeleteSelectedClient(object sender, EventArgs e)
        {
            try
            {
                var client = (ClientsModel)clientsBindingSource.Current;
                repository.Delete(client.Id);
                view.IsSuccessful = true;
                view.Message = "Client deleted successfully";
                LoadAllClientList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete client";   
            }
        }

        private void LoadSelectedClientToEdit(object sender, EventArgs e)
        {
            var client = (ClientsModel)clientsBindingSource.Current;
            view.Id = client.Id.ToString();
            view.CName = client.CName.ToString();
            view.Email = client.Email.ToString();
            view.Mobile = client.Mobile.ToString();
            view.City = client.City.ToString();
            view.State = client.State.ToString();
            view.Country= client.Country.ToString();
            view.IsEdit = true;
        }

        private void AddNewClient(object sender, EventArgs e)
        {
            view.IsEdit = false;
            CleanviewFields();
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
