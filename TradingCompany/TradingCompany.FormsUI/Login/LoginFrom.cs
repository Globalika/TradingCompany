using System;
using System.Windows.Forms;
using TradingCompany.DAL.Repositories.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.FormsUI.Menu;
using TradingCompany.BLL.Security;
using TradingCompany.BLL.Services.Abstract;
using TradingCompany.BLL;
using TradingCompany.BLL.DTO;
using Unity.Resolution;

namespace TradingCompany.FormsUI.Login
{
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        public LoginForm(IAuthenticationService authenticationService, IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;

            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }


        private void Button_sing_up_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_sign_in_Click(object sender, EventArgs e)
        {
            CredentialsDTO credentials = new CredentialsDTO()
            {
                Login = textbox_email.Text,
                Password = textbox_password.Text
            };

            if (_authenticationService.UserExist(textbox_email.Text))
            {
                if (_authenticationService.CheckCredentials(credentials))
                {
                    MenuForm menu = DependencyInjectorBLL.Resolve<MenuForm>(
                        new ParameterOverride("user", _userService.GetByEmail(credentials.Login)));
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                       "Wrong password!",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                   "There is no such user!",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void Button_create_account_Click(object sender, EventArgs e)
        {
            var form = DependencyInjectorBLL.Resolve<UserAddForm>();
            form.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
