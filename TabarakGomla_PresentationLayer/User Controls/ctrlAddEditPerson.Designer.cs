namespace TabarakGomla_PresentationLayer.User_Controls
{
    partial class ctrlAddEditPerson
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.klblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.klblUploadImage = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBio = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dpDateOfBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSecondName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbPersonPic = new System.Windows.Forms.PictureBox();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // klblRemoveImage
            // 
            this.klblRemoveImage.AutoSize = true;
            this.klblRemoveImage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRemoveImage.Location = new System.Drawing.Point(234, 363);
            this.klblRemoveImage.Name = "klblRemoveImage";
            this.klblRemoveImage.Size = new System.Drawing.Size(61, 14);
            this.klblRemoveImage.TabIndex = 24;
            this.klblRemoveImage.TabStop = true;
            this.klblRemoveImage.Text = "ازالة الصورة";
            this.klblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.klblRemoveImage_LinkClicked);
            // 
            // klblUploadImage
            // 
            this.klblUploadImage.AutoSize = true;
            this.klblUploadImage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblUploadImage.Location = new System.Drawing.Point(231, 333);
            this.klblUploadImage.Name = "klblUploadImage";
            this.klblUploadImage.Size = new System.Drawing.Size(66, 14);
            this.klblUploadImage.TabIndex = 23;
            this.klblUploadImage.TabStop = true;
            this.klblUploadImage.Text = "تحميل صورة";
            this.klblUploadImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.klblUploadImage_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "تاريخ الميلاد";
            // 
            // txtBio
            // 
            this.txtBio.AnimateReadOnly = false;
            this.txtBio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBio.Depth = 0;
            this.txtBio.HideSelection = true;
            this.txtBio.Hint = "معلومات";
            this.txtBio.Location = new System.Drawing.Point(23, 577);
            this.txtBio.MaxLength = 32767;
            this.txtBio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBio.Name = "txtBio";
            this.txtBio.PasswordChar = '\0';
            this.txtBio.ReadOnly = false;
            this.txtBio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBio.SelectedText = "";
            this.txtBio.SelectionLength = 0;
            this.txtBio.SelectionStart = 0;
            this.txtBio.ShortcutsEnabled = true;
            this.txtBio.Size = new System.Drawing.Size(506, 81);
            this.txtBio.TabIndex = 19;
            this.txtBio.TabStop = false;
            this.txtBio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBio.UseSystemPasswordChar = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AnimateReadOnly = false;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.Hint = "رقم التيليفون";
            this.txtPhoneNumber.LeadingIcon = null;
            this.txtPhoneNumber.Location = new System.Drawing.Point(23, 521);
            this.txtPhoneNumber.MaxLength = 50;
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(250, 50);
            this.txtPhoneNumber.TabIndex = 18;
            this.txtPhoneNumber.Text = "";
            this.txtPhoneNumber.TrailingIcon = null;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(284, 409);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(245, 50);
            this.gbGender.TabIndex = 17;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "الجنس";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(33, 24);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(46, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.Text = "أنثي";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(177, 19);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(40, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "ذكر";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dpDateOfBirth
            // 
            this.dpDateOfBirth.BackColor = System.Drawing.Color.SeaGreen;
            this.dpDateOfBirth.BorderRadius = 0;
            this.dpDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.dpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDateOfBirth.FormatCustom = null;
            this.dpDateOfBirth.Location = new System.Drawing.Point(23, 423);
            this.dpDateOfBirth.Name = "dpDateOfBirth";
            this.dpDateOfBirth.Size = new System.Drawing.Size(196, 36);
            this.dpDateOfBirth.TabIndex = 16;
            this.dpDateOfBirth.Value = new System.DateTime(2024, 3, 15, 21, 8, 38, 566);
            // 
            // txtLastName
            // 
            this.txtLastName.AnimateReadOnly = false;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.Hint = "الاسم الاخير";
            this.txtLastName.LeadingIcon = null;
            this.txtLastName.Location = new System.Drawing.Point(279, 521);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 50);
            this.txtLastName.TabIndex = 15;
            this.txtLastName.Text = "";
            this.txtLastName.TrailingIcon = null;
            // 
            // txtSecondName
            // 
            this.txtSecondName.AnimateReadOnly = false;
            this.txtSecondName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecondName.Depth = 0;
            this.txtSecondName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSecondName.Hint = "الاسم الثاني";
            this.txtSecondName.LeadingIcon = null;
            this.txtSecondName.Location = new System.Drawing.Point(23, 465);
            this.txtSecondName.MaxLength = 50;
            this.txtSecondName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSecondName.Multiline = false;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(250, 50);
            this.txtSecondName.TabIndex = 14;
            this.txtSecondName.Text = "";
            this.txtSecondName.TrailingIcon = null;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AnimateReadOnly = false;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.Hint = "الاسم الاول";
            this.txtFirstName.LeadingIcon = null;
            this.txtFirstName.Location = new System.Drawing.Point(279, 465);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 50);
            this.txtFirstName.TabIndex = 13;
            this.txtFirstName.Text = "";
            this.txtFirstName.TrailingIcon = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbPersonPic
            // 
            this.pbPersonPic.Image = global::TabarakGomla_PresentationLayer.Properties.Resources.MaleUser1;
            this.pbPersonPic.InitialImage = null;
            this.pbPersonPic.Location = new System.Drawing.Point(121, 31);
            this.pbPersonPic.Name = "pbPersonPic";
            this.pbPersonPic.Size = new System.Drawing.Size(290, 290);
            this.pbPersonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonPic.TabIndex = 20;
            this.pbPersonPic.TabStop = false;
            // 
            // ctrlAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.klblRemoveImage);
            this.Controls.Add(this.klblUploadImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPersonPic);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.dpDateOfBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "ctrlAddEditPerson";
            this.Size = new System.Drawing.Size(551, 662);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel klblRemoveImage;
        private System.Windows.Forms.LinkLabel klblUploadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPersonPic;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtBio;
        private MaterialSkin.Controls.MaterialTextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateOfBirth;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtSecondName;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
