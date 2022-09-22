using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpmManagement.Views
{
    public interface IClientsView
    {
        //Properties - Fields
        string Id { get; set; }
        string CName { get; set; }
        string Email { get; set; }
        string Mobile { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Country { get; set; }

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
        void SetClientListBindingSource(BindingSource clientList);
        void Show();//optional
    }
}
