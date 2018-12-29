using DbUtility;
using DotNetMVC.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DotNetMVC.DAL {
    public class EmployeeDL {
        public Employee GetEmployee(int? id) {
            Employee employee = new Employee();
            employee.EmployeeID = (int)id;
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlCommand command = new MySqlCommand("instest.Proc_GetEmployeeDetails"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpID", employee.EmployeeID);
                    using (DataObjectClass dataObjectClass = new DataObjectClass())
                    {
                        dataTable = dataObjectClass.GetDataTablefromMySqlCmd(command);
                    }
                }
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        employee.EmployeeName = Convert.IsDBNull(dataTable.Rows[0].ItemArray[0].ToString()) ? "" : dataTable.Rows[0].ItemArray[0].ToString();
                        employee.Gender = Convert.IsDBNull(dataTable.Rows[0].ItemArray[1].ToString()) ? "" : dataTable.Rows[0].ItemArray[1].ToString();
                        employee.City = Convert.IsDBNull(dataTable.Rows[0].ItemArray[2].ToString()) ? "" : dataTable.Rows[0].ItemArray[2].ToString();
                    }
                    else
                    {
                        employee.ErrorText = "No Data Found";

                    }
                }
                else
                {
                    employee.ErrorText = "No Data Found";
                }

            }
            catch (Exception ex)
            {
                employee.ErrorText = ex.Message.ToString();
                throw;
            }
            finally
            {
                if (dataTable != null)
                {
                    dataTable.Dispose();
                    dataTable = null;
                }
            }
            return employee;
        }
    }
}