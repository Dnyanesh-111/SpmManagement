using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpmManagement.Models
{
    public interface IClientsRepository
    {
        void Add(ClientsModel clientsModel);
        void Edit(ClientsModel clientsModel);
        void Delete(int id);
        IEnumerable<ClientsModel> GetAll();
        IEnumerable<ClientsModel> GetByValue(string value);//Search
    }
}
