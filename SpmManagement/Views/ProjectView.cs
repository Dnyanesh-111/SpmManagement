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
    public partial class ProjectView : Form, IProjectView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        public ProjectView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
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
                tabPage2.Text = "Add new Project";
            };
            //Eidt Event
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Project";
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
                var result = MessageBox.Show("Are you sure you want to delete the selected project?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            //Assign Team Event
            btnAssignTeam.Click += delegate
            {
                AssignTeamEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage3);
                tabPage2.Text = "Assign Team";
            };
            //Cancel Team Event
            btnCancel2.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Add(tabPage2);

            };
        }


        //Properties
        public string Id 
        { 
            get => txtId.Text; 
            set => txtId.Text=value; 
        }
        public string Client 
        { 
            get => txtCname.Text; 
            set => txtCname.Text=value; 
        }
        public string Requirement 
        { 
            get => txtFile.Text; 
            set => txtFile.Text=value; 
        }
        public string Team 
        { 
            get => txtTeam.Text; 
            set => txtTeam.Text=value; 
        }
        public string Cost 
        { 
            get => txtCost.Text; 
            set => txtCost.Text=value; 
        }
        public string Sdate 
        { 
            get => dateStart.Text; 
            set => dateStart.Text=value; 
        }
        public string Cdate 
        { 
            get => dateCompletion.Text; 
            set => dateCompletion.Text=value; 
        }

        public string Status 
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
            set => isEdit = value; 
        }
        public bool IsSuccessful 
        { 
            get => isSuccessful; 
            set => isSuccessful=value; 
        }
        public string Message { 
            get => message; 
            set => message=value; 
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler AssignTeamEvent;

        public void SetClientListBindingSource(BindingSource projectList)
        {
            dataGridView1.DataSource = projectList;
        }

        //Singleton Pattern (Open a single form instance)
        private static ProjectView instance;
        public static ProjectView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProjectView();
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
