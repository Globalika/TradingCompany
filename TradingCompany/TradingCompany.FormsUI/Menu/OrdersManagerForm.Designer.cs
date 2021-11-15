namespace TradingCompany.FormsUI.Menu
{
    partial class OrdersManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.button_add_user = new System.Windows.Forms.Button();
            this.label_customers = new System.Windows.Forms.Label();
            this.datagrid_recent_orders = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_supp_reload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_supp_search = new System.Windows.Forms.TextBox();
            this.button_supp_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datagrid_sp = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppToProdViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_sp = new System.Windows.Forms.TextBox();
            this.button_sp_add = new System.Windows.Forms.Button();
            this.userViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_recent_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppToProdViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(5, 212);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
            this.button_exit.TabIndex = 30;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(5, 164);
            this.button_reload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(100, 28);
            this.button_reload.TabIndex = 29;
            this.button_reload.Text = "Reload";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.Button_reload_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(5, 30);
            this.label_search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(50, 16);
            this.label_search.TabIndex = 28;
            this.label_search.Text = "Search";
            // 
            // textbox_search
            // 
            this.textbox_search.Location = new System.Drawing.Point(5, 55);
            this.textbox_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(132, 22);
            this.textbox_search.TabIndex = 24;
            this.textbox_search.TextChanged += new System.EventHandler(this.Textbox_search_TextChanged);
            this.textbox_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_search_KeyUp);
            // 
            // button_add_user
            // 
            this.button_add_user.Location = new System.Drawing.Point(5, 117);
            this.button_add_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(100, 28);
            this.button_add_user.TabIndex = 27;
            this.button_add_user.Text = "Add Customer";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.Button_add_order_Click);
            // 
            // label_customers
            // 
            this.label_customers.AutoSize = true;
            this.label_customers.Location = new System.Drawing.Point(163, 10);
            this.label_customers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customers.Name = "label_customers";
            this.label_customers.Size = new System.Drawing.Size(48, 16);
            this.label_customers.TabIndex = 26;
            this.label_customers.Text = "Orders";
            // 
            // datagrid_recent_orders
            // 
            this.datagrid_recent_orders.AllowUserToAddRows = false;
            this.datagrid_recent_orders.AllowUserToDeleteRows = false;
            this.datagrid_recent_orders.AutoGenerateColumns = false;
            this.datagrid_recent_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid_recent_orders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_recent_orders.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagrid_recent_orders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid_recent_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_recent_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.datagrid_recent_orders.DataSource = this.orderViewModelBindingSource;
            this.datagrid_recent_orders.GridColor = System.Drawing.SystemColors.ControlText;
            this.datagrid_recent_orders.Location = new System.Drawing.Point(167, 30);
            this.datagrid_recent_orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datagrid_recent_orders.Name = "datagrid_recent_orders";
            this.datagrid_recent_orders.ReadOnly = true;
            this.datagrid_recent_orders.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_recent_orders.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_recent_orders.Size = new System.Drawing.Size(668, 409);
            this.datagrid_recent_orders.TabIndex = 25;
            this.datagrid_recent_orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_recent_orders_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 47;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.Width = 65;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationDataGridViewTextBoxColumn.Width = 103;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 99;
            // 
            // orderViewModelBindingSource
            // 
            this.orderViewModelBindingSource.DataSource = typeof(TradingCompany.BLL.Models.OrderViewModel);
            // 
            // button_supp_reload
            // 
            this.button_supp_reload.Location = new System.Drawing.Point(871, 175);
            this.button_supp_reload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_supp_reload.Name = "button_supp_reload";
            this.button_supp_reload.Size = new System.Drawing.Size(100, 28);
            this.button_supp_reload.TabIndex = 36;
            this.button_supp_reload.Text = "Reload";
            this.button_supp_reload.UseVisualStyleBackColor = true;
            this.button_supp_reload.Click += new System.EventHandler(this.Button_supp_reload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(871, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search";
            // 
            // textbox_supp_search
            // 
            this.textbox_supp_search.Location = new System.Drawing.Point(871, 66);
            this.textbox_supp_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_supp_search.Name = "textbox_supp_search";
            this.textbox_supp_search.Size = new System.Drawing.Size(132, 22);
            this.textbox_supp_search.TabIndex = 31;
            this.textbox_supp_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_supp_search_KeyUp);
            // 
            // button_supp_add
            // 
            this.button_supp_add.Location = new System.Drawing.Point(871, 128);
            this.button_supp_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_supp_add.Name = "button_supp_add";
            this.button_supp_add.Size = new System.Drawing.Size(100, 28);
            this.button_supp_add.TabIndex = 34;
            this.button_supp_add.Text = "Add Customer";
            this.button_supp_add.UseVisualStyleBackColor = true;
            this.button_supp_add.Click += new System.EventHandler(this.Button_supp_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1005, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Suppliers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierDTOBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(1009, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(321, 409);
            this.dataGridView1.TabIndex = 32;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 47;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 73;
            // 
            // supplierDTOBindingSource
            // 
            this.supplierDTOBindingSource.DataSource = typeof(TradingCompany.BLL.DTO.SupplierDTO);
            // 
            // datagrid_sp
            // 
            this.datagrid_sp.AllowUserToAddRows = false;
            this.datagrid_sp.AllowUserToDeleteRows = false;
            this.datagrid_sp.AutoGenerateColumns = false;
            this.datagrid_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid_sp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_sp.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagrid_sp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.supplierDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn});
            this.datagrid_sp.DataSource = this.suppToProdViewModelBindingSource;
            this.datagrid_sp.GridColor = System.Drawing.SystemColors.ControlText;
            this.datagrid_sp.Location = new System.Drawing.Point(167, 462);
            this.datagrid_sp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datagrid_sp.Name = "datagrid_sp";
            this.datagrid_sp.ReadOnly = true;
            this.datagrid_sp.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_sp.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_sp.Size = new System.Drawing.Size(668, 409);
            this.datagrid_sp.TabIndex = 37;
            this.datagrid_sp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Datagrid_sp_KeyUp);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 47;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierDataGridViewTextBoxColumn.Width = 86;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Width = 82;
            // 
            // suppToProdViewModelBindingSource
            // 
            this.suppToProdViewModelBindingSource.DataSource = typeof(TradingCompany.BLL.Models.SuppToProdViewModel);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 598);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 41;
            this.button2.Text = "Reload";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Search";
            // 
            // textbox_sp
            // 
            this.textbox_sp.Location = new System.Drawing.Point(16, 490);
            this.textbox_sp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_sp.Name = "textbox_sp";
            this.textbox_sp.Size = new System.Drawing.Size(132, 22);
            this.textbox_sp.TabIndex = 38;
            // 
            // button_sp_add
            // 
            this.button_sp_add.Location = new System.Drawing.Point(16, 551);
            this.button_sp_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_sp_add.Name = "button_sp_add";
            this.button_sp_add.Size = new System.Drawing.Size(100, 28);
            this.button_sp_add.TabIndex = 39;
            this.button_sp_add.Text = "Edit";
            this.button_sp_add.UseVisualStyleBackColor = true;
            this.button_sp_add.Click += new System.EventHandler(this.Button_sp_add_Click);
            // 
            // userViewModelBindingSource
            // 
            this.userViewModelBindingSource.DataSource = typeof(TradingCompany.BLL.Models.UserViewModel);
            // 
            // userViewModelBindingSource1
            // 
            this.userViewModelBindingSource1.DataSource = typeof(TradingCompany.BLL.Models.UserViewModel);
            // 
            // OrdersManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 810);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_sp);
            this.Controls.Add(this.button_sp_add);
            this.Controls.Add(this.datagrid_sp);
            this.Controls.Add(this.button_supp_reload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_supp_search);
            this.Controls.Add(this.button_supp_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.button_add_user);
            this.Controls.Add(this.label_customers);
            this.Controls.Add(this.datagrid_recent_orders);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrdersManagerForm";
            this.Text = "OrdersManagerMenu";
            this.Load += new System.EventHandler(this.OrdersManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_recent_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppToProdViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Label label_customers;
        private System.Windows.Forms.DataGridView datagrid_recent_orders;
        private System.Windows.Forms.Button button_supp_reload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_supp_search;
        private System.Windows.Forms.Button button_supp_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierDTOBindingSource;
        private System.Windows.Forms.DataGridView datagrid_sp;
        private System.Windows.Forms.BindingSource userViewModelBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_sp;
        private System.Windows.Forms.Button button_sp_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource suppToProdViewModelBindingSource;
        private System.Windows.Forms.BindingSource userViewModelBindingSource1;
    }
}