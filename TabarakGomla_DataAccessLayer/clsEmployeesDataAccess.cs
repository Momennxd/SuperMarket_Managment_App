using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabarakGomla_DataAccessLayer
{
    public class clsEmployeesDataAccess
    {
        public static bool GetRowInfoByEmployeeID(int EmployeeID, ref int PersonID, ref decimal Wage, ref string Rank)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)Reader["PersonID"];
                    Wage = (decimal)Reader["Wage"];
                    Rank = (string)Reader["Rank"];


                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }


        public static bool GetRowInfoByPersonID(ref int EmployeeID, int PersonID, ref decimal Wage, ref string Rank)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM Employees WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    EmployeeID = (int)Reader["EmployeeID"];
                    Wage = (decimal)Reader["Wage"];
                    Rank = (string)Reader["Rank"];


                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }


        public static int AddNewRow(int PersonID, decimal Wage, string Rank)
        {

            int EmployeeID = -1;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"INSERT INTO Employees 
                               (PersonID, Wage, Rank)     
                             VALUES
                               (@PersonID, @Wage, @Rank)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@Wage", Wage);
            Command.Parameters.AddWithValue("@Rank", Rank);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    EmployeeID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }


            return EmployeeID;

        }
        public static bool UpdateRow(int EmployeeID, int PersonID, decimal Wage, string Rank)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = $@"UPDATE Employees SET 
		PersonID = @PersonID,
		Wage = @Wage,
		Rank = @Rank
		 WHERE EmployeeID = @EmployeeID
";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@Wage", Wage);
            Command.Parameters.AddWithValue("@Rank", Rank);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }

        public static DataTable GetAllRows()
        {

            DataTable DT = new DataTable();

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"SELECT * FROM Employees";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return DT;

        }

        public static int GetNumberOfRows()
        {
            int NumberOfRows = -1;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Count(*) FROM Employees WHERE EmployeeID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNum))
                {
                    NumberOfRows = AcualNum;
                }


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return NumberOfRows;
        }

        public static bool DeleteRow(int EmployeeID)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "DELETE Employees WHERE EmployeeID = @EmployeeID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }



        public static bool DoesRowExist(int EmployeeID)
        {
            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Found=1 FROM Employees WHERE EmployeeID = @EmployeeID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

    }
}
