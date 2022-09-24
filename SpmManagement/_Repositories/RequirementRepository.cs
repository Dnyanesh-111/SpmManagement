using SpmManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpmManagement._Repositories
{
    public class RequirementRepository : BaseRepository, IRequirementRepository
    {
        public void Add(RequirementModel RequirementModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(RequirementModel RequirementModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RequirementModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RequirementModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
