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
        public ClientRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ClientsModel clientsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"insert into Clients (cname,email,mobile,city,state,country)
                                       values(@name,@email,@mobile,@city,@state,@country)";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = clientsModel.CName;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = clientsModel.Email;
                command.Parameters.Add("@mobile", SqlDbType.VarChar).Value = clientsModel.Mobile;
                command.Parameters.Add("@city", SqlDbType.VarChar).Value = clientsModel.City;
                command.Parameters.Add("@state", SqlDbType.VarChar).Value = clientsModel.State;
                command.Parameters.Add("@country", SqlDbType.VarChar).Value = clientsModel.Country;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Clients where clientid=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value =id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ClientsModel clientsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update clients Set cname=@name, email=@email, mobile=@mobile, 
                                      city=@city, state=@state, country=@country where clientid=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value =  clientsModel.Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = clientsModel.CName;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = clientsModel.Email;
                command.Parameters.Add("@mobile", SqlDbType.VarChar).Value = clientsModel.Mobile;
                command.Parameters.Add("@city", SqlDbType.VarChar).SqlValue = clientsModel.City;
                command.Parameters.Add("@state", SqlDbType.VarChar).Value = clientsModel.State;
                command.Parameters.Add("@country", SqlDbType.VarChar).Value = clientsModel.Country;
                command.ExecuteNonQuery();
            }
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
                        clientModel.CName = reader[1].ToString();
                        clientModel.Email = reader[2].ToString();
                        clientModel.Mobile = reader[3].ToString();
                        clientModel.City = reader[4].ToString();
                        clientModel.State = reader[5].ToString();
                        clientModel.Country = reader[6].ToString();
                        clientList.Add(clientModel);

                    }
                }
            }
                return clientList;
          
        }

        public IEnumerable<ClientsModel> GetByValue(string value)
        {
            var clientList = new List<ClientsModel>();
            int CId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string CName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *From Clients 
                                      where clientid = @id
                                      order by clientid desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = CId;
                //command.Parameters.Add("@name", SqlDbType.VarChar).Value = CName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clientModel = new ClientsModel();
                        clientModel.Id = (int)reader[0];
                        clientModel.CName = reader[1].ToString();
                        clientModel.Email = reader[2].ToString();
                        clientModel.Mobile = reader[3].ToString();
                        clientModel.City = reader[4].ToString();
                        clientModel.State = reader[5].ToString();
                        clientModel.Country = reader[6].ToString();
                        clientList.Add(clientModel);
                    }
                }
            }
            return clientList;

        }
    }
}
