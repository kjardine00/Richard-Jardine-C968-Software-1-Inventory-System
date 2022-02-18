
namespace Richard_Jardine_C968
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainScreenTitle = new System.Windows.Forms.Label();
            this.MainScreenPartsLabel = new System.Windows.Forms.Label();
            this.MainScreenProductsLabel = new System.Windows.Forms.Label();
            this.MainScreenPartsSearchBtn = new System.Windows.Forms.Button();
            this.MainScreenProductsSearchBtn = new System.Windows.Forms.Button();
            this.MainScreenPartsAddBtn = new System.Windows.Forms.Button();
            this.MainScreenPartsModifyBtn = new System.Windows.Forms.Button();
            this.MainScreenPartsDeleteBtn = new System.Windows.Forms.Button();
            this.MainScreenPartsTextSearch = new System.Windows.Forms.TextBox();
            this.MainScreenProductsSearchText = new System.Windows.Forms.TextBox();
            this.PartsDataGridView = new System.Windows.Forms.DataGridView();
            this.MainScreenExitBtn = new System.Windows.Forms.Button();
            this.MainScreenProductsDeleteBtn = new System.Windows.Forms.Button();
            this.MainScreenProductsModifyBtn = new System.Windows.Forms.Button();
            this.MainScreenProductsAddBtn = new System.Windows.Forms.Button();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainScreenTitle
            // 
            this.MainScreenTitle.AutoSize = true;
            this.MainScreenTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainScreenTitle.Location = new System.Drawing.Point(12, 18);
            this.MainScreenTitle.Name = "MainScreenTitle";
            this.MainScreenTitle.Size = new System.Drawing.Size(270, 25);
            this.MainScreenTitle.TabIndex = 0;
            this.MainScreenTitle.Text = "Inventory Management Screen";
            // 
            // MainScreenPartsLabel
            // 
            this.MainScreenPartsLabel.AutoSize = true;
            this.MainScreenPartsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainScreenPartsLabel.Location = new System.Drawing.Point(30, 102);
            this.MainScreenPartsLabel.Name = "MainScreenPartsLabel";
            this.MainScreenPartsLabel.Size = new System.Drawing.Size(44, 21);
            this.MainScreenPartsLabel.TabIndex = 1;
            this.MainScreenPartsLabel.Text = "Parts";
            // 
            // MainScreenProductsLabel
            // 
            this.MainScreenProductsLabel.AutoSize = true;
            this.MainScreenProductsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainScreenProductsLabel.Location = new System.Drawing.Point(393, 102);
            this.MainScreenProductsLabel.Name = "MainScreenProductsLabel";
            this.MainScreenProductsLabel.Size = new System.Drawing.Size(71, 21);
            this.MainScreenProductsLabel.TabIndex = 2;
            this.MainScreenProductsLabel.Text = "Products";
            // 
            // MainScreenPartsSearchBtn
            // 
            this.MainScreenPartsSearchBtn.Location = new System.Drawing.Point(121, 97);
            this.MainScreenPartsSearchBtn.Name = "MainScreenPartsSearchBtn";
            this.MainScreenPartsSearchBtn.Size = new System.Drawing.Size(118, 23);
            this.MainScreenPartsSearchBtn.TabIndex = 3;
            this.MainScreenPartsSearchBtn.Text = "Search Part ID";
            this.MainScreenPartsSearchBtn.UseVisualStyleBackColor = true;
            this.MainScreenPartsSearchBtn.Click += new System.EventHandler(this.MainScreenPartsSearchBtn_Click);
            // 
            // MainScreenProductsSearchBtn
            // 
            this.MainScreenProductsSearchBtn.Location = new System.Drawing.Point(470, 97);
            this.MainScreenProductsSearchBtn.Name = "MainScreenProductsSearchBtn";
            this.MainScreenProductsSearchBtn.Size = new System.Drawing.Size(118, 23);
            this.MainScreenProductsSearchBtn.TabIndex = 4;
            this.MainScreenProductsSearchBtn.Text = "Search Product ID";
            this.MainScreenProductsSearchBtn.UseVisualStyleBackColor = true;
            this.MainScreenProductsSearchBtn.Click += new System.EventHandler(this.MainScreenProductsSearchBtn_Click);
            // 
            // MainScreenPartsAddBtn
            // 
            this.MainScreenPartsAddBtn.Location = new System.Drawing.Point(172, 292);
            this.MainScreenPartsAddBtn.Name = "MainScreenPartsAddBtn";
            this.MainScreenPartsAddBtn.Size = new System.Drawing.Size(58, 23);
            this.MainScreenPartsAddBtn.TabIndex = 5;
            this.MainScreenPartsAddBtn.Text = "Add";
            this.MainScreenPartsAddBtn.UseVisualStyleBackColor = true;
            this.MainScreenPartsAddBtn.Click += new System.EventHandler(this.MainScreenPartsAddBtn_Click);
            // 
            // MainScreenPartsModifyBtn
            // 
            this.MainScreenPartsModifyBtn.Location = new System.Drawing.Point(236, 292);
            this.MainScreenPartsModifyBtn.Name = "MainScreenPartsModifyBtn";
            this.MainScreenPartsModifyBtn.Size = new System.Drawing.Size(58, 23);
            this.MainScreenPartsModifyBtn.TabIndex = 6;
            this.MainScreenPartsModifyBtn.Text = "Modify";
            this.MainScreenPartsModifyBtn.UseVisualStyleBackColor = true;
            this.MainScreenPartsModifyBtn.Click += new System.EventHandler(this.MainScreenPartsModifyBtn_Click);
            // 
            // MainScreenPartsDeleteBtn
            // 
            this.MainScreenPartsDeleteBtn.Location = new System.Drawing.Point(300, 292);
            this.MainScreenPartsDeleteBtn.Name = "MainScreenPartsDeleteBtn";
            this.MainScreenPartsDeleteBtn.Size = new System.Drawing.Size(58, 23);
            this.MainScreenPartsDeleteBtn.TabIndex = 7;
            this.MainScreenPartsDeleteBtn.Text = "Delete";
            this.MainScreenPartsDeleteBtn.UseVisualStyleBackColor = true;
            this.MainScreenPartsDeleteBtn.Click += new System.EventHandler(this.MainScreenPartsDeleteBtn_Click);
            // 
            // MainScreenPartsTextSearch
            // 
            this.MainScreenPartsTextSearch.Location = new System.Drawing.Point(245, 97);
            this.MainScreenPartsTextSearch.Name = "MainScreenPartsTextSearch";
            this.MainScreenPartsTextSearch.Size = new System.Drawing.Size(114, 23);
            this.MainScreenPartsTextSearch.TabIndex = 8;
            // 
            // MainScreenProductsSearchText
            // 
            this.MainScreenProductsSearchText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MainScreenProductsSearchText.Location = new System.Drawing.Point(594, 97);
            this.MainScreenProductsSearchText.Name = "MainScreenProductsSearchText";
            this.MainScreenProductsSearchText.Size = new System.Drawing.Size(114, 23);
            this.MainScreenProductsSearchText.TabIndex = 9;
            this.MainScreenProductsSearchText.TextChanged += new System.EventHandler(this.MainScreenProductsSearchText_TextChanged);
            // 
            // PartsDataGridView
            // 
            this.PartsDataGridView.AllowUserToAddRows = false;
            this.PartsDataGridView.AllowUserToDeleteRows = false;
            this.PartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PartsDataGridView.Location = new System.Drawing.Point(30, 126);
            this.PartsDataGridView.MultiSelect = false;
            this.PartsDataGridView.Name = "PartsDataGridView";
            this.PartsDataGridView.ReadOnly = true;
            this.PartsDataGridView.RowHeadersVisible = false;
            this.PartsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDataGridView.Size = new System.Drawing.Size(331, 150);
            this.PartsDataGridView.TabIndex = 10;
            // 
            // MainScreenExitBtn
            // 
            this.MainScreenExitBtn.Location = new System.Drawing.Point(633, 371);
            this.MainScreenExitBtn.Name = "MainScreenExitBtn";
            this.MainScreenExitBtn.Size = new System.Drawing.Size(75, 23);
            this.MainScreenExitBtn.TabIndex = 15;
            this.MainScreenExitBtn.Text = "Exit";
            this.MainScreenExitBtn.UseVisualStyleBackColor = true;
            this.MainScreenExitBtn.Click += new System.EventHandler(this.MainScreenExitBtn_Click);
            // 
            // MainScreenProductsDeleteBtn
            // 
            this.MainScreenProductsDeleteBtn.Location = new System.Drawing.Point(647, 292);
            this.MainScreenProductsDeleteBtn.Name = "MainScreenProductsDeleteBtn";
            this.MainScreenProductsDeleteBtn.Size = new System.Drawing.Size(58, 23);
            this.MainScreenProductsDeleteBtn.TabIndex = 18;
            this.MainScreenProductsDeleteBtn.Text = "Delete";
            this.MainScreenProductsDeleteBtn.UseVisualStyleBackColor = true;
            this.MainScreenProductsDeleteBtn.Click += new System.EventHandler(this.MainScreenProductsDeleteBtn_Click);
            // 
            // MainScreenProductsModifyBtn
            // 
            this.MainScreenProductsModifyBtn.Location = new System.Drawing.Point(583, 292);
            this.MainScreenProductsModifyBtn.Name = "MainScreenProductsModifyBtn";
            this.MainScreenProductsModifyBtn.Size = new System.Drawing.Size(58, 23);
            this.MainScreenProductsModifyBtn.TabIndex = 17;
            this.MainScreenProductsModifyBtn.Text = "Modify";
            this.MainScreenProductsModifyBtn.UseVisualStyleBackColor = true;
            this.MainScreenProductsModifyBtn.Click += new System.EventHandler(this.MainScreenProductsModifyBtn_Click);
            // 
            // MainScreenProductsAddBtn
            // 
            this.MainScreenProductsAddBtn.Location = new System.Drawing.Point(519, 292);
            this.MainScreenProductsAddBtn.Name = "MainScreenProductsAddBtn";
            this.MainScreenProductsAddBtn.Size = new System.Drawing.Size(58, 23);
            this.MainScreenProductsAddBtn.TabIndex = 16;
            this.MainScreenProductsAddBtn.Text = "Add";
            this.MainScreenProductsAddBtn.UseVisualStyleBackColor = true;
            this.MainScreenProductsAddBtn.Click += new System.EventHandler(this.MainScreenProductsAddBtn_Click);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AllowUserToDeleteRows = false;
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ProductsDataGridView.Location = new System.Drawing.Point(393, 126);
            this.ProductsDataGridView.MultiSelect = false;
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.RowHeadersVisible = false;
            this.ProductsDataGridView.RowTemplate.Height = 25;
            this.ProductsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(315, 150);
            this.ProductsDataGridView.TabIndex = 11;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 418);
            this.Controls.Add(this.MainScreenProductsDeleteBtn);
            this.Controls.Add(this.MainScreenProductsModifyBtn);
            this.Controls.Add(this.MainScreenProductsAddBtn);
            this.Controls.Add(this.MainScreenExitBtn);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.PartsDataGridView);
            this.Controls.Add(this.MainScreenProductsSearchText);
            this.Controls.Add(this.MainScreenPartsTextSearch);
            this.Controls.Add(this.MainScreenPartsDeleteBtn);
            this.Controls.Add(this.MainScreenPartsModifyBtn);
            this.Controls.Add(this.MainScreenPartsAddBtn);
            this.Controls.Add(this.MainScreenProductsSearchBtn);
            this.Controls.Add(this.MainScreenPartsSearchBtn);
            this.Controls.Add(this.MainScreenProductsLabel);
            this.Controls.Add(this.MainScreenPartsLabel);
            this.Controls.Add(this.MainScreenTitle);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainScreenTitle;
        private System.Windows.Forms.Label MainScreenPartsLabel;
        private System.Windows.Forms.Label MainScreenProductsLabel;
        private System.Windows.Forms.Button MainScreenPartsSearchBtn;
        private System.Windows.Forms.Button MainScreenProductsSearchBtn;
        private System.Windows.Forms.Button MainScreenPartsAddBtn;
        private System.Windows.Forms.Button MainScreenPartsModifyBtn;
        private System.Windows.Forms.Button MainScreenPartsDeleteBtn;
        private System.Windows.Forms.TextBox MainScreenPartsTextSearch;
        private System.Windows.Forms.TextBox MainScreenProductsSearchText;
        public System.Windows.Forms.DataGridView PartsDataGridView;
        private System.Windows.Forms.Button MainScreenExitBtn;
        private System.Windows.Forms.Button MainScreenProductsDeleteBtn;
        private System.Windows.Forms.Button MainScreenProductsModifyBtn;
        private System.Windows.Forms.Button MainScreenProductsAddBtn;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
    }
}

