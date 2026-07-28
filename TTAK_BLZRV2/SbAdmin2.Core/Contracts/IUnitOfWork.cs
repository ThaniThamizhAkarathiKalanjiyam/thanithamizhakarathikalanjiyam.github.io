using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TTAK_BLZRV2.Core.Contracts
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
    }
}
