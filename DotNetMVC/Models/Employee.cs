using DbUtility;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace DotNetMVC.Models {
    public class Employee : Result {
        public int EmployeeID { get; set; }

        [StringLength(45)]
        public string EmployeeName { get; set; }

        [StringLength(45)]
        public string Gender { get; set; }

        [StringLength(45)]
        public string City { get; set; }
        public Employee() {
        }
        public Employee(int? id) {
        }


        //private bool connection_open = false;
        //private MySqlConnection connection;
        public Employee(int arg_id) {
            //Get_Connection();
            EmployeeID = arg_id;

            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            DataRow dataRow = null;

            try
            {
                int id = 1;
                MySqlCommand command = new MySqlCommand
                {
                    CommandText = "select name, gender, city from instest.tblemployee where id = @id"
                };
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@id", id);
                using (DataObjectClass dataObjectClass = new DataObjectClass())
                {
                    dataTable = dataObjectClass.GetDataTablefromMySqlCmd(command);
                    dataRow = dataObjectClass.GetDataRowfromMySqlCmd(command);
                    dataSet = dataObjectClass.GetDataSetfromMySqlCmd(command);
                }
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        EmployeeName = Convert.IsDBNull(dataTable.Rows[0].ItemArray[0].ToString()) ? "" : dataTable.Rows[0].ItemArray[0].ToString();
                        Gender = Convert.IsDBNull(dataTable.Rows[0].ItemArray[1].ToString()) ? "" : dataTable.Rows[0].ItemArray[1].ToString();
                        City = Convert.IsDBNull(dataTable.Rows[0].ItemArray[2].ToString()) ? "" : dataTable.Rows[0].ItemArray[2].ToString();
                    }
                    else
                    {

                    }
                }
                else
                {

                }


                //MySqlCommand cmd = new MySqlCommand
                //{
                //    Connection = connection,
                //    CommandText = string.Format("select name, gender, city from instest.tblemployee where id = '{0}'", ID)

                //};
                //MySqlDataReader reader = cmd.ExecuteReader();
                //try
                //{
                //    reader.Read();


                //    if (reader.IsDBNull(0) == false)
                //    {
                //        Name = reader.GetString(0);
                //    }
                //    else
                //    {
                //        Name = null;
                //    }

                //    if (reader.IsDBNull(1) == false)
                //    {
                //        Gender = reader.GetString(1);
                //    }
                //    else
                //    {
                //        Gender = null;
                //    }

                //    if (reader.IsDBNull(2) == false)
                //    {
                //        City = reader.GetString(2);
                //    }
                //    else
                //    {
                //        City = null;
                //    }

                //    //if (reader.IsDBNull(3) == false)
                //    //{
                //    //    Photo = new byte[reader.GetInt32(4)];
                //    //    reader.GetBytes(3, 0, Photo, 0, reader.GetInt32(4));
                //    //}
                //    //else
                //    //{
                //    //    Photo = null;
                //    //}
                //    reader.Close();

                //}
                //catch (MySqlException e)
                //{
                //    string MessageString = "Read error occurred  / entry not found loading the Column details: "
                //        + e.ErrorCode + " - " + e.Message + "; \n\nPlease Continue";
                //    //MessageBox.Show(MessageString, "SQL Read Error");
                //    reader.Close();
                //    Name = MessageString;
                //    Gender = City = null;
                //}
            }
            catch (MySqlException e)
            {
                string MessageString = "The following error occurred loading the Column details: "
                    + e.ErrorCode + " - " + e.Message;
                EmployeeName = MessageString;
                Gender = City = null;
            }




            //connection.Close();


        }




        //private void Get_Connection()
        //{
        //    connection_open = false;

        //    connection = new MySqlConnection
        //    {
        //        ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString
        //    };
        //    if (Open_Local_Connection())
        //    {
        //        connection_open = true;
        //    }
        //    else
        //    {
        //        //					MessageBox::Show("No database connection connection made...\n Exiting now", "Database Connection Error");
        //        //					 Application::Exit();
        //    }
        //}

        //private bool Open_Local_Connection()
        //{
        //    try
        //    {
        //        connection.Open();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}