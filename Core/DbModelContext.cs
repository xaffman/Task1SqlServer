using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1SqlServer.Model;

namespace Task1SqlServer.Core
{
    public static class DbModelContext
    {
        public static Task1Entities DB { get; set; }
    }
}

