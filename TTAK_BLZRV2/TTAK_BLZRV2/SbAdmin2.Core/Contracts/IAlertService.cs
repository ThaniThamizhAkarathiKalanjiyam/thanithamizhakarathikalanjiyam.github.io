using TTAK_BLZRV2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Core.Contracts
{
    public interface IAlertService : IService<Alert>
    {
        //Task<IEnumerable<Alert>> GetAllAsync();
        IEnumerable<Alert> GetMany(Func<Alert, bool> expression);
        //Task<Alert> GetByIdAsync(int id);
        int ActiveAlertCount();
    }
}
