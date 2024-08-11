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
using TabarakGomla_PresentationLayer.Properties;

namespace TabarakGomla_PresentationLayer.User_Controls
{
    public partial class ctrlAddEditPerson : UserControl
    {
        public ctrlAddEditPerson()
        {
            InitializeComponent();
        }


        private clsPerson person = null;

        public enum enMode { eEdit = 1, eAddNew = 2, eDisplayInfo = 3 }

        enMode mode = enMode.eDisplayInfo;

        //private methods
        private void _DisplayPersonData()
        {
            if (person == null)
                return;

            mode = enMode.eDisplayInfo;
            _EnabelControls(false);

            pbPersonPic.ImageLocation = person.ProfilePic;
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtSecondName.Text = person.SecondName;
            txtBio.Text = person.Bio;
            txtPhoneNumber.Text = person.Phone;

            if (person.Gender == true)
                rbMale.Checked = true;
            else
                rbFemale.Checked = false;

            dpDateOfBirth.Value = person.DateOfBirth;

        }

        private int _SavePersonInfo()
        {
            if (this.person == null)
            {
                person = new clsPerson();
                this.mode = enMode.eAddNew;
            }
            else
                this.mode = enMode.eEdit;

            _EnabelControls(true);


            person.FirstName = txtFirstName.Text.Trim();
            person.SecondName = txtSecondName.Text.Trim();
            person.LastName = txtLastName.Text.Trim();
            person.Phone = txtPhoneNumber.Text.Trim();
            person.Bio = txtBio.Text.Trim();
            person.Gender = rbMale.Checked;
            person.DateOfBirth = dpDateOfBirth.Value;
            person.ProfilePic = pbPersonPic.ImageLocation;

            if (person.Save())
                return person.PersonID;
            else
                return -1;         
        }

        private bool _ValidatePersonInfo()
        {
            return clsGlobal.ValidateTxt(txtFirstName, "", "First Name Can't be empty", errorProvider1) &&
                clsGlobal.ValidateTxt(txtLastName, "", "Last Name Can't be empty", errorProvider1);

        }

        private void _EnabelControls(bool Enable = true)
        {
            klblRemoveImage.Enabled = Enable;
            klblUploadImage.Enabled = Enable;

            txtFirstName.ReadOnly = Enable;
            txtSecondName.ReadOnly = Enable;
            txtLastName.ReadOnly = Enable;
            txtPhoneNumber.ReadOnly = Enable;
            txtBio.ReadOnly = Enable;

        }






        //public methods
        public void DisplayPersonInfo(clsPerson person)
        {
            this.person = person;
            this._DisplayPersonData();
        }

        public void DisplayPersonInfo(int personID)
        {
            this.person = clsPerson.FindByPersonID(personID);
            this._DisplayPersonData();
        }

        public int SavePersonInfo()
        {
            if (_ValidatePersonInfo())
                return _SavePersonInfo();

            return -1;
        }






        //events
        private void klblUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonPic.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void klblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonPic.ImageLocation = "";
            openFileDialog1.FileName = "";
        }

       
    }
}
