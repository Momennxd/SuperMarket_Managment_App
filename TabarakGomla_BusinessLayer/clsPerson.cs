using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabarakGomla_DataAccessLayer;

namespace TabarakGomla_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + SecondName + " " + LastName; } }

        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string ProfilePic { get; set; }
        public string Phone { get; set; }
        public string Bio { get; set; }



        public clsPerson()
        {
            PersonID = -1;
            FirstName = "";
            SecondName = "";
            LastName = "";
            DateOfBirth = DateTime.MinValue;
            Gender = false;
            ProfilePic = "";
            Phone = "";
            Bio = "";

            mode = enMode.eAddNew;
        }

        private clsPerson(int PersonID, string FirstName, string SecondName, string LastName, DateTime DateOfBirth, bool Gender, string ProfilePic, string Phone, string Bio)
        {

            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.ProfilePic = ProfilePic;
            this.Phone = Phone;
            this.Bio = Bio;

            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.PersonID = clsPeopleDataAccess.AddNewRow(this.FirstName, this.SecondName, this.LastName, this.DateOfBirth, this.Gender, this.ProfilePic, this.Phone, this.Bio);

            return this.PersonID != -1;

        }

        bool _UpdateRow()
        {

            return clsPeopleDataAccess.UpdateRow(this.PersonID, this.FirstName, this.SecondName, this.LastName, this.DateOfBirth, this.Gender, this.ProfilePic, this.Phone, this.Bio);


        }

        public static clsPerson FindByPersonID(int PersonID)
        {

            string FirstName = "";
            string SecondName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            bool Gender = false;
            string ProfilePic = "";
            string Phone = "";
            string Bio = "";


            if (clsPeopleDataAccess.GetRowInfoByPersonID(PersonID, ref FirstName, ref SecondName, ref LastName, ref DateOfBirth, ref Gender, ref ProfilePic, ref Phone, ref Bio))
            {

                return new clsPerson(PersonID, FirstName, SecondName, LastName, DateOfBirth, Gender, ProfilePic, Phone, Bio);
            }
            else
                return null;
        }






        public static DataTable GetAllRows()
        {
            DataTable DT = clsPeopleDataAccess.GetAllRows();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsPeopleDataAccess.GetNumberOfRows();
        }

        public static bool DeleteRow(int PersonID)
        {
            return (clsPeopleDataAccess.DeleteRow(PersonID));
        }

        public static bool DoesRowExist(int PersonID)
        {
            return (clsPeopleDataAccess.DoesRowExist(PersonID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.eAddNew:
                    {
                        if (_AddNewRow())
                        {
                            mode = enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case enMode.eUpdate:

                    return _UpdateRow();

            }

            return false;
        }





    }
}
