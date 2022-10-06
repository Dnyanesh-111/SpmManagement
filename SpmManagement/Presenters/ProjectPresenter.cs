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
    class ProjectPresenter
    {
        private IProjectView view;
        private IProjectRepository repository;
        private BindingSource projectBindingSource;
        private IEnumerable<ProjectModel> projectList;
  
        //Constructor
        public ProjectPresenter(IProjectView view, IProjectRepository repository)
        {
            this.projectBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Subscribe Event handler methods to view events
            this.view.SearchEvent += SearchProject;
            this.view.AddNewEvent += AddNewProject;
            this.view.EditEvent += LoadSelectedProjectToEdit;
            this.view.DeleteEvent += DeleteSelectedProject;
            this.view.SaveEvent += SaveProject;
            this.view.CancelEvent += CancelAction;

            //Set Projects Binding Source
            this.view.SetProjectListBindingSource(projectBindingSource);
           
            //Load Project List view
            LoadAllProjectList(); 
            //Load Project List view
          

            //Show View
            this.view.Show();

        }

        private void LoadAllProjectList()
        {
            projectList = repository.GetAll();
            projectBindingSource.DataSource = projectList; //Set data Source
        }
       

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void CleanviewFields()
        {
            view.Id = "0";
            view.PName = "";
            view.Sdate = "";
            view.Client = "";
            view.Status = "";
            view.Cost= "";
            view.Requirement = "";
            view.Cdate = "";
        }

        private void SaveProject(object sender, EventArgs e)
        {
            var model = new ProjectModel();
            model.Id = Convert.ToInt32(view.Id);
            model.PName = view.PName;
            model.Sdate = view.Sdate;
            model.Client = view.Client;
            model.Cost = Convert.ToInt32(view.Cost);
            model.Status = view.Status;
            model.Requirements = view.Requirement;
            model.Cdate = view.Cdate;
            model.Team = "Not-Assigned";
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Project edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Project added successfully";
                }
                view.IsSuccessful = true;
                LoadAllProjectList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedProject(object sender, EventArgs e)
        {
            try
            {
                var project = (ProjectModel)projectBindingSource.Current;
                repository.Delete(project.Id);
                view.IsSuccessful = true;
                view.Message = "Project deleted successfully";
                LoadAllProjectList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete project";
            }
        }

        private void LoadSelectedProjectToEdit(object sender, EventArgs e)
        {

            var project = (ProjectModel)projectBindingSource.Current;
            view.Id = project.Id.ToString();
            view.PName = project.PName.ToString();
            view.Client = project.Client.ToString();
            view.Requirement = project.Requirements.ToString();
            view.Cost = project.Cost.ToString();
            view.Sdate = project.Sdate.ToString();
            view.Cdate = project.Cdate.ToString();
            view.Status = project.Status.ToString();
            view.IsEdit = true;
        }

        private void AddNewProject(object sender, EventArgs e)
        {
            view.IsEdit = false;
            CleanviewFields();
        }

        private void SearchProject(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                projectList = repository.GetByValue(this.view.SearchValue);
            else projectList = repository.GetAll();
            LoadAllProjectList();
        }
    }
}
