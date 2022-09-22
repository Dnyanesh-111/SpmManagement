using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpmManagement.Views;
using SpmManagement._Repositories;
using SpmManagement.Models;

namespace SpmManagement.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowClientView += ShowClientsView;
        }

        private void ShowClientsView(object sender, EventArgs e)
        {
            IClientsView view = ClientView.GetInstance((MainView)mainView);
            IClientsRepository repository = new ClientRepository(sqlConnectionString);
            new ClientPresenter(view, repository);
        }
    }
}
