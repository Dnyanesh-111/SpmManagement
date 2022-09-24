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
    public partial class RequirementView : Form, IRequirementView
    {
        //Constructor
        public RequirementView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(RequirementEdit);
            btnClose.Click += delegate { this.Close(); };
        }

        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

       
       

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
                tabControl1.TabPages.Remove(requirementList);
                tabControl1.TabPages.Add(RequirementEdit);
                RequirementEdit.Text = "Add new client";
            };
            //Eidt Event
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(requirementList);
                tabControl1.TabPages.Add(RequirementEdit);
                RequirementEdit.Text = "Edit client";
            };
            //Save Event
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(RequirementEdit);
                    tabControl1.TabPages.Add(requirementList);
                }
                MessageBox.Show(Message);
            };
            //Cancel Event
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(RequirementEdit);
                tabControl1.TabPages.Add(requirementList);

            };
            //Delete Event
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected client?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }
        public string Id 
        {
            get => txtId.Text;
            set => txtId.Text=value; 
        }
        public string Client 
        { 
            get => txtClient.Text; 
            set => txtClient.Text=value; 
        }
        public string File 
        { 
            get => txtFile.Text;
            set => txtFile.Text=value; 
        }
        public bool IsEdit
        {
            get => isEdit;
            set => isEdit = value;
        }
        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message
        {
            get => message;
            set => message = value;
        }
        public string SearchValue 
        {
            get => txtSearch.Text;
            set => txtSearch.Text = value;
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetRequirementListBindingSource(BindingSource requirementBindingSource)
        {
            dataGridView1.DataSource = requirementList;
        }

        //Singleton Pattern (Open a single form instance)
        private static RequirementView instance;
        public static RequirementView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RequirementView();
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

       
    }
}
