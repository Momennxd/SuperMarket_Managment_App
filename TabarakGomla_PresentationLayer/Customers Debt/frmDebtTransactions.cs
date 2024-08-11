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
using TabarakGomla_PresentationLayer.Properties;

namespace TabarakGomla_PresentationLayer.Customers_Debt
{
    public partial class frmDebtTransactions : Form
    {
        public frmDebtTransactions()
        {
            InitializeComponent();
        }


        DateTime CurrentDebtTransList = DateTime.Now.Date;

        DataTable dtDebtTransactions = clsCustomerDebtTransaction.Get_dgv_CustomersDebtsTransactions(DateTime.Now.Date);




        void LoadCustomersDebtsToDG()
        {
          

            dtDebtTransactions.Columns.Add("UP", typeof(Image));
            dtDebtTransactions.Columns["AddedValue"].ReadOnly = false;

            var filteredRows = dtDebtTransactions;
            // Filter and round the "Amount" column using LINQ
            if (dtDebtTransactions.Rows.Count > 0)
            {
                filteredRows = dtDebtTransactions.AsEnumerable()
                .Select(row =>
                {

                    row.SetField("DebtOldValue", Math.Round(row.Field<decimal>("DebtOldValue"), 2));
                    row.SetField("DebtNewValue", Math.Round(row.Field<decimal>("DebtNewValue"), 2));
                    row.SetField("AddedValue", Math.Round(row.Field<decimal>("AddedValue"), 2));

                    if (Convert.ToInt16(row["AddedValue"]) > 0)
                    {
                        row.SetField("UP", Resources.up_arrow);
                    }
                    else
                    {
                        row.SetField("UP", Resources.down_arrow);

                    }

                    return row;
                }).CopyToDataTable();

            }


            //loading the datatable to the data grid view
            dgDebtTransactions.DataSource = filteredRows;

            //setting the header texts

            dgDebtTransactions.Columns["FullName"].HeaderText = "الاسم الكامل";
            dgDebtTransactions.Columns["DebtOldValue"].HeaderText = "المبلغ القديم";
            dgDebtTransactions.Columns["DebtNewValue"].HeaderText = "المبلغ الجديد";
            dgDebtTransactions.Columns["AddedValue"].HeaderText = "الفرق";
            dgDebtTransactions.Columns["TransactionDate"].HeaderText = "تاريخ العملية";
            dgDebtTransactions.Columns["UP"].HeaderText = "";


        }

        void RefreshDebtsList(DateTime date)
        {
             dtDebtTransactions =
                clsCustomerDebtTransaction.Get_dgv_CustomersDebtsTransactions(date.Date);
            
            LoadCustomersDebtsToDG();
        }

        void RefreshDatePicker()
        {
            dpCurrentDate.Value = CurrentDebtTransList.Date;
        }


















        private void frmDebtTransactions_Load(object sender, EventArgs e)
        {
            lblDebtTransListDate.Text = CurrentDebtTransList.ToString("dd/MM/yyyy");
            btnGoTodayDate.Visible = false;
            LoadCustomersDebtsToDG();
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {

            if (DateTime.Now.Date.CompareTo(CurrentDebtTransList) > 0)
            {
                CurrentDebtTransList = CurrentDebtTransList.AddDays(1);
                lblDebtTransListDate.Text = CurrentDebtTransList.ToString("dd/MM/yyyy");

                if (DateTime.Now.Date.CompareTo(CurrentDebtTransList) == 0)
                {
                    btnGoTodayDate.Visible = false;
                    lblDebtTransListDate.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblDebtTransListDate.ForeColor = Color.Black;
                    btnGoTodayDate.Visible = true;

                }

                //
                RefreshDebtsList(CurrentDebtTransList.Date);
                RefreshDatePicker();
            }

        }

        private void btnPrevDay_Click(object sender, EventArgs e)
        {

            CurrentDebtTransList = CurrentDebtTransList.AddDays(-1);
            lblDebtTransListDate.Text = CurrentDebtTransList.ToString("dd/MM/yyyy");

            if (DateTime.Now.Date.CompareTo(CurrentDebtTransList) == 0)
                lblDebtTransListDate.ForeColor = Color.DarkGreen;
            else
                lblDebtTransListDate.ForeColor = Color.Black;

            btnGoTodayDate.Visible = true;

            //
            RefreshDebtsList(CurrentDebtTransList.Date);
            RefreshDatePicker();
        }

        private void btnGoTodayDate_Click(object sender, EventArgs e)
        {
            CurrentDebtTransList = DateTime.Now.Date;
            lblDebtTransListDate.Text = CurrentDebtTransList.ToString("dd/MM/yyyy");
            RefreshDebtsList(CurrentDebtTransList.Date);
            btnGoTodayDate.Visible = false;
            lblDebtTransListDate.ForeColor = Color.DarkGreen;
            RefreshDatePicker();

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            CurrentDebtTransList = dpCurrentDate.Value.Date;
            lblDebtTransListDate.Text = CurrentDebtTransList.ToString("dd/MM/yyyy");
            RefreshDebtsList(CurrentDebtTransList.Date);

            if (DateTime.Now.Date.CompareTo(CurrentDebtTransList) == 0)
            {
                btnGoTodayDate.Visible = false;
                lblDebtTransListDate.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblDebtTransListDate.ForeColor = Color.Black;
                btnGoTodayDate.Visible = true;

            }

        }
    }
}
