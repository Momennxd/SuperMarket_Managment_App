using Bunifu.Framework.UI;
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
using TabarakGomla_PresentationLayer.Customers;

namespace TabarakGomla_PresentationLayer.Customers_Debt
{
    public partial class frmCustomersDebts : Form
    {
        public frmCustomersDebts()
        {
            InitializeComponent();
        }

        DataTable dtCustomersDebts = clsCustomerDebt.Get_dgv_CustomersDebts();

        void LoadCustomersDebtsToDG()
        {

            // Filter and round the "Amount" column using LINQ
            var filteredRows = dtCustomersDebts.AsEnumerable()
                .Where(row => row.Field<decimal>("Amount") >= 0)
                .Select(row =>
                {
                    decimal roundedAmount = Math.Round(row.Field<decimal>("Amount"), 2);
                    row.SetField("Amount", roundedAmount);
                    return row;
                }).CopyToDataTable();


            //loading the datatable to the data grid view
            dgCustomersDebts.DataSource = filteredRows;

            //setting the header texts
            dgCustomersDebts.Columns["PersonID"].HeaderText = "ID";
            dgCustomersDebts.Columns["PersonID"].Width = 50;
            dgCustomersDebts.Columns["Name"].HeaderText = "الاسم الكامل";
            dgCustomersDebts.Columns["WorkPlaceAddress"].HeaderText = "مكان العمل";
            dgCustomersDebts.Columns["Amount"].HeaderText = "المبلغ";


        }

        private clsCustomer _SelectedCustomer = null;

       
      
        private void RefreshCustomersDebts()
        {
            dtCustomersDebts = clsCustomerDebt.Get_dgv_CustomersDebts();
            LoadCustomersDebtsToDG();
        }














        private void frmCustomersDebts_Load(object sender, EventArgs e)
        {
            LoadCustomersDebtsToDG();
        }

        private void txtSearchBar_OnTextChange(object sender, EventArgs e)
        {
            clsGlobal.ApplyFilter(txtSearchBar.text.Trim(), "Name", dtCustomersDebts, dgCustomersDebts);
        }

        private void btnClearSeach_Click(object sender, EventArgs e)
        {
            txtSearchBar.text = "";
            dgCustomersDebts.DataSource = dtCustomersDebts;
        }

        private void dgCustomersDebts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dgCustomersDebts.ClearSelection();
                dgCustomersDebts.Rows[e.RowIndex].Selected = true;
                dgCustomersDebts.CurrentCell = dgCustomersDebts.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _SelectedCustomer = clsCustomer.FindByCustomerID(
                        Convert.ToInt16(dgCustomersDebts.Rows[e.RowIndex].Cells["PersonID"].Value));
                cmsDebtOperations.Show(MousePosition);
            }
        }

      

        private void itemAddAmount_Click(object sender, EventArgs e)
        {
            frmEditDebtAmount frmEditDebtAmount = 
                new frmEditDebtAmount(frmEditDebtAmount.enMode.eIncrease, this._SelectedCustomer);
            frmEditDebtAmount.OnEditAmount += FrmEditDebtAmount_OnEditAmount;

            frmEditDebtAmount.ShowDialog();
        }

        private void FrmEditDebtAmount_OnEditAmount(object obj)
        {
            RefreshCustomersDebts();
        }

        private void itemDecreaseAmount_Click(object sender, EventArgs e)
        {
            frmEditDebtAmount frmEditDebtAmount =
              new frmEditDebtAmount(frmEditDebtAmount.enMode.eDecrease, this._SelectedCustomer);
            frmEditDebtAmount.OnEditAmount += FrmEditDebtAmount_OnEditAmount;

            frmEditDebtAmount.ShowDialog();
        }

        private void btnTransHistory_Click(object sender, EventArgs e)
        {
            frmDebtTransactions frm = new frmDebtTransactions();
            clsGlobalObjects.mainScreen.ShowFormOnMainPanel(frm);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer _frmAddEditCustomer = new frmAddEditCustomer();
            _frmAddEditCustomer.OnSaveClick += () => _frmAddEditCustomer.Close();
            _frmAddEditCustomer.ShowDialog();
        }
    }
}
