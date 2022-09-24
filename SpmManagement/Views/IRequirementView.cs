using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpmManagement.Views
{
    public interface IRequirementView
    {
        //Properties - Fields
        string Id { get; set; }
        string Client { get; set; }
        string File { get; set; }
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
        void SetRequirementListBindingSource(BindingSource requirementList);
        
        void Show();//optional
    }
}
