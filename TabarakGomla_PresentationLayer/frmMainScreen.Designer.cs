namespace TabarakGomla_PresentationLayer
{
    partial class frmMainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFormsLoader = new System.Windows.Forms.Panel();
            this.btnProducts = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSpendings = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPeople = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCustomersDebt = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnStats = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpendings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomersDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStats)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnSpendings);
            this.panel1.Controls.Add(this.btnPeople);
            this.panel1.Controls.Add(this.btnCustomersDebt);
            this.panel1.Controls.Add(this.btnStats);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(1175, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 891);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Love of Thunder", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "تبارك";
            // 
            // pnlFormsLoader
            // 
            this.pnlFormsLoader.BackColor = System.Drawing.Color.White;
            this.pnlFormsLoader.Location = new System.Drawing.Point(1, 0);
            this.pnlFormsLoader.Name = "pnlFormsLoader";
            this.pnlFormsLoader.Size = new System.Drawing.Size(1174, 891);
            this.pnlFormsLoader.TabIndex = 28;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Image = global::TabarakGomla_PresentationLayer.Properties.Resources.products_off1;
            this.btnProducts.ImageActive = null;
            this.btnProducts.Location = new System.Drawing.Point(25, 453);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(39, 36);
            this.btnProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProducts.TabIndex = 32;
            this.btnProducts.TabStop = false;
            this.btnProducts.Zoom = 10;
            this.btnProducts.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // btnSpendings
            // 
            this.btnSpendings.BackColor = System.Drawing.Color.Transparent;
            this.btnSpendings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpendings.Image = global::TabarakGomla_PresentationLayer.Properties.Resources.money_off;
            this.btnSpendings.ImageActive = null;
            this.btnSpendings.Location = new System.Drawing.Point(24, 368);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(39, 36);
            this.btnSpendings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSpendings.TabIndex = 31;
            this.btnSpendings.TabStop = false;
            this.btnSpendings.Zoom = 10;
            this.btnSpendings.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeople.Image = global::TabarakGomla_PresentationLayer.Properties.Resources.people_off;
            this.btnPeople.ImageActive = null;
            this.btnPeople.Location = new System.Drawing.Point(24, 289);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(39, 36);
            this.btnPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPeople.TabIndex = 30;
            this.btnPeople.TabStop = false;
            this.btnPeople.Zoom = 10;
            this.btnPeople.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // btnCustomersDebt
            // 
            this.btnCustomersDebt.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomersDebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomersDebt.Image = global::TabarakGomla_PresentationLayer.Properties.Resources.borrow_off;
            this.btnCustomersDebt.ImageActive = null;
            this.btnCustomersDebt.Location = new System.Drawing.Point(24, 207);
            this.btnCustomersDebt.Name = "btnCustomersDebt";
            this.btnCustomersDebt.Size = new System.Drawing.Size(39, 36);
            this.btnCustomersDebt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCustomersDebt.TabIndex = 29;
            this.btnCustomersDebt.TabStop = false;
            this.btnCustomersDebt.Zoom = 10;
            this.btnCustomersDebt.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.Transparent;
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStats.Image = global::TabarakGomla_PresentationLayer.Properties.Resources.statisctics_off;
            this.btnStats.ImageActive = null;
            this.btnStats.Location = new System.Drawing.Point(24, 125);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(39, 36);
            this.btnStats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStats.TabIndex = 28;
            this.btnStats.TabStop = false;
            this.btnStats.Zoom = 10;
            this.btnStats.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 891);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFormsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabarak Gomla";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpendings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomersDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnStats;
        private System.Windows.Forms.Panel pnlFormsLoader;
        private Bunifu.Framework.UI.BunifuImageButton btnCustomersDebt;
        private Bunifu.Framework.UI.BunifuImageButton btnPeople;
        private Bunifu.Framework.UI.BunifuImageButton btnSpendings;
        private Bunifu.Framework.UI.BunifuImageButton btnProducts;
    }
}

