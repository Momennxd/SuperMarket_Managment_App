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

namespace TabarakGomla_PresentationLayer.Customers
{
    public partial class frmAddEditCustomer : Form
    {
        public frmAddEditCustomer(clsCustomer customer, bool IsEdit)
        {
            InitializeComponent();

            if (customer != null)
            {
                this.customer = customer;
                if (IsEdit)
                {
                    this.mode = enMode.eEdit;
                    this.EnableControls(true);
                } 
                else
                {
                    this.mode = enMode.eDisplayInfo;
                    this.EnableControls(false);
                }
                this.DisplayCustomerInfo(customer);
            }
            
        }

        public frmAddEditCustomer()
        {
            InitializeComponent();
            this.mode = enMode.eAddNew;
            EnableControls(true);
        }


        public event Action OnSaveClick;
        protected virtual void SaveClick_Click()
        {
            Action handler = OnSaveClick;
            if (handler != null)
            {
                handler(); // Raise the event with the parameter
            }
        }

        public enum enMode { eEdit = 1, eAddNew = 2, eDisplayInfo = 3 }

        enMode mode = enMode.eEdit;

        private clsCustomer customer = null;





        //private methods
        private void EnableControls(bool enable = true)
        {
            txtWorkPlace.Enabled = enable;
            btnCancel.Enabled = enable;
            btnConfirm.Enabled = enable;
        }

        private void _DisplayCustomerInfo()
        {
            if (customer == null)
                return;

            mode = enMode.eDisplayInfo;

            ctrlAddEditPerson1.DisplayPersonInfo(this.customer.PersonID);
            txtWorkPlace.Text = this.customer.WorkPlaceAddress;
        }

        private bool ValidateCustomerInfo()
        {
            return clsGlobal.ValidateTxt(txtWorkPlace, "", "Work place Can't be empty", errorProvider1);
        }

        private bool AddNewCustomer()
        {
            if (ValidateCustomerInfo())
            {
                customer = new clsCustomer();
                customer.WorkPlaceAddress = txtWorkPlace.Text.Trim();
                customer.PersonID = ctrlAddEditPerson1.SavePersonInfo();

                if (customer.PersonID != -1)
                    return customer.Save();
                else
                {
                    customer = null;
                }

            }

            return false;
        }

        private bool UpdateCustomer()
        {
            if (ValidateCustomerInfo())
            {
                customer.WorkPlaceAddress = txtWorkPlace.Text.Trim();
                ctrlAddEditPerson1.SavePersonInfo();
                return customer.Save();
              
            }

            return false;
        }

        private bool SaveCustomerInfo()
        {
            switch(mode)
            {
                case enMode.eAddNew:
                    return AddNewCustomer();

                case enMode.eEdit:
                    return UpdateCustomer();

                default:
                    return false;

            }
        }











        //public methods
        public void DisplayCustomerInfo(clsCustomer customer)
        {
            this.customer = customer;
            this._DisplayCustomerInfo();
        }

        public void DisplayCustomerInfo(int customerID)
        {
            this.customer = clsCustomer.FindByCustomerID(customerID);
            this._DisplayCustomerInfo();
        }






        //events
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (SaveCustomerInfo())
            {
                MessageBox.Show("تم الحفظ بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnSaveClick?.Invoke();
            }
            
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            if (mode == enMode.eEdit || mode == enMode.eDisplayInfo)
                ctrlAddEditPerson1.DisplayPersonInfo(customer.PersonID);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
