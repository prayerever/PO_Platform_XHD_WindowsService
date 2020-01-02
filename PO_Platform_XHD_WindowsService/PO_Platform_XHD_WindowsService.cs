using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace PO_Platform_XHD_WindowsService
{
    public partial class PO_Platform_XHD_WindowsService : ServiceBase
    {
        public PO_Platform_XHD_WindowsService()
        {
            string s = "hello";
            Console.WriteLine(s);
        }

    }
}
