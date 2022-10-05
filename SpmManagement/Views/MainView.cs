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
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnClients.Click += delegate { ShowClientView?.Invoke(this, EventArgs.Empty); };
            btnRequirements.Click += delegate { ShowRequirementView?.Invoke(this, EventArgs.Empty); };
            btnProjects.Click += delegate { ShowProjectView?.Invoke(this, EventArgs.Empty); };
            btnTasks.Click += delegate { ShowTaskView?.Invoke(this, EventArgs.Empty); };
            

        }

        public event EventHandler ShowClientView;
        public event EventHandler ShowRequirementView;
        public event EventHandler ShowProjectView;
        public event EventHandler ShowTaskView;
        public event EventHandler ShowReportView;

        private void btnReports_Click(object sender, EventArgs e)
        {
           RGetInstance(this);
        }
        //Singleton Pattern (Open a single form instance)
        private static ReportView instance;
        public void RGetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ReportView();
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
           
        }
    }
}
