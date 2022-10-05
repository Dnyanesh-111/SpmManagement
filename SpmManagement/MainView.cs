using MaterialSkin;
using MaterialSkin.Controls;
using SpmManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpmManagement
{
    public partial class MainView : MaterialForm, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme
            (
                Primary.BlueGrey800, 
                Primary.BlueGrey900, 
                Primary.BlueGrey500, 
                Accent.Indigo700, 
                TextShade.WHITE
            );

                //btnClients.Click += delegate { ShowClientView?.Invoke(this, EventArgs.Empty); };
                //btnRequirements.Click += delegate { ShowRequirementView?.Invoke(this, EventArgs.Empty); };
                //btnProjects.Click += delegate { ShowProjectView?.Invoke(this, EventArgs.Empty); };
                //btnTasks.Click += delegate { ShowTaskView?.Invoke(this, EventArgs.Empty); };
                //tabClients.Click+= delegate { ShowTaskView?.Invoke(this, EventArgs.Empty); };

        }

            public event EventHandler ShowClientView;
            public event EventHandler ShowRequirementView;
            public event EventHandler ShowProjectView;
            public event EventHandler ShowTaskView;
            public event EventHandler ShowTeamView;


     }
}




