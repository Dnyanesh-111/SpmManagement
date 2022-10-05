using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SpmSystem;Integrated Security=True";

        public ProjectView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            btnClose.Click += delegate { this.Close(); };
            SetClientList();
            SetEmployeeList();
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
            set => txtId.Text = value;
        }
        public string PName
        {
            get => txtName.Text ;
            set => txtName.Text = value;
        }
        public string Client
        {
            get => txtCname.Text;
            set => txtCname.Text = value;
        }
        public string Requirement
        {
            get => txtFile.Text;
            set => txtFile.Text = value;
        }
        public string Team
        {
            get => txtTeamId.Text;
            set => txtTeamId.Text = value;
        }
        public string Cost
        {
            get => txtCost.Text;
            set => txtCost.Text = value;
        }
        public string Sdate
        {
            get => dateStart.Text;
            set => dateStart.Text = value;
        }
        public string Cdate
        {
            get => dateCompletion.Text;
            set => dateCompletion.Text = value;
        }

        public string Status
        {
            get => txtStatus.Text;
            set => txtStatus.Text = value;
        }
        public string SearchValue
        {
            get => txtSearch.Text;
            set => txtSearch.Text = value;
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
        

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler AssignTeamEvent;

        public void SetProjectListBindingSource(BindingSource projectList)
        {
            dataGridView1.DataSource = projectList;
        }

        public void SetClientList()
        {
            var clientList = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select cname from clients";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientList.Add(reader[0].ToString());
                    }
                }
            }
            foreach (string client in clientList)
            {
                txtCname.Items.Add(client);
            }
        }
        public void SetEmployeeList()
        {
            
            var employeeList = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select name from TblEmp where status='Available' ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employeeList.Add(reader[0].ToString());
                    }
                }
            }
            foreach (string client in employeeList)
            {
                txtTeamMember.Items.Add(client);
            }
            
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

        //Add team members
        private void btnSave2_Click(object sender, EventArgs e)
        {
            
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into team_members ( member, role) values ('" + txtTeamMember.Text + "','" + txtTeamRole.Text + "')";
                command.ExecuteNonQuery();
                command.CommandText = "update TblEmp set status='Not-Available' ";
                command.ExecuteNonQuery();
                
            }
            fillTeam();
            
        }
        
        //Remove Team Members
        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Show Team Members
        private void fillTeam()
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select t.project, tm.member, tm.role from teams as t join teamMembers as tm on t.teamid=tm.teamid";
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void btnAssignTeam_Click(object sender, EventArgs e)
        {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "select * from teams where project ='"+Convert.ToInt32(txtId.Text)+"'";
                    var reder= command.ExecuteReader();
                    if (reder.HasRows)
                    {
                        fillTeam();
                }
                else
                {
                    command.CommandText = "insert into teams values ('" + txtId.Text + "')";
                }
                }
            
        }

        private void txtTeamMember_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
           
        }
    }
}