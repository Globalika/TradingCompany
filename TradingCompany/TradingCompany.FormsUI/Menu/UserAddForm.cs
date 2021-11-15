using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstract;
using TradingCompany.BLL.Models;

namespace TradingCompany.FormsUI.Menu
{
    public partial class UserAddForm : Form
    {
        readonly private UserDTO _user;
        readonly private IRoleService _roleService;
        readonly private IUserService _userService;

        public UserAddForm(UserDTO userDTO, IRoleService roleService, IUserService userService)
        {
            _user = userDTO;
            _roleService = roleService;
            _userService = userService;
            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            combobox_role.Items.AddRange(_roleService.GetRoleNames().ToArray());
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            //TODO validation

            if (_userService.IsEmailExists(textbox_email.Text))
            {
                if (textbox_password.Text == textbox_verify_password.Text)
                {
                    UserViewModel user = new UserViewModel();
                    user.FirstName = textbox_name.Text;
                    user.LastName = textbox_surname.Text;
                    user.Email = textbox_email.Text;
                    user.HashPassword = _userService.GetHashedPassword(textbox_password.Text);
                    user.Role = combobox_role.SelectedItem.ToString();
                    _userService.Create(user);
                    MessageBox.Show(
                        "User was added successully!",
                        "OK",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                    this.Close();

                }
                else
                {
                    MessageBox.Show(
                        "Passwords are not match!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(
                    "Email is already exists!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Checkbox_pwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_pwd.Checked)
            {
                textbox_password.UseSystemPasswordChar = false;
                textbox_verify_password.UseSystemPasswordChar = false;
                return;
            }
            textbox_password.UseSystemPasswordChar = true;
            textbox_verify_password.UseSystemPasswordChar = true;
            return;
        }

        private void Textbox_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_role_Click(object sender, EventArgs e)
        {

        }

        private void Label_email_Click(object sender, EventArgs e)
        {

        }

        private void Label_surname_Click(object sender, EventArgs e)
        {

        }

        private void Label_name_Click(object sender, EventArgs e)
        {

        }

        private void Combobox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_verify_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_password_Click(object sender, EventArgs e)
        {

        }

        private void Label_verify_password_Click(object sender, EventArgs e)
        {

        }

        private void UserAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
