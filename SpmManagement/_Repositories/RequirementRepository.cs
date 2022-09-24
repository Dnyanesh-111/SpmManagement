using SpmManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpmManagement._Repositories
{
    public class RequirementRepository : BaseRepository, IRequirementRepository
    {
        //Constructor
        public RequirementRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(RequirementModel requirementModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"insert into requirements (cname,doc) 
                                      values(@cname,@file)";
                command.Parameters.Add("@cname", SqlDbType.VarChar).Value = requirementModel.Client;
                command.Parameters.Add("@file", SqlDbType.VarChar).Value = requirementModel.File;
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
                command.CommandText = "delete from requirements where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(RequirementModel requirementModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update requirements Set cname=@cname, doc=@file where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = requirementModel.Id;
                command.Parameters.Add("@cname", SqlDbType.VarChar).Value = requirementModel.Client;
                command.Parameters.Add("@file", SqlDbType.VarChar).Value = requirementModel.File;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<RequirementModel> GetAll()
        {
            var requirementList = new List<RequirementModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *From Requirements order by id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var requirementModel = new RequirementModel();
                        requirementModel.Id = (int)reader[0];
                        requirementModel.Client = reader[1].ToString();
                        requirementModel.File = reader[2].ToString();
                        requirementList.Add(requirementModel);

                    }
                }
            }
            return requirementList;
        }

        public IEnumerable<RequirementModel> GetByValue(string value)
        {
            var requirementList = new List<RequirementModel>();
            int RId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string CName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *From requirements 
                                      where id = @id 
                                      order by id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = RId;
                //command.Parameters.Add("@name", SqlDbType.VarChar).Value = CName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var requirementModel = new RequirementModel();
                        requirementModel.Id = (int)reader[0];
                        requirementModel.Client = reader[1].ToString();
                        requirementModel.File = reader[2].ToString();
               
                        requirementList.Add(requirementModel);
                    }
                }
            }
            return requirementList;
        }
    }
}
