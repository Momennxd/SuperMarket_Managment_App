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
    public class clsCustomer
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int CustomerID { get; set; }
        public int PersonID { get; set; }
        public string WorkPlaceAddress { get; set; }



        public clsCustomer()
        {
            CustomerID = -1;
            PersonID = -1;
            WorkPlaceAddress = "";

            mode = enMode.eAddNew;
        }

        private clsCustomer(int CustomerID, int PersonID, string WorkPlaceAddress)
        {

            this.CustomerID = CustomerID;
            this.PersonID = PersonID;
            this.WorkPlaceAddress = WorkPlaceAddress;

            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.CustomerID = clsCustomersDataAccess.AddNewRow(this.PersonID, this.WorkPlaceAddress);

            return this.CustomerID != -1;

        }

        bool _UpdateRow()
        {

            return clsCustomersDataAccess.UpdateRow(this.CustomerID, this.PersonID, this.WorkPlaceAddress);


        }

        public static clsCustomer FindByCustomerID(int CustomerID)
        {

            int PersonID = -1;
            string WorkPlaceAddress = "";


            if (clsCustomersDataAccess.GetRowInfoByCustomerID(CustomerID, ref PersonID, ref WorkPlaceAddress))
            {

                return new clsCustomer(CustomerID, PersonID, WorkPlaceAddress);
            }
            else
                return null;
        }





        public static clsCustomer FindByPersonID(int PersonID)
        {

            int CustomerID = -1;
            string WorkPlaceAddress = "";


            if (clsCustomersDataAccess.GetRowInfoByPersonID(ref CustomerID, PersonID, ref WorkPlaceAddress))
            {

                return new clsCustomer(CustomerID, PersonID, WorkPlaceAddress);
            }
            else
                return null;
        }






        public static DataTable GetAllRows()
        {
            DataTable DT = clsCustomersDataAccess.GetAllRows();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsCustomersDataAccess.GetNumberOfRows();
        }

        public static bool DeleteRow(int CustomerID)
        {
            return (clsCustomersDataAccess.DeleteRow(CustomerID));
        }

        public static bool DoesRowExist(int CustomerID)
        {
            return (clsCustomersDataAccess.DoesRowExist(CustomerID));
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
