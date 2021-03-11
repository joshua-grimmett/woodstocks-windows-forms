namespace StockControl
{
    partial class MainWindow
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
            this.gridStocks = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnOrder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_ItemCode = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_CurrentCount = new System.Windows.Forms.Label();
            this.lbl_OnOrder = new System.Windows.Forms.Label();
            this.box_OnOrder = new System.Windows.Forms.CheckBox();
            this.txt_ItemCode = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_CurrentCount = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStocks
            // 
            this.gridStocks.AllowUserToAddRows = false;
            this.gridStocks.AllowUserToDeleteRows = false;
            this.gridStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.Description,
            this.CurrentCount,
            this.OnOrder});
            this.gridStocks.Location = new System.Drawing.Point(0, 0);
            this.gridStocks.Name = "gridStocks";
            this.gridStocks.Size = new System.Drawing.Size(491, 591);
            this.gridStocks.TabIndex = 0;
            this.gridStocks.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridStocks_CellEnter);
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemCode.Width = 120;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // CurrentCount
            // 
            this.CurrentCount.DataPropertyName = "CurrentCount";
            this.CurrentCount.HeaderText = "Current Count";
            this.CurrentCount.Name = "CurrentCount";
            // 
            // OnOrder
            // 
            this.OnOrder.DataPropertyName = "OnOrder";
            this.OnOrder.HeaderText = "On Order";
            this.OnOrder.Name = "OnOrder";
            this.OnOrder.ReadOnly = true;
            this.OnOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OnOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OnOrder.Width = 80;
            // 
            // lbl_ItemCode
            // 
            this.lbl_ItemCode.AutoSize = true;
            this.lbl_ItemCode.Location = new System.Drawing.Point(511, 127);
            this.lbl_ItemCode.Name = "lbl_ItemCode";
            this.lbl_ItemCode.Size = new System.Drawing.Size(58, 13);
            this.lbl_ItemCode.TabIndex = 1;
            this.lbl_ItemCode.Text = "Item Code:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(511, 178);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Text = "Description:";
            // 
            // lbl_CurrentCount
            // 
            this.lbl_CurrentCount.AutoSize = true;
            this.lbl_CurrentCount.Location = new System.Drawing.Point(511, 234);
            this.lbl_CurrentCount.Name = "lbl_CurrentCount";
            this.lbl_CurrentCount.Size = new System.Drawing.Size(75, 13);
            this.lbl_CurrentCount.TabIndex = 3;
            this.lbl_CurrentCount.Text = "Current Count:";
            // 
            // lbl_OnOrder
            // 
            this.lbl_OnOrder.AutoSize = true;
            this.lbl_OnOrder.Location = new System.Drawing.Point(511, 272);
            this.lbl_OnOrder.Name = "lbl_OnOrder";
            this.lbl_OnOrder.Size = new System.Drawing.Size(53, 13);
            this.lbl_OnOrder.TabIndex = 4;
            this.lbl_OnOrder.Text = "On Order:";
            // 
            // box_OnOrder
            // 
            this.box_OnOrder.AutoSize = true;
            this.box_OnOrder.Enabled = false;
            this.box_OnOrder.Location = new System.Drawing.Point(649, 272);
            this.box_OnOrder.Name = "box_OnOrder";
            this.box_OnOrder.Size = new System.Drawing.Size(15, 14);
            this.box_OnOrder.TabIndex = 5;
            this.box_OnOrder.UseVisualStyleBackColor = true;
            // 
            // txt_ItemCode
            // 
            this.txt_ItemCode.Location = new System.Drawing.Point(514, 143);
            this.txt_ItemCode.Name = "txt_ItemCode";
            this.txt_ItemCode.ReadOnly = true;
            this.txt_ItemCode.Size = new System.Drawing.Size(150, 20);
            this.txt_ItemCode.TabIndex = 6;
            this.txt_ItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(514, 194);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.Size = new System.Drawing.Size(150, 20);
            this.txt_Description.TabIndex = 7;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CurrentCount
            // 
            this.txt_CurrentCount.Location = new System.Drawing.Point(622, 231);
            this.txt_CurrentCount.Name = "txt_CurrentCount";
            this.txt_CurrentCount.Size = new System.Drawing.Size(42, 20);
            this.txt_CurrentCount.TabIndex = 8;
            this.txt_CurrentCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_CurrentCount.TextChanged += new System.EventHandler(this.Txt_CurrentCount_TextChanged);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(511, 22);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(153, 23);
            this.btn_Load.TabIndex = 9;
            this.btn_Load.Text = "Load Stocks";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(511, 51);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(153, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save Stocks";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 591);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.txt_CurrentCount);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_ItemCode);
            this.Controls.Add(this.box_OnOrder);
            this.Controls.Add(this.lbl_OnOrder);
            this.Controls.Add(this.lbl_CurrentCount);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_ItemCode);
            this.Controls.Add(this.gridStocks);
            this.Name = "MainWindow";
            this.Text = "Stock Control";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStocks;
        private System.Windows.Forms.Label lbl_ItemCode;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_CurrentCount;
        private System.Windows.Forms.Label lbl_OnOrder;
        private System.Windows.Forms.CheckBox box_OnOrder;
        private System.Windows.Forms.TextBox txt_ItemCode;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_CurrentCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OnOrder;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Save;
    }
}

