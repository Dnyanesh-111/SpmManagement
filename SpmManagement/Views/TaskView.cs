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
    public partial class TaskView : Form, ITaskView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public TaskView()
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
                tabPage2.Text = "Add New Task";
            };
            //Eidt Event
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Task";
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
                var result = MessageBox.Show("Are you sure you want to delete the selected task?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }


        //Properties
        public string Id 
        { 
            get => txtId.Text; 
            set => txtId.Text=value; 
        }
        public string Project 
        { 
            get => txtProject.Text; 
            set => txtProject.Text=value; 
        }
        public string Description 
        { 
            get => txtDescription.Text; 
            set => txtDescription.Text=value; 
        }
        public string AssignedTo 
        { 
            get => txtAssignedTo.Text; 
            set => txtAssignedTo.Text=value; 
        }
        public string Duration 
        { 
            get => txtDuration.Text; 
            set => txtDuration.Text=value; 
        }
        public string Dependency 
        { 
            get => txtDependency.Text; 
            set => txtDependency.Text=value; 
        }
        public string Status 
        { 
            get => txtStatus.Text; 
            set => txtStatus.Text=value; 
        }
        public string Work 
        { 
            get => txtStatus.Text; 
            set => txtStatus.Text=value; 
        }
        public string SearchValue 
        { 
            get => txtSearch.Text; 
            set => txtSearch.Text=value; 
        }
        public bool IsEdit 
        { 
            get => isEdit; 
            set => isEdit=value; 
        }
        public bool IsSuccessful 
        { 
            get => isSuccessful; 
            set => isSuccessful=value; 
        }
        public string Message 
        { 
            get => message; 
            set => message=value; 
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetTaskListBindingSource(BindingSource taskList)
        {
            dataGridView1.DataSource = taskList;
        }
        //Singleton Pattern (Open a single form instance)
        private static TaskView instance;
        public static TaskView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TaskView();
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
