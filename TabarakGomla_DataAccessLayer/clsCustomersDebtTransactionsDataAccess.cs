using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabarakGomla_DataAccessLayer
{
    public class clsCustomersDebtTransactionsDataAccess
    {
        public static bool GetRowInfoByDebtTransactionID(int DebtTransactionID,
            ref int CustomerID, ref int DebtID, ref decimal DebtOldValue, ref decimal DebtNewValue, ref DateTime TransactionDate, ref int CurrentUserID)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM CustomersDebtTransactions WHERE DebtTransactionID = @DebtTransactionID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DebtTransactionID", DebtTransactionID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    CustomerID = (int)Reader["CustomerID"];
                    DebtID = (int)Reader["DebtID"];
                    DebtNewValue = (decimal)Reader["DebtNewValue"];
                    DebtOldValue = (decimal)Reader["DebtOldValue"];
                    TransactionDate = (DateTime)Reader["TransactionDate"];
                    CurrentUserID = (int)Reader["CurrentUserID"];


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


        public static int AddNewRow(int CustomerID, int DebtID, decimal DebtOldValue, decimal DebtNewValue, DateTime TransactionDate, int CurrentUserID)
        {

            int DebtTransactionID = -1;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"INSERT INTO CustomersDebtTransactions 
                               (CustomerID, DebtID, DebtOldValue,DebtNewValue, TransactionDate, CurrentUserID)     
                             VALUES
                               (@CustomerID, @DebtID, @DebtOldValue, @DebtNewValue, @TransactionDate, @CurrentUserID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
            Command.Parameters.AddWithValue("@DebtID", DebtID);
            Command.Parameters.AddWithValue("@DebtNewValue", DebtNewValue);
            Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            Command.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
            Command.Parameters.AddWithValue("@DebtOldValue", DebtOldValue);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    DebtTransactionID = InsertedID;
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


            return DebtTransactionID;

        }
        public static bool UpdateRow(int DebtTransactionID, int CustomerID, int DebtID, decimal DebtOldValue, decimal DebtNewValue, DateTime TransactionDate, int CurrentUserID)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = $@"UPDATE CustomersDebtTransactions SET 
		CustomerID = @CustomerID,
		DebtID = @DebtID,
		DebtNewValue = @DebtNewValue,
        DebtOldValue = @DebtOldValue,
		TransactionDate = @TransactionDate,
		CurrentUserID = @CurrentUserID
		 WHERE DebtTransactionID = @DebtTransactionID
";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@DebtTransactionID", DebtTransactionID);
            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
            Command.Parameters.AddWithValue("@DebtID", DebtID);
            Command.Parameters.AddWithValue("@DebtNewValue", DebtNewValue);
            Command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            Command.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
            Command.Parameters.AddWithValue("@DebtOldValue", DebtOldValue);


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

            string Query = @"SELECT * FROM CustomersDebtTransactions";

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

        public static DataTable SP_GetCustomersDebtsTransactionsByDate(DateTime _date)
        {

            DataTable DT = new DataTable();

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = $@"

                        DECLARE @TodayDate DATE = @_date
                                                
                        EXEC	[dbo].[SP_GetDebtTransactionsByDate]
                        		@Date = @TodayDate";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@_date", _date);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                //commenting this out to get the columns of the reader table even though if it is empty
                //while (Reader.HasRows)
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

            string Query = "SELECT Count(*) FROM CustomersDebtTransactions WHERE DebtTransactionID is not null";

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

        public static bool DeleteRow(int DebtTransactionID)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "DELETE CustomersDebtTransactions WHERE DebtTransactionID = @DebtTransactionID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DebtTransactionID", DebtTransactionID);


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



        public static bool DoesRowExist(int DebtTransactionID)
        {
            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Found=1 FROM CustomersDebtTransactions WHERE DebtTransactionID = @DebtTransactionID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DebtTransactionID", DebtTransactionID);


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
