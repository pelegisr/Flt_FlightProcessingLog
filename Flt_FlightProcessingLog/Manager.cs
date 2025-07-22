using Flt_FlightProcessingLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peleg.Flt_FlightProcessingLog
{
    public class Manager : StartMenuInterface.IStartMenu
    {
        public void Run(ref string connectionString, ref string taskName)
        {
            new FrmMain { SqlConnectionString = connectionString }.ShowDialog();
        }
    }
}
