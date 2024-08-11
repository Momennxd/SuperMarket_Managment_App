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
    public class clsEmployee
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int EmployeeID { get; set; }
        public int PersonID { get; set; }
        public decimal Wage { get; set; }
        public string Rank { get; set; }



        public clsEmployee()
        {
            EmployeeID = -1;
            PersonID = -1;
            Wage = -1;
            Rank = "";

            mode = enMode.eAddNew;
        }

        private clsEmployee(int EmployeeID, int PersonID, decimal Wage, string Rank)
        {

            this.EmployeeID = EmployeeID;
            this.PersonID = PersonID;
            this.Wage = Wage;
            this.Rank = Rank;

            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.EmployeeID = clsEmployeesDataAccess.AddNewRow(this.PersonID, this.Wage, this.Rank);

            return this.EmployeeID != -1;

        }

        bool _UpdateRow()
        {

            return clsEmployeesDataAccess.UpdateRow(this.EmployeeID, this.PersonID, this.Wage, this.Rank);


        }

        public static clsEmployee FindByEmployeeID(int EmployeeID)
        {

            int PersonID = -1;
            decimal Wage = -1;
            string Rank = "";


            if (clsEmployeesDataAccess.GetRowInfoByEmployeeID(EmployeeID, ref PersonID, ref Wage, ref Rank))
            {

                return new clsEmployee(EmployeeID, PersonID, Wage, Rank);
            }
            else
                return null;
        }





        public static clsEmployee FindByPersonID(int PersonID)
        {

            int EmployeeID = -1;
            decimal Wage = -1;
            string Rank = "";


            if (clsEmployeesDataAccess.GetRowInfoByPersonID(ref EmployeeID, PersonID, ref Wage, ref Rank))
            {

                return new clsEmployee(EmployeeID, PersonID, Wage, Rank);
            }
            else
                return null;
        }






        public static DataTable GetAllRows()
        {
            DataTable DT = clsEmployeesDataAccess.GetAllRows();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsEmployeesDataAccess.GetNumberOfRows();
        }

        public static bool DeleteRow(int EmployeeID)
        {
            return (clsEmployeesDataAccess.DeleteRow(EmployeeID));
        }

        public static bool DoesRowExist(int EmployeeID)
        {
            return (clsEmployeesDataAccess.DoesRowExist(EmployeeID));
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
