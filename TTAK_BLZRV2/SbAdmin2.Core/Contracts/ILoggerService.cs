using System;
using System.Collections.Generic;
using System.Text;

namespace TTAK_BLZRV2.Core.Contracts
{
    public interface ILoggerService
    {
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}
