using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{
    public interface IUnitOfWork
    {
        void Commit();
        void Transaction(Action callback);
    }
}
