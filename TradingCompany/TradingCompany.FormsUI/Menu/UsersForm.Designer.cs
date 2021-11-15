namespace TradingCompany.FormsUI.Menu
{
    partial class UsersForm
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
            this.button_add_user = new System.Windows.Forms.Button();
            this.label_customers = new System.Windows.Forms.Label();
            this.datagrid_recent_orders = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.button_reload = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_recent_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add_user
            // 
            this.button_add_user.Location = new System.Drawing.Point(16, 140);
            this.button_add_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(100, 28);
            this.button_add_user.TabIndex = 20;
            this.button_add_user.Text = "Add Customer";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.Button_add_user_Click);
            // 
            // label_customers
            // 
            this.label_customers.AutoSize = true;
            this.label_customers.Location = new System.Drawing.Point(173, 33);
            this.label_customers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customers.Name = "label_customers";
            this.label_customers.Size = new System.Drawing.Size(71, 16);
            this.label_customers.TabIndex = 19;
            this.label_customers.Text = "Customers";
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
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.hashPasswordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.datagrid_recent_orders.DataSource = this.userViewModelBindingSource;
            this.datagrid_recent_orders.GridColor = System.Drawing.SystemColors.ControlText;
            this.datagrid_recent_orders.Location = new System.Drawing.Point(177, 53);
            this.datagrid_recent_orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datagrid_recent_orders.Name = "datagrid_recent_orders";
            this.datagrid_recent_orders.ReadOnly = true;
            this.datagrid_recent_orders.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_recent_orders.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_recent_orders.Size = new System.Drawing.Size(1079, 581);
            this.datagrid_recent_orders.TabIndex = 18;
            this.datagrid_recent_orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_recent_orders_CellContentClick_1);
            this.datagrid_recent_orders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_recent_orders_CellContentClick);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 98;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 98;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 70;
            // 
            // hashPasswordDataGridViewTextBoxColumn
            // 
            this.hashPasswordDataGridViewTextBoxColumn.DataPropertyName = "HashPassword";
            this.hashPasswordDataGridViewTextBoxColumn.HeaderText = "HashPassword";
            this.hashPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hashPasswordDataGridViewTextBoxColumn.Name = "hashPasswordDataGridViewTextBoxColumn";
            this.hashPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.hashPasswordDataGridViewTextBoxColumn.Visible = false;
            this.hashPasswordDataGridViewTextBoxColumn.Width = 103;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 65;
            // 
            // userViewModelBindingSource
            // 
            this.userViewModelBindingSource.DataSource = typeof(TradingCompany.BLL.Models.UserViewModel);
            // 
            // textbox_search
            // 
            this.textbox_search.Location = new System.Drawing.Point(16, 79);
            this.textbox_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(132, 22);
            this.textbox_search.TabIndex = 0;
            this.textbox_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_search_KeyPressed);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(16, 53);
            this.label_search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(50, 16);
            this.label_search.TabIndex = 21;
            this.label_search.Text = "Search";
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(16, 187);
            this.button_reload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(100, 28);
            this.button_reload.TabIndex = 22;
            this.button_reload.Text = "Reload";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.Button_reload_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(16, 235);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
            this.button_exit.TabIndex = 23;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 721);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.button_add_user);
            this.Controls.Add(this.label_customers);
            this.Controls.Add(this.datagrid_recent_orders);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_recent_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Label label_customers;
        private System.Windows.Forms.DataGridView datagrid_recent_orders;
        private System.Windows.Forms.BindingSource userViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Button button_exit;
    }
}