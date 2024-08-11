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
using TabarakGomla_PresentationLayer.Classes;
using TabarakGomla_PresentationLayer.Customers_Debt;
using TabarakGomla_PresentationLayer.Properties;

namespace TabarakGomla_PresentationLayer
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            clsGlobalObjects.mainScreen = this;
        }


       void SetClickedButtonOn(BunifuImageButton onButton)
       {
            if (onButton.Name == "btnStats")
                onButton.Image = Resources.statisctics_on;
            else
                btnStats.Image = Resources.statisctics_off;

            if (onButton.Name == "btnCustomersDebt")
                onButton.Image = Resources.borrow_on;
            else
                btnCustomersDebt.Image = Resources.borrow_off;

            if (onButton.Name == "btnPeople")
                onButton.Image = Resources.people_on;
            else
                btnPeople.Image = Resources.people_off;

            if (onButton.Name == "btnSpendings")
                onButton.Image = Resources.money_on;
            else
                btnSpendings.Image = Resources.money_off;

            if (onButton.Name == "btnProducts")
                onButton.Image = Resources.products_on;
            else
                btnProducts.Image = Resources.products_off;

       }


        void ShowInnerForm(BunifuImageButton btn)
        {
            pnlFormsLoader.Controls.Clear();

            switch (btn.Name)
            {

                case "btnCustomersDebt":
                   frmCustomersDebts customersDebts = new frmCustomersDebts();
                   clsGlobal.ShowFormInPanel(pnlFormsLoader, customersDebts);
                    break;
               



            }

        }










        public void ShowFormOnMainPanel(Form frm)
        {
            clsGlobal.ShowFormInPanel(pnlFormsLoader, frm);
        }













        //events functions

        private void MainButtons_Click(object sender, EventArgs e)
        {
            SetClickedButtonOn((BunifuImageButton)sender);
            ShowInnerForm((BunifuImageButton)sender);
        }
    }
}
