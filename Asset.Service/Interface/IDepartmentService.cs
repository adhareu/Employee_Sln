using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asset.Model;

namespace Asset.Service
{
   public interface IDepartmentService
    {
        List<Department> GetAll();
        Department GetById(int id);
        List<Department> FindByName(string name);
        bool Add(Department aDepartment);
        bool Update(Department aDepartment);
        bool Delete(Department aDepartment);
    }
}
