using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpmManagement.Models
{
    public interface ITaskRepository
    {
        void Add(TaskModel taskModel);
        void Edit(TaskModel taskModel);
        void Delete(int id);
        IEnumerable<TaskModel> GetAll();
        IEnumerable<TaskModel> GetByValue(string value);//Search
    }
}
