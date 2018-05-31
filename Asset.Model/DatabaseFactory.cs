using System.Data.Entity;
using Asset.Infrastructure;

namespace Asset.Model
{
    /// <summary>
    /// Database Factory
    /// Manage Db Context
    /// Author: Asif Iqbal
    /// </summary>
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private DbContext dataContext;
        public DbContext Get()
        {
            return dataContext ?? (dataContext = new EmployeeDBEntities());
        }
       
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
