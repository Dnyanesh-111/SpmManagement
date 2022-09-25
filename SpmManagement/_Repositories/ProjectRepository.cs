using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpmManagement.Models;

namespace SpmManagement._Repositories
{
    public class ProjectRepository : BaseRepository, IProjectRepository
    {

        //Constructor
        public ProjectRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProjectModel projectModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"insert into projects (name,client,requirements,cost,sdate,cdate,team,status)
                                       values(@name,@client,@requirement,@cost,@sdate,@cdate,@team,@status)";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = projectModel.Name;
                command.Parameters.Add("@client", SqlDbType.VarChar).Value = projectModel.Client;
                command.Parameters.Add("@requirement", SqlDbType.VarChar).Value = projectModel.Requirements;
                command.Parameters.Add("@cost", SqlDbType.VarChar).Value = projectModel.Cost;
                command.Parameters.Add("@sdate", SqlDbType.VarChar).Value = projectModel.Sdate;
                command.Parameters.Add("@cdate", SqlDbType.VarChar).Value = projectModel.Cdate;
                command.Parameters.Add("@team", SqlDbType.VarChar).Value = projectModel.Team;
                command.Parameters.Add("@satus", SqlDbType.VarChar).Value = projectModel.Status;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id )
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from projects where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProjectModel projectModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update projects Set name=@name,client=@client,requirements=@requirement,
                                      cost=@cost,sdate=@sdate,cdate=@cdate,team=@team,status=@status where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = projectModel.Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = projectModel.Name;
                command.Parameters.Add("@client", SqlDbType.Int).Value = projectModel.Client;
                command.Parameters.Add("@requirement", SqlDbType.VarChar).Value = projectModel.Requirements;
                command.Parameters.Add("@cost", SqlDbType.Int).Value = projectModel.Cost;
                command.Parameters.Add("@sdate", SqlDbType.VarChar).Value = projectModel.Sdate;
                command.Parameters.Add("@cdate", SqlDbType.VarChar).Value = projectModel.Cdate;
                command.Parameters.Add("@team", SqlDbType.VarChar).Value = projectModel.Team;
                command.Parameters.Add("@status", SqlDbType.VarChar).Value = projectModel.Status;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProjectModel> GetAll()
        {
            var projectList = new List<ProjectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *From Projects order by id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var projectModel = new ProjectModel();
                        projectModel.Id = (int)reader[0];
                        projectModel.Name = reader[1].ToString();
                        projectModel.Client = reader[2].ToString();
                        projectModel.Requirements = reader[3].ToString();
                        projectModel.Cost = (int)reader[4];
                        projectModel.Sdate = reader[5].ToString();
                        projectModel.Cdate = reader[6].ToString();
                        projectModel.Status = reader[6].ToString();
                        projectList.Add(projectModel);
                    }
                }
            }
            return projectList;
        }

        public IEnumerable<ProjectModel> GetByValue(string value)
        {
            var projectList = new List<ProjectModel>();
            int PId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string PName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *From Projects 
                                      where clientid = @id 
                                      order by clientid desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = PId;
                //command.Parameters.Add("@name", SqlDbType.VarChar).Value = CName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var projectModel = new ProjectModel();
                        projectModel.Id = (int)reader[0];
                        projectModel.Name = reader[1].ToString();
                        projectModel.Client = reader[2].ToString();
                        projectModel.Requirements = reader[3].ToString();
                        projectModel.Cost = (int)reader[4];
                        projectModel.Sdate = reader[5].ToString();
                        projectModel.Cdate = reader[6].ToString();
                        projectModel.Status = reader[6].ToString();
                        projectList.Add(projectModel);
                    }
                }
            }
            return projectList;
        }
    }
}
