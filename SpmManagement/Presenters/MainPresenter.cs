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
            this.mainView.ShowRequirementView += ShowRequirementView;
        }

        private void ShowRequirementView(object sender, EventArgs e)
        {
            IRequirementView view = RequirementView.GetInstance((MainView)mainView);
            IRequirementRepository repository = new RequirementRepository(sqlConnectionString);
            new RequirementPresenter(view, repository);
        }

        private void ShowClientsView(object sender, EventArgs e)
        {
            IClientsView view = ClientView.GetInstance((MainView)mainView);
            IClientsRepository repository = new ClientRepository(sqlConnectionString);
            new ClientPresenter(view, repository);
        }
    }
}
