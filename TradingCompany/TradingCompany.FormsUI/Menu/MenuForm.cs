using System;
using System.Windows.Forms;
using TradingCompany.BLL;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstract;

namespace TradingCompany.FormsUI.Menu
{
    public partial class MenuForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly UserDTO _user;
        public MenuForm(IOrderService orderService, IUserService userService, UserDTO user)
        {
            _orderService = orderService;
            _userService = userService;
            _user = user;
            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            timer1.Start();
            ordersDTOBindingSource.DataSource = _orderService.GetViewModels();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            label_name.Text = string.Format("{0} {1}", _user.LastName, _user.FirstName);
        }

        private void Process1_Exited(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label_clock.Text = DateTime.Now.ToString("hh:mm:ss");
            label_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void Datagrid_recent_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Button_customers_Click(object sender, EventArgs e)
        {
            var usersForm = DependencyInjectorBLL.Resolve<UsersForm>();
            usersForm.Show();
        }

        private void Datagrid_recent_orders_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_view_all_Click(object sender, EventArgs e)
        {

        }

        private void Button_sign_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buttutton_orders_Click(object sender, EventArgs e)
        {
            var usersForm = DependencyInjectorBLL.Resolve<OrdersManagerForm>();
            usersForm.Show();
        }
    }
}
