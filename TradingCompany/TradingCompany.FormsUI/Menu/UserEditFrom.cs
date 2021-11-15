using System;
using System.Linq;
using System.Windows.Forms;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstract;

namespace TradingCompany.FormsUI.Menu
{
    public partial class UserEditForm : Form
    {
        readonly private UserViewModel _user;
        readonly private IRoleService _roleService;
        readonly private IUserService _userService;

        public UserEditForm(UserViewModel user, IRoleService roleService, IUserService userService)
        {
            _user = user;
            _roleService = roleService;
            _userService = userService;
            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            textbox_name.Text = _user.FirstName;
            textbox_surname.Text = _user.LastName;
            textbox_email.Text = _user.Email;
            combobox_role.Items.AddRange(_roleService.GetRoleNames().ToArray());
            combobox_role.SelectedItem = _user.Role;
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            UserViewModel user = new UserViewModel();
            if (textbox_email.Text == _user.Email || _userService.IsEmailExists(textbox_email.Text))
            {
                user.FirstName = textbox_name.Text;
                user.LastName = textbox_surname.Text;
                user.Email = textbox_email.Text;
                user.Role = combobox_role.SelectedItem.ToString();
                user.HashPassword = _user.HashPassword;
                user.Id = _user.Id;
                if (_userService.Update(user))
                {
                    MessageBox.Show(
                        "User was updated!",
                        "Ok",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Invalid data!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ;
                }
            }
            else
            {
                MessageBox.Show(
                   "Email already exists!",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
