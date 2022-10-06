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

         ReportView reportView ;
        private void btnReports_Click(object sender, EventArgs e)
        {
            
            //view.WindowState = FormWindowState.Maximized;
            //view.MdiParent = this;
            //view.Show();
            if (reportView == null || reportView.IsDisposed)
            {
                reportView = new ReportView();
                reportView.MdiParent = this;
                reportView.FormBorderStyle = FormBorderStyle.None;
                reportView.Dock = DockStyle.Fill;
                reportView.Show();
            }
            else
            {
                if (reportView.WindowState == FormWindowState.Minimized)
                    reportView.WindowState = FormWindowState.Normal;
                    reportView.BringToFront();
            }
        }

        DashbordView dashbordView;
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (dashbordView == null || dashbordView.IsDisposed)
            {
                dashbordView = new DashbordView();
                dashbordView.MdiParent = this;
                dashbordView.FormBorderStyle = FormBorderStyle.None;
                dashbordView.Dock = DockStyle.Fill;
                dashbordView.Show();
            }
            else
            {
                if (dashbordView.WindowState == FormWindowState.Minimized)
                    dashbordView.WindowState = FormWindowState.Normal;
                dashbordView.BringToFront();
            }
        }
    }
}
