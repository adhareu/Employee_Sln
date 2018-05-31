using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asset.Infrastructure;
using Asset.Model;


namespace Asset.Repository
{
    public interface IDepartmentRepository : IRepository<Department>
    {
    }
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
        
    }
}
