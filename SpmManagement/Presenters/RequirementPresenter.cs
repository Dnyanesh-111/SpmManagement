using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SpmManagement.Models;
using SpmManagement.Views;
namespace SpmManagement.Presenters
{
    class RequirementPresenter
    {
        private IRequirementView view;
        private IRequirementRepository repository;
        private BindingSource requirementBindingSource;
        private IEnumerable<RequirementModel> requirementList;

        public RequirementPresenter(IRequirementView view, IRequirementRepository repository)
        {
            this.requirementBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Subscribe Event handler methods to view events
            this.view.SearchEvent += SearchRequirement;
            this.view.AddNewEvent += AddNewRequirement;
            this.view.EditEvent += LoadSelectedRequirementToEdit;
            this.view.DeleteEvent += DeleteSelectedRequirement;
            this.view.SaveEvent += SaveRequirement;
            this.view.CancelEvent += CancelAction;

            //Set Requirement Binding Source
            this.view.SetRequirementListBindingSource(requirementBindingSource);

            //Load Client List view
            LoadAllRequirementList();

            //Show View
            this.view.Show();

        }
        private void CleanviewFields()
        {
            view.Id = "0";
            view.Client = "";
            view.File= "";
        }

        private void LoadAllRequirementList()
        {
            requirementList = repository.GetAll();
            requirementBindingSource.DataSource = requirementList; //Set data Sourcethrow new NotImplementedException();
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveRequirement(object sender, EventArgs e)
        {
            var model = new RequirementModel();
            model.Id = Convert.ToInt32(view.Id);
            model.Client= view.Client;
            model.File= view.File;
           
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Requirement edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Requirement added successfully";
                }
                view.IsSuccessful = true;
                LoadAllRequirementList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedRequirement(object sender, EventArgs e)
        {
            try
            {
                var requirement = (RequirementModel)requirementBindingSource.Current;
                repository.Delete(requirement.Id);
                view.IsSuccessful = true;
                view.Message = "Requirement deleted successfully";
                LoadAllRequirementList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete requirement";
            }
        }

        private void LoadSelectedRequirementToEdit(object sender, EventArgs e)
        {
            var requirement = (RequirementModel)requirementBindingSource.Current;
            view.Id = requirement.Id.ToString();
            view.Client = requirement.Client.ToString();
            view.File = requirement.File.ToString();
            view.IsEdit = true;
        }

        private void AddNewRequirement(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchRequirement(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                requirementList = repository.GetByValue(this.view.SearchValue);
            else requirementList = repository.GetAll();
            LoadAllRequirementList();
        }
    }
}
