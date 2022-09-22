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
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {   
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add Event
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add new client";
            };
            //Eidt Event
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit client";
            };
            //Save Event
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
                MessageBox.Show(Message);
            };
            //Cancel Event
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
            
            };
            //Delete Event
            btnDelete.Click += delegate
            {
                var result=  MessageBox.Show("Are you sure you want to delete the selected client?","Warning",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        //Properties
        public string Id {
            get => txtId.Text; 
            set => txtId.Text = value; 
        }
        public new string CName
        {
            get => txtName.Text; 
            set => txtName.Text = value; 
        }public string Email {
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

        //Singleton Pattern (Open a single form instance)
        private static ClientView instance;
        public static ClientView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ClientView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
