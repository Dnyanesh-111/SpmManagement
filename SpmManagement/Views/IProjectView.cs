using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpmManagement.Views
{
    public interface IProjectView
    {
        //Properties and fields
        string Id { get; set; } 
        string Name { get; set; }
        string Client { get; set; }
        string Requirement { get; set; }
        string Team { get; set; }
        string Cost { get; set; }
        string Sdate { get; set; }
        string Edate { get; set; }
        string Status { get; set; }

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
        void SetClientListBindingSource(BindingSource projectList);
        void Show();//optional
    }
}
