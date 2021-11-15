namespace TradingCompany.FormsUI.Menu
{
    partial class MenuForm
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
            this.button_profile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_clock = new System.Windows.Forms.Label();
            this.button_sign_out = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.datagrid_recent_orders = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_recent_orders = new System.Windows.Forms.Label();
            this.button_view_all = new System.Windows.Forms.Button();
            this.Label_menu = new System.Windows.Forms.Label();
            this.buttutton_orders = new System.Windows.Forms.Button();
            this.button_products = new System.Windows.Forms.Button();
            this.button_suppliers = new System.Windows.Forms.Button();
            this.button_customers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_recent_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_profile
            // 
            this.button_profile.FlatAppearance.BorderSize = 0;
            this.button_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profile.ForeColor = System.Drawing.Color.MediumBlue;
            this.button_profile.Location = new System.Drawing.Point(1105, 18);
            this.button_profile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(100, 28);
            this.button_profile.TabIndex = 8;
            this.button_profile.Text = "Profile";
            this.button_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_profile.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clock.ForeColor = System.Drawing.Color.Black;
            this.label_clock.Location = new System.Drawing.Point(15, 16);
            this.label_clock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(75, 33);
            this.label_clock.TabIndex = 10;
            this.label_clock.Text = "Clock";
            // 
            // button_sign_out
            // 
            this.button_sign_out.FlatAppearance.BorderSize = 0;
            this.button_sign_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sign_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sign_out.ForeColor = System.Drawing.Color.MediumBlue;
            this.button_sign_out.Location = new System.Drawing.Point(1227, 16);
            this.button_sign_out.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_sign_out.Name = "button_sign_out";
            this.button_sign_out.Size = new System.Drawing.Size(77, 31);
            this.button_sign_out.TabIndex = 11;
            this.button_sign_out.Text = "Sign Out";
            this.button_sign_out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sign_out.UseVisualStyleBackColor = false;
            this.button_sign_out.Click += new System.EventHandler(this.Button_sign_out_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Black;
            this.label_date.Location = new System.Drawing.Point(17, 50);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(50, 24);
            this.label_date.TabIndex = 12;
            this.label_date.Text = "Date";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.Black;
            this.label_name.Location = new System.Drawing.Point(1112, 62);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(168, 29);
            this.label_name.TabIndex = 13;
            this.label_name.Text = "Name Surname";
            // 
            // datagrid_recent_orders
            // 
            this.datagrid_recent_orders.AllowUserToAddRows = false;
            this.datagrid_recent_orders.AutoGenerateColumns = false;
            this.datagrid_recent_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid_recent_orders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_recent_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_recent_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.datagrid_recent_orders.DataSource = this.ordersDTOBindingSource;
            this.datagrid_recent_orders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.datagrid_recent_orders.Location = new System.Drawing.Point(427, 208);
            this.datagrid_recent_orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datagrid_recent_orders.Name = "datagrid_recent_orders";
            this.datagrid_recent_orders.ReadOnly = true;
            this.datagrid_recent_orders.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_recent_orders.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_recent_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_recent_orders.ShowEditingIcon = false;
            this.datagrid_recent_orders.Size = new System.Drawing.Size(779, 208);
            this.datagrid_recent_orders.TabIndex = 8;
            this.datagrid_recent_orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_recent_orders_CellContentClick_1);
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
            // ordersDTOBindingSource
            // 
            this.ordersDTOBindingSource.DataSource = typeof(TradingCompany.BLL.DTO.OrderDTO);
            // 
            // label_recent_orders
            // 
            this.label_recent_orders.AutoSize = true;
            this.label_recent_orders.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_recent_orders.ForeColor = System.Drawing.Color.Black;
            this.label_recent_orders.Location = new System.Drawing.Point(421, 181);
            this.label_recent_orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_recent_orders.Name = "label_recent_orders";
            this.label_recent_orders.Size = new System.Drawing.Size(128, 24);
            this.label_recent_orders.TabIndex = 15;
            this.label_recent_orders.Text = "Recent Orders";
            // 
            // button_view_all
            // 
            this.button_view_all.FlatAppearance.BorderSize = 0;
            this.button_view_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_view_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_view_all.ForeColor = System.Drawing.Color.Black;
            this.button_view_all.Location = new System.Drawing.Point(564, 180);
            this.button_view_all.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_view_all.Name = "button_view_all";
            this.button_view_all.Size = new System.Drawing.Size(100, 28);
            this.button_view_all.TabIndex = 5;
            this.button_view_all.Text = "view all";
            this.button_view_all.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_view_all.UseVisualStyleBackColor = false;
            this.button_view_all.Click += new System.EventHandler(this.Button_view_all_Click);
            // 
            // Label_menu
            // 
            this.Label_menu.AutoSize = true;
            this.Label_menu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_menu.ForeColor = System.Drawing.Color.Black;
            this.Label_menu.Location = new System.Drawing.Point(107, 219);
            this.Label_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_menu.Name = "Label_menu";
            this.Label_menu.Size = new System.Drawing.Size(59, 24);
            this.Label_menu.TabIndex = 17;
            this.Label_menu.Text = "Menu";
            // 
            // buttutton_orders
            // 
            this.buttutton_orders.Location = new System.Drawing.Point(112, 247);
            this.buttutton_orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttutton_orders.Name = "buttutton_orders";
            this.buttutton_orders.Size = new System.Drawing.Size(180, 64);
            this.buttutton_orders.TabIndex = 1;
            this.buttutton_orders.Text = "Orders";
            this.buttutton_orders.UseVisualStyleBackColor = true;
            this.buttutton_orders.Click += new System.EventHandler(this.Buttutton_orders_Click);
            // 
            // button_products
            // 
            this.button_products.Location = new System.Drawing.Point(115, 337);
            this.button_products.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(179, 64);
            this.button_products.TabIndex = 2;
            this.button_products.Text = "Products";
            this.button_products.UseVisualStyleBackColor = true;
            // 
            // button_suppliers
            // 
            this.button_suppliers.Location = new System.Drawing.Point(112, 526);
            this.button_suppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_suppliers.Name = "button_suppliers";
            this.button_suppliers.Size = new System.Drawing.Size(181, 64);
            this.button_suppliers.TabIndex = 4;
            this.button_suppliers.Text = "Suppliers";
            this.button_suppliers.UseVisualStyleBackColor = true;
            // 
            // button_customers
            // 
            this.button_customers.Location = new System.Drawing.Point(115, 433);
            this.button_customers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(179, 64);
            this.button_customers.TabIndex = 3;
            this.button_customers.Text = "Customers";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.Button_customers_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(564, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "view all";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(421, 425);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Recent Orders";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_customers);
            this.Controls.Add(this.button_suppliers);
            this.Controls.Add(this.button_products);
            this.Controls.Add(this.buttutton_orders);
            this.Controls.Add(this.Label_menu);
            this.Controls.Add(this.button_view_all);
            this.Controls.Add(this.label_recent_orders);
            this.Controls.Add(this.datagrid_recent_orders);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.button_sign_out);
            this.Controls.Add(this.label_clock);
            this.Controls.Add(this.button_profile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_recent_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_clock;
        private System.Windows.Forms.Button button_sign_out;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.DataGridView datagrid_recent_orders;
        private System.Windows.Forms.Label label_recent_orders;
        private System.Windows.Forms.Button button_view_all;
        private System.Windows.Forms.Label Label_menu;
        private System.Windows.Forms.Button buttutton_orders;
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.Button button_suppliers;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.BindingSource ordersDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}