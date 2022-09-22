using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpmManagement.Views
{
     public   interface IMainView
    {
        event EventHandler ShowClientView;
        event EventHandler ShowProjectView;
        event EventHandler ShowTaskView;
        event EventHandler ShowTeamView;
    }
}
