using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpmManagement.Views
{
    interface ITaskView
    {
        //Properties - Fields
        string Id { get; set; }
        string Project { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string AssignedTo { get; set; }
        string Duration { get; set; }
        string Dependency { get; set; }
        string Status { get; set; }
        string Work { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }


        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods 
        void SetTaskListBindingSource(BindingSource taskList);
        void Show();//optional
    }
}
