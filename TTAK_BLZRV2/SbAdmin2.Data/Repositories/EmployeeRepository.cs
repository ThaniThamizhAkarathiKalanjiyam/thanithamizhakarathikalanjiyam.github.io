using TTAK_BLZRV2.Core.Contracts;
using TTAK_BLZRV2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TTAK_BLZRV2.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>
    {
        private MainContext MainContext { get => _mainContext as MainContext; }
        public EmployeeRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
