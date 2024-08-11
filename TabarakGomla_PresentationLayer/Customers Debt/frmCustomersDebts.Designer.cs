namespace TabarakGomla_PresentationLayer.Customers_Debt
{
    partial class frmCustomersDebts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersDebts));
            this.dgCustomersDebts = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAddCustomer = new MaterialSkin.Controls.MaterialButton();
            this.btnTransHistory = new MaterialSkin.Controls.MaterialButton();
            this.btnClearSeach = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuTextbox();
            this.cmsDebtOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemAddAmount = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDecreaseAmount = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomersDebts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSeach)).BeginInit();
            this.cmsDebtOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCustomersDebts
            // 
            this.dgCustomersDebts.AllowUserToAddRows = false;
            this.dgCustomersDebts.AllowUserToDeleteRows = false;
            this.dgCustomersDebts.AllowUserToResizeColumns = false;
            this.dgCustomersDebts.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgCustomersDebts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCustomersDebts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCustomersDebts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomersDebts.BackgroundColor = System.Drawing.Color.White;
            this.dgCustomersDebts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCustomersDebts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCustomersDebts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomersDebts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCustomersDebts.ColumnHeadersHeight = 40;
            this.dgCustomersDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomersDebts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgCustomersDebts.DoubleBuffered = true;
            this.dgCustomersDebts.EnableHeadersVisualStyles = false;
            this.dgCustomersDebts.HeaderBgColor = System.Drawing.Color.White;
            this.dgCustomersDebts.HeaderForeColor = System.Drawing.Color.Black;
            this.dgCustomersDebts.Location = new System.Drawing.Point(12, 199);
            this.dgCustomersDebts.MultiSelect = false;
            this.dgCustomersDebts.Name = "dgCustomersDebts";
            this.dgCustomersDebts.ReadOnly = true;
            this.dgCustomersDebts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgCustomersDebts.RowHeadersVisible = false;
            this.dgCustomersDebts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCustomersDebts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.dgCustomersDebts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgCustomersDebts.RowTemplate.DividerHeight = 1;
            this.dgCustomersDebts.RowTemplate.Height = 39;
            this.dgCustomersDebts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomersDebts.Size = new System.Drawing.Size(1150, 680);
            this.dgCustomersDebts.TabIndex = 14;
            this.dgCustomersDebts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCustomersDebts_CellMouseDown);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCustomer.Depth = 0;
            this.btnAddCustomer.Font = new System.Drawing.Font("المحارب2الموهوب", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddCustomer.HighEmphasis = true;
            this.btnAddCustomer.Icon = null;
            this.btnAddCustomer.Location = new System.Drawing.Point(957, 154);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddCustomer.Size = new System.Drawing.Size(76, 36);
            this.btnAddCustomer.TabIndex = 15;
            this.btnAddCustomer.Text = "إضافة بائع";
            this.btnAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCustomer.UseAccentColor = false;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnTransHistory
            // 
            this.btnTransHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTransHistory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTransHistory.Depth = 0;
            this.btnTransHistory.Font = new System.Drawing.Font("المحارب2الموهوب", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTransHistory.HighEmphasis = true;
            this.btnTransHistory.Icon = null;
            this.btnTransHistory.Location = new System.Drawing.Point(1061, 154);
            this.btnTransHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTransHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTransHistory.Name = "btnTransHistory";
            this.btnTransHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTransHistory.Size = new System.Drawing.Size(100, 36);
            this.btnTransHistory.TabIndex = 32;
            this.btnTransHistory.Text = "تقارير العمليات";
            this.btnTransHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTransHistory.UseAccentColor = false;
            this.btnTransHistory.UseVisualStyleBackColor = true;
            this.btnTransHistory.Click += new System.EventHandler(this.btnTransHistory_Click);
            // 
            // btnClearSeach
            // 
            this.btnClearSeach.BackColor = System.Drawing.Color.White;
            this.btnClearSeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSeach.Image = global::TabarakGomla_PresentationLayer.Properties.Resources.icons8_multiply_48___Copy;
            this.btnClearSeach.ImageActive = null;
            this.btnClearSeach.Location = new System.Drawing.Point(308, 140);
            this.btnClearSeach.Name = "btnClearSeach";
            this.btnClearSeach.Size = new System.Drawing.Size(32, 31);
            this.btnClearSeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClearSeach.TabIndex = 31;
            this.btnClearSeach.TabStop = false;
            this.btnClearSeach.Zoom = 10;
            this.btnClearSeach.Click += new System.EventHandler(this.btnClearSeach_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.Color.White;
            this.txtSearchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchBar.BackgroundImage")));
            this.txtSearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(202)))), ((int)(((byte)(219)))));
            this.txtSearchBar.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchBar.Icon")));
            this.txtSearchBar.Location = new System.Drawing.Point(13, 132);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(336, 46);
            this.txtSearchBar.TabIndex = 16;
            this.txtSearchBar.text = "";
            this.txtSearchBar.OnTextChange += new System.EventHandler(this.txtSearchBar_OnTextChange);
            // 
            // cmsDebtOperations
            // 
            this.cmsDebtOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAddAmount,
            this.itemDecreaseAmount});
            this.cmsDebtOperations.Name = "contextMecmsDebtOperationsnuStrip1";
            this.cmsDebtOperations.Size = new System.Drawing.Size(130, 48);
            // 
            // itemAddAmount
            // 
            this.itemAddAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.itemAddAmount.Name = "itemAddAmount";
            this.itemAddAmount.Size = new System.Drawing.Size(129, 22);
            this.itemAddAmount.Text = "اضافة مبلغ";
            this.itemAddAmount.Click += new System.EventHandler(this.itemAddAmount_Click);
            // 
            // itemDecreaseAmount
            // 
            this.itemDecreaseAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.itemDecreaseAmount.Name = "itemDecreaseAmount";
            this.itemDecreaseAmount.Size = new System.Drawing.Size(129, 22);
            this.itemDecreaseAmount.Text = "دفع مبلغ";
            this.itemDecreaseAmount.Click += new System.EventHandler(this.itemDecreaseAmount_Click);
            // 
            // frmCustomersDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1174, 891);
            this.Controls.Add(this.btnTransHistory);
            this.Controls.Add(this.btnClearSeach);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dgCustomersDebts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomersDebts";
            this.Text = "frmCustomersDebts";
            this.Load += new System.EventHandler(this.frmCustomersDebts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomersDebts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSeach)).EndInit();
            this.cmsDebtOperations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgCustomersDebts;
        private MaterialSkin.Controls.MaterialButton btnAddCustomer;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchBar;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSeach;
        private MaterialSkin.Controls.MaterialButton btnTransHistory;
        private System.Windows.Forms.ContextMenuStrip cmsDebtOperations;
        private System.Windows.Forms.ToolStripMenuItem itemAddAmount;
        private System.Windows.Forms.ToolStripMenuItem itemDecreaseAmount;
    }
}