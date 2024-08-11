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
    public class clsUsers
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public int Permissions { get; set; }
        public bool IsActive { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }



        public clsUsers()
        {
            UserID = -1;
            EmployeeID = -1;
            Permissions = -1;
            IsActive = false;
            UserName = "";
            Password = "";

            mode = enMode.eAddNew;
        }

        private clsUsers(int UserID, int EmployeeID, int Permissions, bool IsActive, string UserName, string Password)
        {

            this.UserID = UserID;
            this.EmployeeID = EmployeeID;
            this.Permissions = Permissions;
            this.IsActive = IsActive;
            this.UserName = UserName;
            this.Password = Password;

            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.UserID = clsUsersDataAccess.AddNewRow(this.EmployeeID, this.Permissions, this.IsActive, this.UserName, this.Password);

            return this.UserID != -1;

        }

        bool _UpdateRow()
        {

            return clsUsersDataAccess.UpdateRow(this.UserID, this.EmployeeID, this.Permissions, this.IsActive, this.UserName, this.Password);


        }

        public static clsUsers FindByUserID(int UserID)
        {

            int EmployeeID = -1;
            int Permissions = -1;
            bool IsActive = false;
            string UserName = "";
            string Password = "";


            if (clsUsersDataAccess.GetRowInfoByUserID(UserID, ref EmployeeID, ref Permissions, ref IsActive, ref UserName, ref Password))
            {

                return new clsUsers(UserID, EmployeeID, Permissions, IsActive, UserName, Password);
            }
            else
                return null;
        }





        public static clsUsers FindByEmployeeID(int EmployeeID)
        {

            int UserID = -1;
            int Permissions = -1;
            bool IsActive = false;
            string UserName = "";
            string Password = "";


            if (clsUsersDataAccess.GetRowInfoByEmployeeID(ref UserID, EmployeeID, ref Permissions, ref IsActive, ref UserName, ref Password))
            {

                return new clsUsers(UserID, EmployeeID, Permissions, IsActive, UserName, Password);
            }
            else
                return null;
        }






        public static DataTable GetAllRows()
        {
            DataTable DT = clsUsersDataAccess.GetAllRows();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsUsersDataAccess.GetNumberOfRows();
        }

        public static bool DeleteRow(int UserID)
        {
            return (clsUsersDataAccess.DeleteRow(UserID));
        }

        public static bool DoesRowExist(int UserID)
        {
            return (clsUsersDataAccess.DoesRowExist(UserID));
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
