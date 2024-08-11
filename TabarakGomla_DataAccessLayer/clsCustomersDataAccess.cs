using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabarakGomla_DataAccessLayer
{
    public class clsCustomersDataAccess
    {
        public static bool GetRowInfoByCustomerID(int CustomerID, ref int PersonID, ref string WorkPlaceAddress)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)Reader["PersonID"];
                    WorkPlaceAddress = (string)Reader["WorkPlaceAddress"];


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


        public static bool GetRowInfoByPersonID(ref int CustomerID, int PersonID, ref string WorkPlaceAddress)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM Customers WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    CustomerID = (int)Reader["CustomerID"];
                    WorkPlaceAddress = (string)Reader["WorkPlaceAddress"];


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


        public static int AddNewRow(int PersonID, string WorkPlaceAddress)
        {

            int CustomerID = -1;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"INSERT INTO Customers 
                               (PersonID, WorkPlaceAddress)     
                             VALUES
                               (@PersonID, @WorkPlaceAddress)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@WorkPlaceAddress", WorkPlaceAddress);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    CustomerID = InsertedID;
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


            return CustomerID;

        }
        public static bool UpdateRow(int CustomerID, int PersonID, string WorkPlaceAddress)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = $@"UPDATE Customers SET 
		PersonID = @PersonID,
		WorkPlaceAddress = @WorkPlaceAddress
		 WHERE CustomerID = @CustomerID
";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@WorkPlaceAddress", WorkPlaceAddress);


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

            string Query = @"SELECT * FROM Customers";

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

            string Query = "SELECT Count(*) FROM Customers WHERE CustomerID is not null";

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

        public static bool DeleteRow(int CustomerID)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "DELETE Customers WHERE CustomerID = @CustomerID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CustomerID", CustomerID);


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



        public static bool DoesRowExist(int CustomerID)
        {
            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Found=1 FROM Customers WHERE CustomerID = @CustomerID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CustomerID", CustomerID);


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
