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
    public class clsCustomerDebtTransaction
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;


        public int DebtTransactionID { get; set; }
        public int CustomerID { get; set; }
        public int DebtID { get; set; }
        public decimal DebtNewValue { get; set; }
        public decimal DebtOldValue { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CurrentUserID { get; set; }



        public clsCustomerDebtTransaction()
        {
            DebtTransactionID = -1;
            CustomerID = -1;
            DebtID = -1;
            DebtNewValue = -1;
            DebtOldValue = -1;
            TransactionDate = DateTime.MinValue;
            CurrentUserID = -1;

            mode = enMode.eAddNew;
        }

        private clsCustomerDebtTransaction(int DebtTransactionID, int CustomerID, int DebtID, decimal DebtOldValue, 
            decimal DebtNewValue, DateTime TransactionDate, int CurrentUserID)
        {

            this.DebtTransactionID = DebtTransactionID;
            this.CustomerID = CustomerID;
            this.DebtID = DebtID;
            this.DebtNewValue = DebtNewValue;
            this.TransactionDate = TransactionDate;
            this.CurrentUserID = CurrentUserID;
            this.DebtOldValue = DebtOldValue;
            mode = enMode.eUpdate;

        }



        bool _AddNewRow()
        {

            this.DebtTransactionID = clsCustomersDebtTransactionsDataAccess.AddNewRow(
                this.CustomerID, this.DebtID, this.DebtOldValue, this.DebtNewValue, this.TransactionDate, this.CurrentUserID);

            return this.DebtTransactionID != -1;

        }

        bool _UpdateRow()
        {

            return clsCustomersDebtTransactionsDataAccess.UpdateRow(
                this.DebtTransactionID, this.CustomerID, this.DebtID, this.DebtOldValue, this.DebtNewValue, this.TransactionDate, this.CurrentUserID);


        }

        public static clsCustomerDebtTransaction FindByDebtTransactionID(int DebtTransactionID)
        {

            int CustomerID = -1;
            int DebtID = -1;
            decimal DebtNewValue = -1, DebtOldValue = -1;
            DateTime TransactionDate = DateTime.MinValue;
            int CurrentUserID = -1;


            if (clsCustomersDebtTransactionsDataAccess.GetRowInfoByDebtTransactionID
                (DebtTransactionID, ref CustomerID, ref DebtID,ref DebtOldValue, ref DebtNewValue,
                ref TransactionDate, ref CurrentUserID))
            {

                return new clsCustomerDebtTransaction(DebtTransactionID, CustomerID, DebtID, DebtOldValue, DebtNewValue, TransactionDate, CurrentUserID);
            }
            else
                return null;
        }






        public static DataTable GetAllRows()
        {
            DataTable DT = clsCustomersDebtTransactionsDataAccess.GetAllRows();
            return DT;
        }

        public static DataTable Get_dgv_CustomersDebtsTransactions(DateTime date)
        {
            DataTable DT = clsCustomersDebtTransactionsDataAccess.SP_GetCustomersDebtsTransactionsByDate(date);
            return DT;
        }

        public static int GetNumberOfRows()
        {
            return clsCustomersDebtTransactionsDataAccess.GetNumberOfRows();
        }

        public static bool DeleteRow(int DebtTransactionID)
        {
            return (clsCustomersDebtTransactionsDataAccess.DeleteRow(DebtTransactionID));
        }

        public static bool DoesRowExist(int DebtTransactionID)
        {
            return (clsCustomersDebtTransactionsDataAccess.DoesRowExist(DebtTransactionID));
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
