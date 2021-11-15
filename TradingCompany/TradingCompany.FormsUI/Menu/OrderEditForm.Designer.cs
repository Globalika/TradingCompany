namespace TradingCompany.FormsUI.Menu
{
    partial class OrderEditForm
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
            this.datetime_picker_date = new System.Windows.Forms.DateTimePicker();
            this.combobox_user = new System.Windows.Forms.ComboBox();
            this.textbox_destination = new System.Windows.Forms.TextBox();
            this.label_datetime = new System.Windows.Forms.Label();
            this.label_yser = new System.Windows.Forms.Label();
            this.label_destination = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datetime_picker_date
            // 
            this.datetime_picker_date.Location = new System.Drawing.Point(291, 180);
            this.datetime_picker_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datetime_picker_date.Name = "datetime_picker_date";
            this.datetime_picker_date.Size = new System.Drawing.Size(265, 22);
            this.datetime_picker_date.TabIndex = 58;
            // 
            // combobox_user
            // 
            this.combobox_user.FormattingEnabled = true;
            this.combobox_user.Location = new System.Drawing.Point(291, 139);
            this.combobox_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combobox_user.Name = "combobox_user";
            this.combobox_user.Size = new System.Drawing.Size(132, 24);
            this.combobox_user.TabIndex = 57;
            // 
            // textbox_destination
            // 
            this.textbox_destination.Location = new System.Drawing.Point(291, 98);
            this.textbox_destination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_destination.Name = "textbox_destination";
            this.textbox_destination.Size = new System.Drawing.Size(132, 22);
            this.textbox_destination.TabIndex = 51;
            // 
            // label_datetime
            // 
            this.label_datetime.AutoSize = true;
            this.label_datetime.Location = new System.Drawing.Point(109, 180);
            this.label_datetime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(36, 16);
            this.label_datetime.TabIndex = 55;
            this.label_datetime.Text = "Date";
            // 
            // label_yser
            // 
            this.label_yser.AutoSize = true;
            this.label_yser.Location = new System.Drawing.Point(109, 139);
            this.label_yser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_yser.Name = "label_yser";
            this.label_yser.Size = new System.Drawing.Size(36, 16);
            this.label_yser.TabIndex = 53;
            this.label_yser.Text = "User";
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Location = new System.Drawing.Point(109, 102);
            this.label_destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(74, 16);
            this.label_destination.TabIndex = 52;
            this.label_destination.Text = "Destination";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(324, 247);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 28);
            this.button_ok.TabIndex = 54;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(113, 247);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 28);
            this.button_cancel.TabIndex = 56;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 396);
            this.Controls.Add(this.datetime_picker_date);
            this.Controls.Add(this.combobox_user);
            this.Controls.Add(this.textbox_destination);
            this.Controls.Add(this.label_datetime);
            this.Controls.Add(this.label_yser);
            this.Controls.Add(this.label_destination);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderEditForm";
            this.Text = "OrderEditForm";
            this.Load += new System.EventHandler(this.OrderEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetime_picker_date;
        private System.Windows.Forms.ComboBox combobox_user;
        private System.Windows.Forms.TextBox textbox_destination;
        private System.Windows.Forms.Label label_datetime;
        private System.Windows.Forms.Label label_yser;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
    }
}