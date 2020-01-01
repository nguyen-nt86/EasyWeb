using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{ 
    public interface IDbFactory: IDisposable
    {
        EasyWebContext Init();
    }
}
