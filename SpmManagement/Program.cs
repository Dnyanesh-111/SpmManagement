using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpmManagement.Models;
using SpmManagement._Repositories;
using SpmManagement.Views;
using SpmManagement.Presenters;
using System.Configuration;


namespace SpmManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IClientsView view = new ClientView();
            IClientsRepository repository = new ClientRepository(sqlConnectionString);
            new ClientPresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}
