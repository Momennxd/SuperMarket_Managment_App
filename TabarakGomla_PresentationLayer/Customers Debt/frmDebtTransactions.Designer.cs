namespace TabarakGomla_PresentationLayer.Customers_Debt
{
    partial class frmDebtTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgDebtTransactions = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblDebtTransListDate = new System.Windows.Forms.Label();
            this.btnPrevDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNextDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGoTodayDate = new MaterialSkin.Controls.MaterialButton();
            this.dpCurrentDate = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebtTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDebtTransactions
            // 
            this.dgDebtTransactions.AllowUserToAddRows = false;
            this.dgDebtTransactions.AllowUserToDeleteRows = false;
            this.dgDebtTransactions.AllowUserToResizeColumns = false;
            this.dgDebtTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgDebtTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDebtTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDebtTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDebtTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgDebtTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDebtTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDebtTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDebtTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgDebtTransactions.ColumnHeadersHeight = 40;
            this.dgDebtTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDebtTransactions.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgDebtTransactions.DoubleBuffered = true;
            this.dgDebtTransactions.EnableHeadersVisualStyles = false;
            this.dgDebtTransactions.HeaderBgColor = System.Drawing.Color.White;
            this.dgDebtTransactions.HeaderForeColor = System.Drawing.Color.Black;
            this.dgDebtTransactions.Location = new System.Drawing.Point(12, 199);
            this.dgDebtTransactions.MultiSelect = false;
            this.dgDebtTransactions.Name = "dgDebtTransactions";
            this.dgDebtTransactions.ReadOnly = true;
            this.dgDebtTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgDebtTransactions.RowHeadersVisible = false;
            this.dgDebtTransactions.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDebtTransactions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.dgDebtTransactions.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgDebtTransactions.RowTemplate.DividerHeight = 1;
            this.dgDebtTransactions.RowTemplate.Height = 39;
            this.dgDebtTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDebtTransactions.Size = new System.Drawing.Size(1150, 680);
            this.dgDebtTransactions.TabIndex = 15;
            // 
            // lblDebtTransListDate
            // 
            this.lblDebtTransListDate.AutoSize = true;
            this.lblDebtTransListDate.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebtTransListDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDebtTransListDate.Location = new System.Drawing.Point(513, 14);
            this.lblDebtTransListDate.Name = "lblDebtTransListDate";
            this.lblDebtTransListDate.Size = new System.Drawing.Size(151, 35);
            this.lblDebtTransListDate.TabIndex = 16;
            this.lblDebtTransListDate.Text = "14/3/2024";
            // 
            // btnPrevDay
            // 
            this.btnPrevDay.Activecolor = System.Drawing.SystemColors.Control;
            this.btnPrevDay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevDay.BorderRadius = 7;
            this.btnPrevDay.ButtonText = "اليوم السابق";
            this.btnPrevDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevDay.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrevDay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrevDay.Iconimage = global::TabarakGomla_PresentationLayer.Properties.Resources.upload__1_;
            this.btnPrevDay.Iconimage_right = null;
            this.btnPrevDay.Iconimage_right_Selected = null;
            this.btnPrevDay.Iconimage_Selected = null;
            this.btnPrevDay.IconMarginLeft = 0;
            this.btnPrevDay.IconMarginRight = 0;
            this.btnPrevDay.IconRightVisible = true;
            this.btnPrevDay.IconRightZoom = 0D;
            this.btnPrevDay.IconVisible = true;
            this.btnPrevDay.IconZoom = 70D;
            this.btnPrevDay.IsTab = false;
            this.btnPrevDay.Location = new System.Drawing.Point(377, 12);
            this.btnPrevDay.Name = "btnPrevDay";
            this.btnPrevDay.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnPrevDay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevDay.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPrevDay.selected = false;
            this.btnPrevDay.Size = new System.Drawing.Size(108, 37);
            this.btnPrevDay.TabIndex = 18;
            this.btnPrevDay.Text = "اليوم السابق";
            this.btnPrevDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevDay.Textcolor = System.Drawing.Color.Black;
            this.btnPrevDay.TextFont = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevDay.Click += new System.EventHandler(this.btnPrevDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Activecolor = System.Drawing.SystemColors.Control;
            this.btnNextDay.BackColor = System.Drawing.SystemColors.Control;
            this.btnNextDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextDay.BorderRadius = 7;
            this.btnNextDay.ButtonText = "اليوم التالي";
            this.btnNextDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextDay.DisabledColor = System.Drawing.Color.Gray;
            this.btnNextDay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNextDay.Iconimage = null;
            this.btnNextDay.Iconimage_right = global::TabarakGomla_PresentationLayer.Properties.Resources.upload1;
            this.btnNextDay.Iconimage_right_Selected = null;
            this.btnNextDay.Iconimage_Selected = null;
            this.btnNextDay.IconMarginLeft = 0;
            this.btnNextDay.IconMarginRight = 0;
            this.btnNextDay.IconRightVisible = true;
            this.btnNextDay.IconRightZoom = 0D;
            this.btnNextDay.IconVisible = true;
            this.btnNextDay.IconZoom = 70D;
            this.btnNextDay.IsTab = false;
            this.btnNextDay.Location = new System.Drawing.Point(692, 12);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnNextDay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNextDay.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnNextDay.selected = false;
            this.btnNextDay.Size = new System.Drawing.Size(99, 37);
            this.btnNextDay.TabIndex = 17;
            this.btnNextDay.Text = "اليوم التالي";
            this.btnNextDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextDay.Textcolor = System.Drawing.Color.Black;
            this.btnNextDay.TextFont = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // btnGoTodayDate
            // 
            this.btnGoTodayDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoTodayDate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGoTodayDate.Depth = 0;
            this.btnGoTodayDate.HighEmphasis = true;
            this.btnGoTodayDate.Icon = null;
            this.btnGoTodayDate.Location = new System.Drawing.Point(529, 67);
            this.btnGoTodayDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoTodayDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoTodayDate.Name = "btnGoTodayDate";
            this.btnGoTodayDate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGoTodayDate.Size = new System.Drawing.Size(119, 36);
            this.btnGoTodayDate.TabIndex = 19;
            this.btnGoTodayDate.Text = "الذهاب لتاريخ اليوم";
            this.btnGoTodayDate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGoTodayDate.UseAccentColor = false;
            this.btnGoTodayDate.UseVisualStyleBackColor = true;
            this.btnGoTodayDate.Click += new System.EventHandler(this.btnGoTodayDate_Click);
            // 
            // dpCurrentDate
            // 
            this.dpCurrentDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpCurrentDate.BorderRadius = 0;
            this.dpCurrentDate.ForeColor = System.Drawing.Color.White;
            this.dpCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpCurrentDate.FormatCustom = null;
            this.dpCurrentDate.Location = new System.Drawing.Point(12, 157);
            this.dpCurrentDate.Name = "dpCurrentDate";
            this.dpCurrentDate.Size = new System.Drawing.Size(303, 36);
            this.dpCurrentDate.TabIndex = 20;
            this.dpCurrentDate.Value = new System.DateTime(2024, 3, 15, 15, 59, 50, 882);
            this.dpCurrentDate.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // frmDebtTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 891);
            this.Controls.Add(this.dpCurrentDate);
            this.Controls.Add(this.btnGoTodayDate);
            this.Controls.Add(this.btnPrevDay);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.lblDebtTransListDate);
            this.Controls.Add(this.dgDebtTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDebtTransactions";
            this.Text = "frmDebtTransactions";
            this.Load += new System.EventHandler(this.frmDebtTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDebtTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgDebtTransactions;
        private System.Windows.Forms.Label lblDebtTransListDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnNextDay;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrevDay;
        private MaterialSkin.Controls.MaterialButton btnGoTodayDate;
        private Bunifu.Framework.UI.BunifuDatepicker dpCurrentDate;
    }
}