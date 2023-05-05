using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject.TestUtils
{
    public class ExcelDataReader
    {

        public class LoginData
        {
            public string Scenario { get; set; }
            public string UserId { get; set; }
            public string Password { get; set; }
        }
    }
}
