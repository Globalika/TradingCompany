using System;
using System.Windows.Forms;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services;
using TradingCompany.DAL.Repositories.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstract;
using System.Linq;

namespace TradingCompany.FormsUI.Login
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IAuthenticationService _authService;
        public RegistrationForm(IAuthenticationService authService, IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
            _authService = authService;
            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            combobox_role.Items.AddRange(_roleService.GetRoleNames().ToArray());
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            //UserRegistrationModel model = new UserRegistrationModel();
            //if (textbox_password.Text == textbox_verify_password.Text)
            //{
            //    model.Password = textbox_email.Text;
            //}
            //else
            //{
            //    MessageBox.Show(
            //        "Passwords are not match!",
            //        "Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}
            ////TODO Validation parameters
            //model.FirstName = textbox_name.Text;
            //model.LastName = textbox_surname.Text;
            //model.Email = textbox_email.Text;
            //model.Role = combobox_role.SelectedItem.ToString();
            //_userService.Create(model);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
