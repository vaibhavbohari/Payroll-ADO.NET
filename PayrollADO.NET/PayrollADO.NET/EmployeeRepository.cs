using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PayrollADO.NET
{
    public class EmployeeRepository
    {
        //For sql authentication
        public static string connectionString = @"Data Source=LAPTOP-N926GS71;Initial Catalog=payroll_services;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
    }
}
