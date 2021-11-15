namespace TradingCompany.FormsUI.Menu
{
    partial class



        UserEditForm
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
            this.combobox_role = new System.Windows.Forms.ComboBox();
            this.textbox_surname = new System.Windows.Forms.TextBox();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label_role = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox_role
            // 
            this.combobox_role.FormattingEnabled = true;
            this.combobox_role.Location = new System.Drawing.Point(309, 201);
            this.combobox_role.Margin = new System.Windows.Forms.Padding(4);
            this.combobox_role.Name = "combobox_role";
            this.combobox_role.Size = new System.Drawing.Size(132, 24);
            this.combobox_role.TabIndex = 23;
            // 
            // textbox_surname
            // 
            this.textbox_surname.Location = new System.Drawing.Point(309, 124);
            this.textbox_surname.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_surname.Name = "textbox_surname";
            this.textbox_surname.Size = new System.Drawing.Size(132, 22);
            this.textbox_surname.TabIndex = 12;
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(309, 161);
            this.textbox_email.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(132, 22);
            this.textbox_email.TabIndex = 14;
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(309, 81);
            this.textbox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(132, 22);
            this.textbox_name.TabIndex = 10;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Location = new System.Drawing.Point(128, 206);
            this.label_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(36, 16);
            this.label_role.TabIndex = 21;
            this.label_role.Text = "Role";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(128, 165);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(41, 16);
            this.label_email.TabIndex = 15;
            this.label_email.Text = "Email";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(128, 128);
            this.label_surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(61, 16);
            this.label_surname.TabIndex = 13;
            this.label_surname.Text = "Surname";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(128, 85);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 16);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "Name";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(100, 319);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 28);
            this.button_cancel.TabIndex = 22;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(245, 319);
            this.button_apply.Margin = new System.Windows.Forms.Padding(4);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(100, 28);
            this.button_apply.TabIndex = 24;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(380, 319);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 28);
            this.button_ok.TabIndex = 20;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_ok_Click);
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 434);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.combobox_role);
            this.Controls.Add(this.textbox_surname);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserEditForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_role;
        private System.Windows.Forms.TextBox textbox_surname;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_ok;
    }
}