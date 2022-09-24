using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpmManagement.Models
{
    public interface IProjectRepository
    {
        void Add(ProjectModel projectModel);
        void Edit(ProjectModel projectModel);
        void Delete(ProjectModel projectModel);
        IEnumerable<ProjectModel> GetAll();
        IEnumerable<ProjectModel> GetByValue(string value);//Searchs
    }
}
