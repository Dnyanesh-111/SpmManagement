using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpmManagement.Views
{
    public partial class ClientView : Form, IClientsView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public ClientView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        //Properties
        public string Id {
            get => txtId.Text; 
            set => txtId.Text = value; 
        }
        public string Email {
            get => txtEmail.Text; 
            set => txtEmail.Text = value; 
        }
        public string Mobile {
            get => txtMobile.Text; 
            set => txtMobile.Text = value; 
        }
        public string City {
            get => txtCity.Text; 
            set => txtCity.Text = value; 
        }
        public string State {
            get => txtState.Text; 
            set => txtState.Text = value; 
        }
        public string Country {
            get => txtCountry.Text; 
            set => txtCountry.Text = value; 
        }
        public string SearchValue {
            get => txtSearch.Text; 
            set => txtSearch.Text = value; 
        }
        public bool IsEdit {
            get => isEdit; 
            set => isEdit = value; 
        }
        public bool IsSuccessful {
            get => isSuccessful; 
            set => isSuccessful = value; 
        }
        public string Message {
            get => message; 
            set => message = value; 
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetClientListBindingSource(BindingSource clientList)
        {
            dataGridView1.DataSource = clientList;
        }
    }
}
