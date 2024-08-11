using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabarakGomla_DataAccessLayer
{
    public class clsCustomersDebtsDataAccess
    {
        public static bool GetRowInfoByDebtID(int DebtID, ref int CustomerID, ref decimal Amount)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM CustomersDebt WHERE DebtID = @DebtID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DebtID", DebtID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    CustomerID = (int)Reader["CustomerID"];
                    Amount = (decimal)Reader["Amount"];


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


        public static bool GetRowInfoByCustomerID(ref int DebtID, int CustomerID, ref decimal Amount)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM CustomersDebt WHERE CustomerID = @CustomerID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    DebtID = (int)Reader["DebtID"];
                    Amount = (decimal)Reader["Amount"];


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


        public static int AddNewRow(int CustomerID, decimal Amount)
        {

            int DebtID = -1;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"INSERT INTO CustomersDebt 
                               (CustomerID, Amount)     
                             VALUES
                               (@CustomerID, @Amount)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
            Command.Parameters.AddWithValue("@Amount", Amount);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    DebtID = InsertedID;
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


            return DebtID;

        }
        public static bool UpdateRow(int DebtID, int CustomerID, decimal Amount)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = $@"UPDATE CustomersDebt SET 
		CustomerID = @CustomerID,
		Amount = @Amount
		 WHERE DebtID = @DebtID
";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@DebtID", DebtID);
            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
            Command.Parameters.AddWithValue("@Amount", Amount);


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

            string Query = @"SELECT * FROM CustomersDebt";

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

        public static DataTable GetAllRowsByCustomerID(int CustomerID)
        {

            DataTable DT = new DataTable();

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"SELECT * FROM CustomersDebt WHERE CustomerID = @CustomerID";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

        public static DataTable Get_dgv_CustomersDebts()
        {

            DataTable DT = new DataTable();

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"SELECT * FROM dgv_customersDebts";

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

            string Query = "SELECT Count(*) FROM CustomersDebt WHERE DebtID is not null";

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

        public static bool DeleteRow(int DebtID)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "DELETE CustomersDebt WHERE DebtID = @DebtID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DebtID", DebtID);


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



        public static bool DoesRowExist(int DebtID)
        {
            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Found=1 FROM CustomersDebt WHERE DebtID = @DebtID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DebtID", DebtID);


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
