using DVLD_PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabarakGomla_BusinessLayer;
using TabarakGomla_PresentationLayer.Classes;

namespace TabarakGomla_PresentationLayer.Customers_Debt
{
    public partial class frmEditDebtAmount : Form
    {
        public frmEditDebtAmount(enMode mode, clsCustomer customer)
        {
            InitializeComponent();
            this._mode = mode;


            if (customer != null)
            {
                this._customer = customer;
                this._person = clsPerson.FindByPersonID(customer.PersonID);
                this._Debt = clsCustomerDebt.FindByCustomerID(customer.CustomerID);
            }
            
        }



        public enum enMode { eIncrease =  0, eDecrease = 1}

        private enMode _mode = enMode.eIncrease;


        private clsCustomer _customer = null;
        private clsPerson _person = null;
        private clsCustomerDebt _Debt = null;
        private decimal OldAmount = 0;

        public event Action<object> OnEditAmount;
        protected virtual void ConfirmEditAmountClick_Click()
        {
            Action<object> handler = OnEditAmount;
            if (handler != null)
            {
                handler(this); // Raise the event with the parameter
            }
        }


        void PrepareFormToLoad(enMode mode)
        {
            switch (mode)
            {
                case enMode.eIncrease:
                {
                        txtHeaderText.Text = "اضافة مبلغ+";
                        txtHeaderText.ForeColor = Color.DarkGreen;
                        txtAddedAmount.Hint = "اضافة مبلغ";
                        break;
                }
                case enMode.eDecrease:
                {
                        txtHeaderText.Text = "دفع مبلغ-";
                        txtHeaderText.ForeColor = Color.DarkRed;
                        txtAddedAmount.Hint = "دفع مبلغ";
                        break;
                }
            }
        }

        void DisplayCustomerData()
        {
            if (_customer != null)
            {
                pbCustomerPic.ImageLocation = _person.ProfilePic;
                lblDebtAmount.Text = lblDebtAmount.Tag + " " + _Debt.Amount.ToString();
                lblCustomerName.Text = _person.FullName;
            }
            
        }


        bool ValidateAmount()
        {
            bool IsValid = 
                clsGlobal.ValidateIfTxtBoxIsNotNumber(txtAddedAmount, "Invalid Amount", errorProvider1);



            if (_mode == enMode.eDecrease && IsValid)
            {
                if (this._Debt.Amount <= 0)
                {
                    IsValid = false;
                    errorProvider1.SetError(txtAddedAmount, "There is no debt to free");
                }

                if (this._Debt.Amount - Convert.ToDecimal(txtAddedAmount.Text) < 0)
                {
                    IsValid = false;
                    errorProvider1.SetError(txtAddedAmount, "Max amount to decrease is " + this._Debt.Amount);

                }

            }

            return IsValid;

        }


        bool CompleteTransaction()
        {

            OldAmount = this._Debt.Amount;

            if (_mode == enMode.eDecrease)
                _Debt.Amount -= Convert.ToDecimal(txtAddedAmount.Text.Trim());
            else
                _Debt.Amount += Convert.ToDecimal(txtAddedAmount.Text.Trim());

            return _Debt.Save();
        }


        bool SaveTransInHistory()
        {
            clsCustomerDebtTransaction customerDebtTransaction = new clsCustomerDebtTransaction()
            {
                CustomerID = this._customer.CustomerID,
                DebtID = this._Debt.DebtID,
                //getting the new debt value from the data base
                DebtNewValue = clsCustomerDebt.FindByDebtID(this._Debt.DebtID).Amount,
                TransactionDate = DateTime.Now,
                CurrentUserID = clsGlobalObjects.currentUser.UserID,
                DebtOldValue = OldAmount
            };

            return customerDebtTransaction.Save();

        }






        private void frmEditDebtAmount_Load(object sender, EventArgs e)
        {
            PrepareFormToLoad(_mode);
            DisplayCustomerData();
        }




        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateAmount())
            {
                if (MessageBox.Show("هل انت متأكد", "", MessageBoxButtons.OKCancel) 
                    == DialogResult.OK)
                {
                    if (CompleteTransaction())
                    {
                        SaveTransInHistory();
                        MessageBox.Show("تمت العمليه بنجاح", "نجحت");
                        OnEditAmount?.Invoke(this);
                        this.Close();
                    }
                    else
                        MessageBox.Show("فشلت العمليه", "فشلة");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
