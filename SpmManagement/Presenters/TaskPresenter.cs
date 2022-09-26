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
    class TaskPresenter
    {
        private ITaskView view;
        private ITaskRepository repository;
        private BindingSource taskBindingSource;
        private IEnumerable<TaskModel> taskList;

        //Constructor
        public TaskPresenter(ITaskView view, ITaskRepository repository)
        {
            this.taskBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Subscribe Event handler methods to view events
            this.view.SearchEvent += SearchTask;
            this.view.AddNewEvent += AddNewTask;
            this.view.EditEvent += LoadSelectedTaskToEdit;
            this.view.DeleteEvent += DeleteSelectedTask;
            this.view.SaveEvent += SaveTask;
            this.view.CancelEvent += CancelAction;

            //Set Clients Binding Source
            this.view.SetTaskListBindingSource(taskBindingSource);

            //Load Client List view
            LoadAllTaskList();

            //Show View
            this.view.Show();

        }

        private void LoadAllTaskList()
        {
            taskList = repository.GetAll();
            taskBindingSource.DataSource = taskList; //Set data Source
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void CleanviewFields()
        {
            view.Id = "0";
            view.Project = "";
            view.Name = "";
            view.Description = "";
            view.AssignedTo = "";
            view.Duration = "";
            view.Dependency = "";
            view.Status = "";
            view.Work = "";
        }

        private void SaveTask(object sender, EventArgs e)
        {
            var model = new TaskModel();
            model.Id = Convert.ToInt32(view.Id);
            model.Project = view.Project;
            model.Name = view.Name;
            model.Description = view.Description;
            model.AssignedTo = view.AssignedTo;
            model.Duration = view.Duration;
            model.Dependency = view.Dependency;
            model.Status = view.Status;
            model.Work = view.Work;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Task edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Task added successfully";
                }
                view.IsSuccessful = true;
                LoadAllTaskList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedTask(object sender, EventArgs e)
        {
            try
            {
                var task = (TaskModel)taskBindingSource.Current;
                repository.Delete(task.Id);
                view.IsSuccessful = true;
                view.Message = "task deleted successfully";
                LoadAllTaskList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured, could not delete task";
            }
        }

        private void LoadSelectedTaskToEdit(object sender, EventArgs e)
        {
            var task = (TaskModel)taskBindingSource.Current;
            view.Id = task.Id.ToString();
            view.Project = task.Project.ToString();
            view.Name = task.Name.ToString();
            view.Description = task.Description.ToString();
            view.AssignedTo = task.AssignedTo.ToString();
            view.Duration = task.Duration.ToString();
            view.Dependency = task.Description.ToString();
            view.Status = task.Status.ToString();
            view.Work = task.Work.ToString();
            view.IsEdit = true;
        }

        private void AddNewTask(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchTask(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                taskList = repository.GetByValue(this.view.SearchValue);
            else taskList = repository.GetAll();
            LoadAllTaskList();
        }
    }

}
