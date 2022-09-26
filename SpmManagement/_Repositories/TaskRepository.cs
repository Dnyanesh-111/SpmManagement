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
    public class TaskRepository : BaseRepository, ITaskRepository
    {
        //Constructor
        public TaskRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(TaskModel taskModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"insert into tasks (project,name,decrp,assignedTo,duration,dependency,status,work)
                                       values(@project,@name,@decrp,@assignedTo,@duration,@dependency,@status,@work)";
                command.Parameters.Add("@project", SqlDbType.VarChar).Value = taskModel.Project;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = taskModel.Name;
                command.Parameters.Add("@decrp", SqlDbType.VarChar).Value = taskModel.Description;
                command.Parameters.Add("@assignedTo", SqlDbType.VarChar).Value = taskModel.AssignedTo;
                command.Parameters.Add("@duration", SqlDbType.VarChar).Value = taskModel.Duration;
                command.Parameters.Add("@dependency", SqlDbType.VarChar).Value = taskModel.Dependency;
                command.Parameters.Add("@status", SqlDbType.VarChar).Value = taskModel.Status;
                command.Parameters.Add("@work", SqlDbType.VarChar).Value = taskModel.Work;
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
                command.CommandText = "delete from tasks where taskid=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(TaskModel taskModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update tasks Set project=@project,name=@name, decrp=@decrp, assignedTo=@assignedTo, 
                                      duration=@duration, dependency=@dependency, status=@status, work=@work where task+id=@id";
                command.Parameters.Add("@project", SqlDbType.VarChar).Value = taskModel.Project;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = taskModel.Name;
                command.Parameters.Add("@decrp", SqlDbType.VarChar).Value = taskModel.Description;
                command.Parameters.Add("@assignedTo", SqlDbType.VarChar).Value = taskModel.AssignedTo;
                command.Parameters.Add("@duration", SqlDbType.VarChar).Value = taskModel.Duration;
                command.Parameters.Add("@dependency", SqlDbType.VarChar).Value = taskModel.Dependency;
                command.Parameters.Add("@status", SqlDbType.VarChar).Value = taskModel.Status;
                command.Parameters.Add("@work", SqlDbType.VarChar).Value = taskModel.Work;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TaskModel> GetAll()
        {
            var taskList = new List<TaskModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *From tasks order by taskid desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var taskModel = new TaskModel();
                        taskModel.Id = (int)reader[0];
                        taskModel.Project = reader[1].ToString();
                        taskModel.Name = reader[2].ToString();
                        taskModel.Description = reader[3].ToString();
                        taskModel.Duration = reader[4].ToString();
                        taskModel.Dependency = reader[5].ToString();
                        taskModel.Status = reader[6].ToString();
                        taskModel.Work = reader[6].ToString();
                        taskList.Add(taskModel);

                    }
                }
            }
            return taskList;
        }

        public IEnumerable<TaskModel> GetByValue(string value)
        {
            var taskList = new List<TaskModel>();
            int TId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string CName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *From Tasks 
                                      where taskid = @id 
                                      order by taskid desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = TId;
                //command.Parameters.Add("@name", SqlDbType.VarChar).Value = CName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var taskModel = new TaskModel();
                        taskModel.Id = (int)reader[0];
                        taskModel.Project = reader[1].ToString();
                        taskModel.Name = reader[2].ToString();
                        taskModel.Description = reader[3].ToString();
                        taskModel.Duration = reader[4].ToString();
                        taskModel.Dependency = reader[5].ToString();
                        taskModel.Status = reader[6].ToString();
                        taskModel.Work = reader[6].ToString();
                        taskList.Add(taskModel);
                    }
                }
            }
            return taskList;
        }
    }
}
