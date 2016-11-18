using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionManager.Credentials
{
    public interface IDBCredentials
    {
        // Property signatures:
        string UserName
        {
            get;
        }

        string UserPassword
        {
            get;
        }
    }
}
