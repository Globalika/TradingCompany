using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.BLL;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstract;
using Unity.Resolution;

namespace TradingCompany.FormsUI.Menu
{
    public partial class UsersForm : Form
    {
        private readonly IUserService _userService;
        private IEnumerable<UserViewModel> _dataGridObjects;
        private IEnumerable<UserViewModel> _filtedDataGridObjects;
        private Regex filter = new Regex(@"\w *");
        public UsersForm(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            RestoreDataGrid();
        }
        private void RestoreDataGrid()
        {
            _dataGridObjects = _userService.GetViewModels();
            UpdateDataGrid();
        }
        private void UpdateDataGrid()
        {
            _filtedDataGridObjects = (_dataGridObjects).Where(u => filter.IsMatch(u.FirstName) ||
            filter.IsMatch(u.LastName) ||
            filter.IsMatch(u.Email));
            userViewModelBindingSource.DataSource = _filtedDataGridObjects;
        }
        private void Datagrid_recent_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserViewModel user = (_filtedDataGridObjects.ToList()[e.RowIndex]);
            var userForm = DependencyInjectorBLL.Resolve<UserEditForm>(new ParameterOverride("user", user));
            userForm.Show();
        }

        private void Button_add_user_Click(object sender, EventArgs e)
        {
            var form = DependencyInjectorBLL.Resolve<UserAddForm>();
            form.Show();
        }
        private void Textbox_search_KeyPressed(object sender, EventArgs e)
        {
            var option = textbox_search.Text;
            filter = new Regex(string.Format(@"\w*{0}\w*", option));
            UpdateDataGrid();
        }

        private void Button_reload_Click(object sender, EventArgs e)
        {
            RestoreDataGrid();
        }
        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Datagrid_recent_orders_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
