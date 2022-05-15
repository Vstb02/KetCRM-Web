using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Shared.Logger
{
    public interface ILogger<out T>
    {
        void Verbose(string messageTemplate, params object[] propertyValues);
        void Debug(string messageTemplate, params object[] propertyValues);

        void Fatal(Exception exception, string messageTemplate, params object[] propertyValues);
        void Error(Exception exception, string messageTemplate, params object[] propertyValues);

        void Info(string messageTemplate, params object[] propertyValues);
        void Warn(string messageTemplate, params object[] propertyValues);

        IDisposable WithScope<TState>(TState state);
        IDisposable WithScope(string msgFormat, params object[] propertyValues);
    }
}
