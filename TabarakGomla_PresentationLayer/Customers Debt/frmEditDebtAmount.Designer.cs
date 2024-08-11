namespace TabarakGomla_PresentationLayer.Customers_Debt
{
    partial class frmEditDebtAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditDebtAmount));
            this.txtHeaderText = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtAddedAmount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblDebtAmount = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbCustomerPic = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHeaderText
            // 
            this.txtHeaderText.AutoSize = true;
            this.txtHeaderText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeaderText.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtHeaderText.Location = new System.Drawing.Point(387, 27);
            this.txtHeaderText.Name = "txtHeaderText";
            this.txtHeaderText.Size = new System.Drawing.Size(123, 23);
            this.txtHeaderText.TabIndex = 0;
            this.txtHeaderText.Text = "أضافة مبلغ+";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.Location = new System.Drawing.Point(112, 32);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(146, 18);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Ahmed mohammed";
            // 
            // txtAddedAmount
            // 
            this.txtAddedAmount.AllowPromptAsInput = true;
            this.txtAddedAmount.AnimateReadOnly = false;
            this.txtAddedAmount.AsciiOnly = false;
            this.txtAddedAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddedAmount.BeepOnError = false;
            this.txtAddedAmount.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddedAmount.Depth = 0;
            this.txtAddedAmount.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddedAmount.HidePromptOnLeave = false;
            this.txtAddedAmount.HideSelection = true;
            this.txtAddedAmount.Hint = "أضافة مبلغ";
            this.txtAddedAmount.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtAddedAmount.LeadingIcon = null;
            this.txtAddedAmount.Location = new System.Drawing.Point(181, 166);
            this.txtAddedAmount.Mask = "";
            this.txtAddedAmount.MaxLength = 32767;
            this.txtAddedAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddedAmount.Name = "txtAddedAmount";
            this.txtAddedAmount.PasswordChar = '\0';
            this.txtAddedAmount.PrefixSuffixText = null;
            this.txtAddedAmount.PromptChar = '_';
            this.txtAddedAmount.ReadOnly = false;
            this.txtAddedAmount.RejectInputOnFirstFailure = false;
            this.txtAddedAmount.ResetOnPrompt = true;
            this.txtAddedAmount.ResetOnSpace = true;
            this.txtAddedAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddedAmount.SelectedText = "";
            this.txtAddedAmount.SelectionLength = 0;
            this.txtAddedAmount.SelectionStart = 0;
            this.txtAddedAmount.ShortcutsEnabled = true;
            this.txtAddedAmount.Size = new System.Drawing.Size(184, 48);
            this.txtAddedAmount.SkipLiterals = true;
            this.txtAddedAmount.TabIndex = 3;
            this.txtAddedAmount.TabStop = false;
            this.txtAddedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddedAmount.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddedAmount.TrailingIcon = null;
            this.txtAddedAmount.UseSystemPasswordChar = false;
            this.txtAddedAmount.ValidatingType = null;
            // 
            // lblDebtAmount
            // 
            this.lblDebtAmount.AutoSize = true;
            this.lblDebtAmount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebtAmount.ForeColor = System.Drawing.Color.Black;
            this.lblDebtAmount.Location = new System.Drawing.Point(204, 105);
            this.lblDebtAmount.Name = "lblDebtAmount";
            this.lblDebtAmount.Size = new System.Drawing.Size(123, 18);
            this.lblDebtAmount.TabIndex = 4;
            this.lblDebtAmount.Tag = "المبلغ الحالي ";
            this.lblDebtAmount.Text = "المبلغ الحالي 50";
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
            this.btnCancel.Location = new System.Drawing.Point(115, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(103, 48);
            this.btnCancel.TabIndex = 6;
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
            this.btnConfirm.Location = new System.Drawing.Point(327, 274);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConfirm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnConfirm.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfirm.selected = false;
            this.btnConfirm.Size = new System.Drawing.Size(103, 48);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "تم";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Textcolor = System.Drawing.Color.White;
            this.btnConfirm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pbCustomerPic
            // 
            this.pbCustomerPic.Image = global::TabarakGomla_PresentationLayer.Properties.Resources.icons8_account_48__1_2;
            this.pbCustomerPic.Location = new System.Drawing.Point(12, 8);
            this.pbCustomerPic.Name = "pbCustomerPic";
            this.pbCustomerPic.Size = new System.Drawing.Size(73, 60);
            this.pbCustomerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomerPic.TabIndex = 1;
            this.pbCustomerPic.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditDebtAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 337);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblDebtAmount);
            this.Controls.Add(this.txtAddedAmount);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.pbCustomerPic);
            this.Controls.Add(this.txtHeaderText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditDebtAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEditDebtAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHeaderText;
        private System.Windows.Forms.PictureBox pbCustomerPic;
        private System.Windows.Forms.Label lblCustomerName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAddedAmount;
        private System.Windows.Forms.Label lblDebtAmount;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirm;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}