namespace TabarakGomla_PresentationLayer.Customers
{
    partial class frmAddEditCustomer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditCustomer));
            this.txtWorkPlace = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlAddEditPerson1 = new TabarakGomla_PresentationLayer.User_Controls.ctrlAddEditPerson();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWorkPlace
            // 
            this.txtWorkPlace.AnimateReadOnly = false;
            this.txtWorkPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtWorkPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtWorkPlace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWorkPlace.Depth = 0;
            this.txtWorkPlace.HideSelection = true;
            this.txtWorkPlace.Hint = "محل العمل";
            this.txtWorkPlace.Location = new System.Drawing.Point(47, 679);
            this.txtWorkPlace.MaxLength = 32767;
            this.txtWorkPlace.MouseState = MaterialSkin.MouseState.OUT;
            this.txtWorkPlace.Name = "txtWorkPlace";
            this.txtWorkPlace.PasswordChar = '\0';
            this.txtWorkPlace.ReadOnly = false;
            this.txtWorkPlace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWorkPlace.SelectedText = "";
            this.txtWorkPlace.SelectionLength = 0;
            this.txtWorkPlace.SelectionStart = 0;
            this.txtWorkPlace.ShortcutsEnabled = true;
            this.txtWorkPlace.Size = new System.Drawing.Size(506, 66);
            this.txtWorkPlace.TabIndex = 20;
            this.txtWorkPlace.TabStop = false;
            this.txtWorkPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWorkPlace.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Maroon;
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "الغاء";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = global::TabarakGomla_PresentationLayer.Properties.Resources.icons8_multiply_48___Copy1;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 60D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(141, 767);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(103, 48);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.BorderRadius = 0;
            this.btnConfirm.ButtonText = "تم";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DisabledColor = System.Drawing.Color.Gray;
            this.btnConfirm.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfirm.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Iconimage")));
            this.btnConfirm.Iconimage_right = null;
            this.btnConfirm.Iconimage_right_Selected = null;
            this.btnConfirm.Iconimage_Selected = null;
            this.btnConfirm.IconMarginLeft = 0;
            this.btnConfirm.IconMarginRight = 0;
            this.btnConfirm.IconRightVisible = true;
            this.btnConfirm.IconRightZoom = 0D;
            this.btnConfirm.IconVisible = true;
            this.btnConfirm.IconZoom = 90D;
            this.btnConfirm.IsTab = false;
            this.btnConfirm.Location = new System.Drawing.Point(353, 767);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConfirm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnConfirm.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfirm.selected = false;
            this.btnConfirm.Size = new System.Drawing.Size(103, 48);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "تم";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Textcolor = System.Drawing.Color.White;
            this.btnConfirm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAddEditPerson1
            // 
            this.ctrlAddEditPerson1.Location = new System.Drawing.Point(25, 11);
            this.ctrlAddEditPerson1.Name = "ctrlAddEditPerson1";
            this.ctrlAddEditPerson1.Size = new System.Drawing.Size(566, 662);
            this.ctrlAddEditPerson1.TabIndex = 0;
            // 
            // frmAddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(613, 827);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtWorkPlace);
            this.Controls.Add(this.ctrlAddEditPerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.frmAddEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.ctrlAddEditPerson ctrlAddEditPerson1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtWorkPlace;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}