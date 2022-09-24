using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpmManagement.Models
{
    public interface IRequirementRepository
    {
        void Add(RequirementModel RequirementModel);
        void Edit(RequirementModel RequirementModel);
        void Delete(int id);
        IEnumerable<RequirementModel> GetAll();
        IEnumerable<RequirementModel> GetByValue(string value);//Search
    }
}
