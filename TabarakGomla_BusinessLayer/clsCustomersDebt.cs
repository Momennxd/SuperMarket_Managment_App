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
    public class clsCustomerDebt
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int DebtID { get; set; }
        public int CustomerID { get; set; }
        public decimal Amount { get; set; }



        public clsCustomerDebt()
        {
            DebtID = -1;
            CustomerID = -1;
            Amount = -1;

            mode = enMode.eAddNew;
        }

        private clsCustomerDebt(int DebtID, int CustomerID, decimal Amount)
        {

            this.DebtID = DebtID;
            this.CustomerID = CustomerID;
            this.Amount = Amount;

            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.DebtID = clsCustomersDebtsDataAccess.AddNewRow(this.CustomerID, this.Amount);

            return this.DebtID != -1;

        }

        bool _UpdateRow()
        {

            return clsCustomersDebtsDataAccess.UpdateRow(this.DebtID, this.CustomerID, this.Amount);


        }

        public static clsCustomerDebt FindByDebtID(int DebtID)
        {

            int CustomerID = -1;
            decimal Amount = -1;


            if (clsCustomersDebtsDataAccess.GetRowInfoByDebtID(DebtID, ref CustomerID, ref Amount))
            {

                return new clsCustomerDebt(DebtID, CustomerID, Amount);
            }
            else
                return null;
        }





        public static clsCustomerDebt FindByCustomerID(int CustomerID)
        {

            int DebtID = -1;
            decimal Amount = -1;


            if (clsCustomersDebtsDataAccess.GetRowInfoByCustomerID(ref DebtID, CustomerID, ref Amount))
            {

                return new clsCustomerDebt(DebtID, CustomerID, Amount);
            }
            else
                return null;
        }






        public static DataTable GetAllRows()
        {
            DataTable DT = clsCustomersDebtsDataAccess.GetAllRows();
            return DT;
        }

        public static DataTable GetAllRowsByCustomerID(int CustomerID)
        {
            DataTable DT = clsCustomersDebtsDataAccess.GetAllRowsByCustomerID(CustomerID);
            return DT;
        }

        public static DataTable Get_dgv_CustomersDebts()
        {
            DataTable DT = clsCustomersDebtsDataAccess.Get_dgv_CustomersDebts();
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsCustomersDebtsDataAccess.GetNumberOfRows();
        }

        public static bool DeleteRow(int DebtID)
        {
            return (clsCustomersDebtsDataAccess.DeleteRow(DebtID));
        }

        public static bool DoesRowExist(int DebtID)
        {
            return (clsCustomersDebtsDataAccess.DoesRowExist(DebtID));
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
