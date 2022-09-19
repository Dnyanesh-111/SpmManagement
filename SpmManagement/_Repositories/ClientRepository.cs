using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SpmManagement.Models;

namespace SpmManagement._Repositories
{
    public class ClientRepository : BaseRepository, IClientsRepository
    {
        //Constructor
        public ClientRepository(String connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ClientsModel clientsModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ClientsModel clientsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientsModel> GetAll()
        {
            var clientList = new List<ClientsModel>();
            using (var connection = new SqlConnection(connectionString))
                using(var command=new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *From Clients order by clientid desc";
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clientModel = new ClientsModel();
                        clientModel.Id = (int)reader[0];
                        clientModel.Name = reader[1].ToString();
                        clientModel.Email = reader[2].ToString();
                        clientModel.Mobile = reader[3].ToString();
                        clientModel.City = reader[4].ToString();
                        clientModel.State = reader[5].ToString();
                        clientModel.Country = reader[6].ToString();

                    }
                }
            }
                return clientList;
          
        }

        public IEnumerable<ClientsModel> GetByValue(string value)
        {
            var clientList = new List<ClientsModel>();
            int clientId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string clientName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *From Clients 
                                      where clientid = @clientId or name = like @name+'%' 
                                      order by id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clientModel = new ClientsModel();
                        clientModel.Id = (int)reader[0];
                        clientModel.Name = reader[1].ToString();
                        clientModel.Email = reader[2].ToString();
                        clientModel.Mobile = reader[3].ToString();
                        clientModel.City = reader[4].ToString();
                        clientModel.State = reader[5].ToString();
                        clientModel.Country = reader[6].ToString();

                    }
                }
            }
            return clientList;

        }
    }
}
