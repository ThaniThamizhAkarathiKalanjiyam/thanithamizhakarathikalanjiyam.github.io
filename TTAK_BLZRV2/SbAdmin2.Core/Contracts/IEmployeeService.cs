using TTAK_BLZRV2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Core.Contracts
{
    public interface IEmployeeService : IService<Employee>
    {
        decimal SumSalary(Func<Employee, bool> predicate);
        int ActiveEmployeeCount();
        int InactiveEmployeeCount();
        int Process();
    }
}
