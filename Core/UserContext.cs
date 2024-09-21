using Apteka.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka.Core
{
    public static class UserContext
    {
        public static Employee AuthorizedPerson { get; set; }
    }
}
