using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabarakGomla_DataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public static bool GetRowInfoByPersonID(int PersonID, ref string FirstName, ref string SecondName, ref string LastName, ref DateTime DateOfBirth, ref bool Gender, ref string ProfilePic, ref string Phone, ref string Bio)
        {

            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)Reader["FirstName"];

                    if (Reader["SecondName"] != DBNull.Value)
                    {
                        SecondName = (string)Reader["SecondName"];
                    }
                    LastName = (string)Reader["LastName"];

                    if (Reader["DateOfBirth"] != DBNull.Value)
                    {
                        DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    }
                    Gender = (bool)Reader["Gender"];

                    if (Reader["ProfilePic"] != DBNull.Value)
                    {
                        ProfilePic = (string)Reader["ProfilePic"];
                    }

                    if (Reader["Phone"] != DBNull.Value)
                    {
                        Phone = (string)Reader["Phone"];
                    }

                    if (Reader["Bio"] != DBNull.Value)
                    {
                        Bio = (string)Reader["Bio"];
                    }


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


        public static int AddNewRow(string FirstName, string SecondName, string LastName, DateTime DateOfBirth, bool Gender, string ProfilePic, string Phone, string Bio)
        {

            int PersonID = -1;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"INSERT INTO People 
                               (FirstName, SecondName, LastName, DateOfBirth, Gender, ProfilePic, Phone, Bio)     
                             VALUES
                               (@FirstName, @SecondName, @LastName, @DateOfBirth, @Gender, @ProfilePic, @Phone, @Bio)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);

            if (SecondName != null && SecondName.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@SecondName", SecondName);
            else
                Command.Parameters.AddWithValue("@SecondName", DBNull.Value);
            Command.Parameters.AddWithValue("@LastName", LastName);

            if (DateOfBirth != null && DateOfBirth.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            else
                Command.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
            Command.Parameters.AddWithValue("@Gender", Gender);

            if (ProfilePic != null && ProfilePic.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@ProfilePic", ProfilePic);
            else
                Command.Parameters.AddWithValue("@ProfilePic", DBNull.Value);

            if (Phone != null && Phone.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@Phone", Phone);
            else
                Command.Parameters.AddWithValue("@Phone", DBNull.Value);

            if (Bio != null && Bio.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@Bio", Bio);
            else
                Command.Parameters.AddWithValue("@Bio", DBNull.Value);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
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


            return PersonID;

        }
        public static bool UpdateRow(int PersonID, string FirstName, string SecondName, string LastName, DateTime DateOfBirth, bool Gender, string ProfilePic, string Phone, string Bio)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = $@"UPDATE People SET 
		FirstName = @FirstName,
		SecondName = @SecondName,
		LastName = @LastName,
		DateOfBirth = @DateOfBirth,
		Gender = @Gender,
		ProfilePic = @ProfilePic,
		Phone = @Phone,
		Bio = @Bio
		 WHERE PersonID = @PersonID
";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);

            if (SecondName != null && SecondName.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@SecondName", SecondName);
            else
                Command.Parameters.AddWithValue("@SecondName", DBNull.Value);
            Command.Parameters.AddWithValue("@LastName", LastName);

            if (DateOfBirth != null && DateOfBirth.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            else
                Command.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
            Command.Parameters.AddWithValue("@Gender", Gender);

            if (ProfilePic != null && ProfilePic.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@ProfilePic", ProfilePic);
            else
                Command.Parameters.AddWithValue("@ProfilePic", DBNull.Value);

            if (Phone != null && Phone.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@Phone", Phone);
            else
                Command.Parameters.AddWithValue("@Phone", DBNull.Value);

            if (Bio != null && Bio.ToString() != string.Empty)
                Command.Parameters.AddWithValue("@Bio", Bio);
            else
                Command.Parameters.AddWithValue("@Bio", DBNull.Value);


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

            string Query = @"SELECT * FROM People";

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

            string Query = "SELECT Count(*) FROM People WHERE PersonID is not null";

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

        public static bool DeleteRow(int PersonID)
        {

            int RowsAffected = 0;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "DELETE People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);


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



        public static bool DoesRowExist(int PersonID)
        {
            bool IsFound = false;

            string connectionString = "Server=.;Database=TabarakGomlaDB;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);


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
