using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.DAL
{
    public class SchoolConfiguration:DbConfiguration
    {
        public SchoolConfiguration()
        {
                SetExecutionStrategy("System.Data.SqlClient",()=>new SqlAzureExecutionStrategy());
        }
    }
}
