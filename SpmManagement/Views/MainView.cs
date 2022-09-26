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
        public event EventHandler ShowTeamView;

        
    }
}
