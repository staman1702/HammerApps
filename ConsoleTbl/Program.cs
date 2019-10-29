using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTbl
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TextTablePrinter("EmployeeNo", 
                                        "EmployeeName      ",
                                        "Salary      ", 
                                        "DepartmentNo");


            using (SqlConnection connection = new SqlConnection("Server=(LocalDb)\\MSSQLLocalDB;Database=HammerAppMVCDatabase;integrated security=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Employees", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                t.AddRow(
                                    reader["EmployeeNo"].ToString(), 
                                    reader["EmployeeName"].ToString(),
                                    reader["Salary"].ToString().Insert((reader["Salary"].ToString().Length - 3), " "), 
                                    reader["DepartmentNo"].ToString());
                            }
                        }
                    }
                }
            }
            t.Print();
            Console.ReadKey();
        }
    }
}