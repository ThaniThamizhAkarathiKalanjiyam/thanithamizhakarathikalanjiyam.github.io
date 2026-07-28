using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTAK_BLZRV2.Core.Contracts;
using TTAK_BLZRV2.Core.Models;

namespace TTAK_BLZRV2.Service.Services
{
    //public class AlertService : Service<Alert>, IAlertService
    //{
    //    public IRepository<Alert> _repository;
    //    public AlertService(IRepository<Alert> repository)
    //    {
    //        _repository = repository;
    //    }

    //    public int ActiveAlertCount()
    //    {
    //        return _repository.GetManyAsync(m => !m.IsDeleted).Count();
    //    }

    //    public async Task<IEnumerable<Alert>> GetAllAsync()
    //    {
    //        return await _repository.GetAllAsync();
    //    }

    //    public async Task<Alert> GetByIdAsync(int id)
    //    {
    //        return await _repository.GetByIdAsync(id);
    //    }

    //    public IEnumerable<Alert> GetMany(Func<Alert, bool> expression)
    //    {
    //        return _repository.GetManyAsync(expression);
    //    }
    //}



    public class AlertService : Service<Alert>, IAlertService
    {
        public AlertService(IRepository<Alert> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public int ActiveAlertCount()
        {
            return _repository.GetManyAsync(m => !m.IsDeleted).Count();
        }

        public IEnumerable<Alert> GetMany(Func<Alert, bool> expression)
        {
            return _repository.GetManyAsync(expression);
        }

        public int InactiveAlertCount()
        {
            return _repository.GetManyAsync(m => m.IsDeleted).Count();
        }

        public int Process()
        {
            return new Random().Next(1, 100);
        }

        public decimal SumSalary(Func<Alert, bool> predicate)
        {
            return _repository.GetManyAsync(predicate).Sum(m => m.Id);
        }
    }
}
