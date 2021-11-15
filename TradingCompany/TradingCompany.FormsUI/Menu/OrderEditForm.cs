using System;
using System.Linq;
using System.Windows.Forms;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstract;

namespace TradingCompany.FormsUI.Menu
{
    public partial class OrderEditForm : Form
    {
        readonly private OrderViewModel _order;
        readonly private IUserService _userService;
        readonly private IOrderService _orderService;

        public OrderEditForm(OrderViewModel order, IUserService userService, IOrderService orderService)
        {
            _order = order;
            _userService = userService;
            _orderService = orderService;
            InitializeComponent();
            SetUpForm();
        }
        private void SetUpForm()
        {
            textbox_destination.Text = _order.Destination;
            datetime_picker_date.Value = Convert.ToDateTime(_order.OrderDate);
            combobox_user.Items.AddRange(_userService.GetUserNames().ToArray());
            combobox_user.SelectedItem = _order.User;
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            OrderViewModel order = new OrderViewModel();
            order.Destination = textbox_destination.Text;
            order.OrderDate = Convert.ToDateTime(datetime_picker_date.Value);
            order.User = combobox_user.SelectedItem.ToString();
            order.Id = _order.Id;
            if (_orderService.Update(order))
                MessageBox.Show(
                    "Order was updated!",
                    "Ok",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
